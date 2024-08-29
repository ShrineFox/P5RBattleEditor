using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
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
                        Encounter encounter = new Encounter();

                        // Bit flags
                        encounter.EncounterData.Flags = new List<bool[]>
                        {
                            ConvertByteToBools(br.ReadByte()), ConvertByteToBools(br.ReadByte()),
                            ConvertByteToBools(br.ReadByte()), ConvertByteToBools(br.ReadByte())
                        };
                        // Unknown
                        encounter.EncounterData.Field04 = br.ReadUInt16();
                        encounter.EncounterData.Field06 = br.ReadUInt16();
                        // Units
                        const int BATTLEUNITS_ENTRY_COUNT = 5;
                        for (int x = 0; x < BATTLEUNITS_ENTRY_COUNT; x++)
                            encounter.EncounterData.BattleUnits[x] = br.ReadUInt16();
                        // Field
                        encounter.EncounterData.FieldMajor = br.ReadUInt16();
                        encounter.EncounterData.FieldMinor = br.ReadUInt16();
                        encounter.EncounterData.Music = br.ReadUInt16();
                        // Extra Data
                        encounter.EncounterData.Replacements = new EnemyReplacementData()
                        {
                            EnemyID = br.ReadUInt16(),
                            Chance = br.ReadByte(),
                            ChancePerSlot = new byte[] { br.ReadByte(), br.ReadByte(), 
                                br.ReadByte(), br.ReadByte(), br.ReadByte() }
                        };
                        encounter.EncounterData.Disastershadows = new DiasterShadowData()
                        {
                            Chance = br.ReadByte(),
                            ChancePerSlot = new byte[] { br.ReadByte(), br.ReadByte(), 
                                br.ReadByte(), br.ReadByte(), br.ReadByte() },
                            MaxDisasterShadows = br.ReadByte()
                        };
                        encounter.EncounterData.Field0F = br.ReadByte();
                        encounter.EncounterData.Field10 = br.ReadByte();
                        encounter.EncounterData.Field11 = br.ReadByte();
                        encounter.EncounterData.Field12 = br.ReadByte();
                        encounter.EncounterData.Field13 = br.ReadByte();

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
                        foreach (var flagCollection in encounter.EncounterData.Flags)
                            bw.Write(ConvertBoolsToByte(flagCollection));
                        // Unknown
                        bw.Write(encounter.EncounterData.Field04);
                        bw.Write(encounter.EncounterData.Field06);
                        //Units
                        bw.Write(encounter.EncounterData.BattleUnits);
                        // Field
                        bw.Write(encounter.EncounterData.FieldMajor);
                        bw.Write(encounter.EncounterData.FieldMinor);
                        bw.Write(encounter.EncounterData.Music);
                        // Extra Data
                        bw.Write(encounter.EncounterData.Replacements.EnemyID);
                        bw.Write(encounter.EncounterData.Replacements.Chance);
                        bw.Write(encounter.EncounterData.Replacements.ChancePerSlot);
                        bw.Write(encounter.EncounterData.Disastershadows.Chance);
                        bw.Write(encounter.EncounterData.Disastershadows.ChancePerSlot);
                        bw.Write(encounter.EncounterData.Disastershadows.MaxDisasterShadows);
                        // Unknown
                        bw.Write(encounter.EncounterData.Field0F);
                        bw.Write(encounter.EncounterData.Field10);
                        bw.Write(encounter.EncounterData.Field11);
                        bw.Write(encounter.EncounterData.Field12);
                        bw.Write(encounter.EncounterData.Field13);
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

    }
}
