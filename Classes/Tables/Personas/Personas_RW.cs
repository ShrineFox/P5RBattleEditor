using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        const int PERSONA_SEGMENT0_ENTRY_SIZE = 14;
        const int PERSONA_SEGMENT1_ENTRY_SIZE = 70;
        const int PERSONA_SEGMENT2_ENTRY_SIZE = 392;
        const int PERSONA_SEGMENT3_ENTRY_SIZE = 622;

        private PersonaTableData ReadP5RPersonaTbl(string path)
        {
            PersonaTableData tblData = new PersonaTableData();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (EndianBinaryReader br = new EndianBinaryReader(fs, Endianness.BigEndian))
                {
                    // Segment 0: Persona Stats
                    uint segment0Size = br.ReadUInt32();
                    for (int i = 0; i < (segment0Size / PERSONA_SEGMENT0_ENTRY_SIZE); i++)
                    {
                        PersonaStats persona = new PersonaStats() { Id = i };

                        persona.DLCorTreasureDemon = br.ReadByte();
                        persona.Bitflags = ConvertByteToBools(br.ReadByte());
                        persona.Arcana = br.ReadByte();
                        persona.BaseLevel = br.ReadByte();
                        persona.Stats.Strength = br.ReadByte();
                        persona.Stats.Magic = br.ReadByte();
                        persona.Stats.Endurance = br.ReadByte();
                        persona.Stats.Agility = br.ReadByte();
                        persona.Stats.Luck = br.ReadByte();
                        br.BaseStream.Position += 1; // padding
                        persona.SkillInheritance = br.ReadUInt16();
                        persona.Unknown = br.ReadUInt16();

                        tblData.Stats.Add(persona);
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 1: Persona Stat Growth & Skill Inheritance
                    uint segment1Size = br.ReadUInt32();
                    for (int i = 0; i < (segment1Size / PERSONA_SEGMENT1_ENTRY_SIZE); i++)
                    {
                        tblData.Stats[i].WeightedStatGrowthDistribution = new BattleStats();
                        tblData.Stats[i].WeightedStatGrowthDistribution.Strength = br.ReadByte();
                        tblData.Stats[i].WeightedStatGrowthDistribution.Magic = br.ReadByte();
                        tblData.Stats[i].WeightedStatGrowthDistribution.Endurance = br.ReadByte();
                        tblData.Stats[i].WeightedStatGrowthDistribution.Agility = br.ReadByte();
                        tblData.Stats[i].WeightedStatGrowthDistribution.Luck = br.ReadByte();
                        tblData.Stats[i].UnknownU8 = br.ReadByte();
                        for (int x = 0; x < tblData.Stats[i].PendingSkillsorTraits.Length; x++)
                        {
                            tblData.Stats[i].PendingSkillsorTraits[x] = new PendingSkillorTrait();
                            tblData.Stats[i].PendingSkillsorTraits[x].PendingLevels = br.ReadByte();
                            tblData.Stats[i].PendingSkillsorTraits[x].Learnability = br.ReadByte();
                            var union = ReadUnionBitfield(br);
                            tblData.Stats[i].PendingSkillsorTraits[x].SkillID = union.Field1;
                            tblData.Stats[i].PendingSkillsorTraits[x].TraitID = union.Field2;
                        }
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 2: Party Member Levelup Thresholds
                    uint segment2Size = br.ReadUInt32();
                    for (int i = 0; i < (segment2Size / PERSONA_SEGMENT2_ENTRY_SIZE); i++)
                    {
                        tblData.PartyLevelUpThresholds[i] = new PtyLvlUp() { Id = i };
                        for (int x = 0; x < tblData.PartyLevelUpThresholds[i].ExpRequired.Length; x++)
                            tblData.PartyLevelUpThresholds[i].ExpRequired[x] = br.ReadUInt32();
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 3: Party Member Personas
                    uint segment3Size = br.ReadUInt32();
                    for (int i = 0; i < (segment3Size / PERSONA_SEGMENT3_ENTRY_SIZE); i++)
                    {
                        var ptyMemberPersona = new PtyMemberPersona() { Id = i };
                        ptyMemberPersona.Character = br.ReadUInt16();
                        ptyMemberPersona.LevelsAvailable = br.ReadByte();
                        ptyMemberPersona.UnknownU8 = br.ReadByte();
                        for (int x = 0; x < ptyMemberPersona.PendingSkillsorTraits.Length; x++)
                        {
                            ptyMemberPersona.PendingSkillsorTraits[x] = new PendingSkillorTrait();
                            ptyMemberPersona.PendingSkillsorTraits[x].PendingLevels = br.ReadByte();
                            ptyMemberPersona.PendingSkillsorTraits[x].Learnability = br.ReadByte();
                            var union = ReadUnionBitfield(br);
                            ptyMemberPersona.PendingSkillsorTraits[x].SkillID = union.Field1;
                            ptyMemberPersona.PendingSkillsorTraits[x].TraitID = union.Field2;
                        }
                        for (int x = 0; x < ptyMemberPersona.StatGainPerLevel.Length; x++)
                        {
                            ptyMemberPersona.StatGainPerLevel[x] = new BattleStats();
                            ptyMemberPersona.StatGainPerLevel[x].Strength = br.ReadByte();
                            ptyMemberPersona.StatGainPerLevel[x].Magic = br.ReadByte();
                            ptyMemberPersona.StatGainPerLevel[x].Endurance = br.ReadByte();
                            ptyMemberPersona.StatGainPerLevel[x].Agility = br.ReadByte();
                            ptyMemberPersona.StatGainPerLevel[x].Luck = br.ReadByte();
                        }
                        tblData.PartyMemberPersonas.Add(ptyMemberPersona);
                    }
                }
            }

            return tblData;
        }

        private void WriteP5RPersonaTbl(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (EndianBinaryWriter bw = new EndianBinaryWriter(fs, Endianness.BigEndian))
                {
                    // Segment 0: Persona Stats
                    uint segment0Size = Convert.ToUInt32(PERSONA_SEGMENT0_ENTRY_SIZE * project.PersonaTblData.Stats.Count);
                    bw.Write(segment0Size);
                    foreach (var persona in project.PersonaTblData.Stats)
                    {
                        bw.Write(persona.DLCorTreasureDemon);
                        bw.Write(ConvertBoolsToByte(persona.Bitflags));
                        bw.Write(persona.Arcana);
                        bw.Write(persona.BaseLevel);
                        bw.Write(persona.Stats.Strength);
                        bw.Write(persona.Stats.Magic);
                        bw.Write(persona.Stats.Endurance);
                        bw.Write(persona.Stats.Agility);
                        bw.Write(persona.Stats.Luck);
                        bw.Write(new byte()); // padding
                        bw.Write(persona.SkillInheritance);
                        bw.Write(persona.Unknown);
                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 1: Persona Stat Growth & Skill Inheritance
                    uint segment1Size = Convert.ToUInt32(PERSONA_SEGMENT1_ENTRY_SIZE * project.PersonaTblData.Stats.Count);
                    bw.Write(segment1Size);
                    foreach (var persona in project.PersonaTblData.Stats)
                    {
                        bw.Write(persona.WeightedStatGrowthDistribution.Strength);
                        bw.Write(persona.WeightedStatGrowthDistribution.Magic);
                        bw.Write(persona.WeightedStatGrowthDistribution.Endurance);
                        bw.Write(persona.WeightedStatGrowthDistribution.Agility);
                        bw.Write(persona.WeightedStatGrowthDistribution.Luck);
                        bw.Write(persona.UnknownU8);
                        foreach(var pendingSkill in persona.PendingSkillsorTraits)
                        {
                            bw.Write(pendingSkill.PendingLevels);
                            bw.Write(pendingSkill.Learnability);
                            WriteUnionBitfield(bw, new UnionBitfield() { Field1 = pendingSkill.SkillID, Field2 = pendingSkill.TraitID });
                        }
                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 2: Party Member Levelup Thresholds
                    uint segment2Size = Convert.ToUInt32(PERSONA_SEGMENT2_ENTRY_SIZE * project.PersonaTblData.PartyLevelUpThresholds.Length);
                    bw.Write(segment2Size);
                    foreach (var partyMember in project.PersonaTblData.PartyLevelUpThresholds)
                    {
                        foreach(var level in partyMember.ExpRequired)
                            bw.Write(level);
                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 3: Party Member Personas
                    uint segment3Size = Convert.ToUInt32(PERSONA_SEGMENT3_ENTRY_SIZE * project.PersonaTblData.PartyMemberPersonas.Count);
                    bw.Write(segment3Size);
                    foreach (var persona in project.PersonaTblData.PartyMemberPersonas)
                    {
                        bw.Write(persona.Character);
                        bw.Write(persona.LevelsAvailable);
                        bw.Write(persona.UnknownU8);
                        foreach(var pendingSkill in persona.PendingSkillsorTraits)
                        {
                            bw.Write(pendingSkill.PendingLevels);
                            bw.Write(pendingSkill.Learnability);
                            WriteUnionBitfield(bw, new UnionBitfield() { Field1 = pendingSkill.SkillID, Field2 = pendingSkill.TraitID });
                        }
                        foreach (var level in persona.StatGainPerLevel)
                        {
                            bw.Write(level.Strength);
                            bw.Write(level.Magic);
                            bw.Write(level.Endurance);
                            bw.Write(level.Agility);
                            bw.Write(level.Luck);
                        }
                    }

                    Add16ByteAlignmentPadding(bw);
                }
            }
        }

    }
}
