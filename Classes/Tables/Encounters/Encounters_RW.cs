using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using static P5RBattleEditor.MainForm;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        const int ENCOUNT_SEGMENT0_ENTRY_SIZE = 44;
        const int ENCOUNT_SEGMENT1_ENTRY_SIZE = 8;
        const int ENCOUNT_SEGMENT2_ENTRY_SIZE = 164;

        private EncountTableData ReadP5REncountTbl(string path)
        {
            EncountTableData tblData = new EncountTableData();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (EndianBinaryReader br = new EndianBinaryReader(fs, Endianness.BigEndian))
                {
                    // Segment 0: Encounter Data
                    uint segment0Size = br.ReadUInt32();
                    for (int i = 0; i < (segment0Size / ENCOUNT_SEGMENT0_ENTRY_SIZE); i++)
                    {
                        Encounter encounter = new Encounter() { Id = i };

                        // Bit flags
                        encounter.Flags = ReadEncounterFlags(br);

                        // Unknown
                        encounter.Field04 = br.ReadUInt16();
                        encounter.Field06 = br.ReadUInt16();
                        // Units
                        const int BATTLEUNITS_ENTRY_COUNT = 5;
                        for (int x = 0; x < BATTLEUNITS_ENTRY_COUNT; x++)
                            encounter.BattleUnits[x] = br.ReadUInt16();
                        // Field
                        encounter.FieldMajor = br.ReadUInt16();
                        encounter.FieldMinor = br.ReadUInt16();
                        encounter.Music = br.ReadUInt16();
                        // Extra Data
                        encounter.Replacements = new EnemyReplacementData()
                        {
                            EnemyID = br.ReadUInt16(),
                            Chance = br.ReadByte(),
                            ChancePerSlot = new byte[] { br.ReadByte(), br.ReadByte(), 
                                br.ReadByte(), br.ReadByte(), br.ReadByte() }
                        };
                        encounter.Disastershadows = new DiasterShadowData()
                        {
                            Chance = br.ReadByte(),
                            ChancePerSlot = new byte[] { br.ReadByte(), br.ReadByte(), 
                                br.ReadByte(), br.ReadByte(), br.ReadByte() },
                            MaxDisasterShadows = br.ReadByte()
                        };
                        encounter.Field0F = br.ReadByte();
                        encounter.Field10 = br.ReadByte();
                        encounter.Field11 = br.ReadByte();
                        encounter.Field12 = br.ReadByte();
                        encounter.Field13 = br.ReadByte();

                        tblData.Encounters.Add(encounter);
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 1: Forced Party Data
                    uint segment1Size = br.ReadUInt32();
                    for (int x = 0; x < (segment1Size / ENCOUNT_SEGMENT1_ENTRY_SIZE); x++)
                    {
                        tblData.Encounters[x].ForcedPartyData = new ushort[] { 
                            br.ReadUInt16(), br.ReadUInt16(), br.ReadUInt16(), br.ReadUInt16(), };
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);


                    // Segment 2: Challenge Battle Data
                    uint segment2Size = br.ReadUInt32();
                    for (int i = 0; i < (segment2Size / ENCOUNT_SEGMENT2_ENTRY_SIZE); i++)
                    {
                        ChallengeBattleData challengeData = new ChallengeBattleData();

                        challengeData.Category = br.ReadUInt16();
                        challengeData.CategoryIndex = br.ReadUInt16();
                        br.BaseStream.Position += 4; // padding
                        challengeData.Flag = br.ReadUInt32();

                        // Bonuses
                        challengeData.TurnBonusCount = br.ReadUInt16();
                        br.BaseStream.Position += 2; // padding
                        challengeData.TurnBonus = br.ReadUInt32();
                        List<Bonus> bonuses = new List<Bonus>();
                        const int BONUS_COUNT = 5;
                        for (int x = 0; x < BONUS_COUNT; x++)
                            bonuses.Add(new Bonus() { Target = br.ReadUInt32(), 
                                Type = br.ReadUInt32(), Multiplier = br.ReadSingle() });
                        challengeData.Bonuses = bonuses.ToArray();

                        // Misc
                        challengeData.WaveEncounters = new uint[] { br.ReadUInt32(), br.ReadUInt32(), 
                            br.ReadUInt32(), br.ReadUInt32(), br.ReadUInt32(), };
                        br.BaseStream.Position += 20; // padding
                        challengeData.Level = br.ReadUInt32();
                        challengeData.IconCount = br.ReadUInt32();
                        
                        // Awards
                        List<Award> awards = new List<Award>();
                        const int AWARD_COUNT = 3;
                        for (int x = 0; x < AWARD_COUNT; x++)
                        {
                            Award award = new Award();
                            award.RequiredScore = br.ReadUInt32();
                            br.BaseStream.Position += 6; // padding
                            award.ItemID = br.ReadUInt16();
                            awards.Add(award);
                        }
                        challengeData.Awards = awards.ToArray();

                        tblData.ChallengeBtlData.Add(challengeData);
                    }
                }
            }

            return tblData;
        }

        private void WriteP5REncountTbl(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (EndianBinaryWriter bw = new EndianBinaryWriter(fs, Endianness.BigEndian))
                {
                    // Segment 0: Encounter Data
                    uint segment0Size = Convert.ToUInt32(ENCOUNT_SEGMENT0_ENTRY_SIZE * EncountTblData.Encounters.Count);
                    bw.Write(segment0Size);
                    foreach (var encounter in EncountTblData.Encounters)
                    {
                        // Bit Flags
                        WriteEncounterFlags(bw, encounter.Flags);
                        // Unknown
                        bw.Write(encounter.Field04);
                        bw.Write(encounter.Field06);
                        //Units
                        bw.Write(encounter.BattleUnits);
                        // Field
                        bw.Write(encounter.FieldMajor);
                        bw.Write(encounter.FieldMinor);
                        bw.Write(encounter.Music);
                        // Extra Data
                        bw.Write(encounter.Replacements.EnemyID);
                        bw.Write(encounter.Replacements.Chance);
                        bw.Write(encounter.Replacements.ChancePerSlot);
                        bw.Write(encounter.Disastershadows.Chance);
                        bw.Write(encounter.Disastershadows.ChancePerSlot);
                        bw.Write(encounter.Disastershadows.MaxDisasterShadows);
                        // Unknown
                        bw.Write(encounter.Field0F);
                        bw.Write(encounter.Field10);
                        bw.Write(encounter.Field11);
                        bw.Write(encounter.Field12);
                        bw.Write(encounter.Field13);
                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 1: Forced Party Data
                    uint segment1Size = Convert.ToUInt32(ENCOUNT_SEGMENT1_ENTRY_SIZE * EncountTblData.Encounters.Count);
                    bw.Write(segment1Size);
                    foreach (var encounter in EncountTblData.Encounters)
                        bw.Write(encounter.ForcedPartyData);

                    Add16ByteAlignmentPadding(bw);

                    // Segment 2: Challenge Battle Data
                    uint segment2Size = Convert.ToUInt32(ENCOUNT_SEGMENT2_ENTRY_SIZE * EncountTblData.ChallengeBtlData.Count);
                    bw.Write(segment2Size);
                    foreach (var challengeBtlData in EncountTblData.ChallengeBtlData)
                    {
                        bw.Write(challengeBtlData.Category);
                        bw.Write(challengeBtlData.CategoryIndex);
                        bw.Write(new byte[4]); // padding
                        bw.Write(challengeBtlData.Flag);
                        bw.Write(challengeBtlData.TurnBonusCount);
                        bw.Write(new byte[2]); // padding
                        bw.Write(challengeBtlData.TurnBonus);
                        foreach (var bonus in challengeBtlData.Bonuses)
                        {
                            bw.Write(bonus.Target);
                            bw.Write(bonus.Type);
                            bw.Write(bonus.Multiplier);
                        }
                        bw.Write(challengeBtlData.WaveEncounters);
                        bw.Write(new byte[20]); // padding
                        bw.Write(challengeBtlData.Level);
                        bw.Write(challengeBtlData.IconCount);
                        foreach (var award in challengeBtlData.Awards)
                        {
                            bw.Write(award.RequiredScore);
                            bw.Write(new byte[6]); // padding
                            bw.Write(award.ItemID);
                        }
                    }

                    Add16ByteAlignmentPadding(bw);
                }
            }
        }

        private void WriteEncounterFlags(EndianBinaryWriter bw, EncounterFlags flags)
        {
            List<bool[]> boolSets = new List<bool[]>
            {
                new bool[] { flags.Bit0, flags.Bit1, flags.Bit2, flags.Bit3, flags.Bit4, flags.Bit5, flags.Bit6, flags.Bit7 },
                new bool[] { flags.Bit8, flags.Bit9, flags.Bit10, flags.Bit11, flags.NoNegotiation, flags.Bit13, flags.Bit14, flags.Bit15 },
                new bool[] { flags.NoKnockdown, flags.PositionHack, flags.NoHoldUp, flags.NoDisappear, flags.BulletHailOnStart, flags.NoNegotiation, flags.Bit22, flags.LoadBattleScript },
                new bool[] { flags.Bit24, flags.Bit25, flags.LoadBFLBattleScript, flags.EnemyFirstAct, flags.NoCritical, flags.Bit29, flags.Bit30, flags.NoEscape }
            };

            foreach (var flagCollection in boolSets)
                bw.Write(ConvertBoolsToByte(flagCollection));
        }

        private EncounterFlags ReadEncounterFlags(EndianBinaryReader br)
        {
            var encounterFlags = new EncounterFlags();

            var EncounterFlags1 = ConvertByteToBools(br.ReadByte());
            var EncounterFlags2 = ConvertByteToBools(br.ReadByte());
            var EncounterFlags3 = ConvertByteToBools(br.ReadByte());
            var EncounterFlags4 = ConvertByteToBools(br.ReadByte());

            encounterFlags.Bit0 = EncounterFlags1[0]; encounterFlags.Bit8 = EncounterFlags2[0];
            encounterFlags.Bit1 = EncounterFlags1[1]; encounterFlags.Bit9 = EncounterFlags2[1];
            encounterFlags.Bit2 = EncounterFlags1[2]; encounterFlags.Bit10 = EncounterFlags2[2];
            encounterFlags.Bit3 = EncounterFlags1[3]; encounterFlags.Bit11 = EncounterFlags2[3];
            encounterFlags.Bit4 = EncounterFlags1[4]; encounterFlags.NoNegotiation = EncounterFlags2[4];
            encounterFlags.Bit5 = EncounterFlags1[5]; encounterFlags.Bit13 = EncounterFlags2[5];
            encounterFlags.Bit6 = EncounterFlags1[6]; encounterFlags.Bit14 = EncounterFlags2[6];
            encounterFlags.Bit7 = EncounterFlags1[7]; encounterFlags.Bit15 = EncounterFlags2[7];

            encounterFlags.NoKnockdown = EncounterFlags3[0]; encounterFlags.Bit24 = EncounterFlags4[0];
            encounterFlags.PositionHack = EncounterFlags3[1]; encounterFlags.Bit25 = EncounterFlags4[1];
            encounterFlags.NoHoldUp = EncounterFlags3[2]; encounterFlags.LoadBFLBattleScript = EncounterFlags4[2];
            encounterFlags.NoDisappear = EncounterFlags3[3]; encounterFlags.EnemyFirstAct = EncounterFlags4[3];
            encounterFlags.BulletHailOnStart = EncounterFlags3[4]; encounterFlags.NoCritical = EncounterFlags4[4];
            encounterFlags.NoNavi = EncounterFlags3[5]; encounterFlags.Bit29 = EncounterFlags4[5];
            encounterFlags.Bit22 = EncounterFlags3[6]; encounterFlags.Bit30 = EncounterFlags4[6];
            encounterFlags.LoadBattleScript = EncounterFlags3[7]; encounterFlags.NoEscape = EncounterFlags4[7];

            return encounterFlags;
        }

    }
}
