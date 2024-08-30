using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        const int SKILL_SEGMENT0_ENTRY_SIZE = 8;
        const int SKILL_SEGMENT1_ENTRY_SIZE = 48;
        const int SKILL_SEGMENT2_ENTRY_SIZE = 40;
        const int SKILL_SEGMENT3_ENTRY_SIZE = 60;

        private SkillTableData ReadP5RSkillTbl(string path)
        {
            SkillTableData tblData = new SkillTableData();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (EndianBinaryReader br = new EndianBinaryReader(fs, Endianness.BigEndian))
                {
                    // Segment 0: Skill Elements
                    uint segment0Size = br.ReadUInt32();
                    for (int i = 0; i < (segment0Size / SKILL_SEGMENT0_ENTRY_SIZE); i++)
                    {
                        var element = new ElementData();

                        element.ElementType = br.ReadByte();
                        element.ActiveOrPassive = br.ReadByte();
                        element.Inheritable = br.ReadByte();
                        element.UnknownR_1 = br.ReadByte();
                        element.UnknownR_2 = br.ReadByte();
                        element.UnknownR_3 = br.ReadByte();
                        element.UnknownR_4 = br.ReadByte();
                        element.RedundantBitfield = br.ReadByte();

                        tblData.SkillElements.Add(element);
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 1: Active Skill Data
                    uint segment1Size = br.ReadUInt32();
                    for (int i = 0; i < (segment1Size / SKILL_SEGMENT1_ENTRY_SIZE); i++)
                    {
                        ActiveSkill skill = new ActiveSkill();

                        skill.UnknownR_1 = br.ReadByte();
                        skill.ConditionUsage = br.ReadByte();
                        skill.CasterEffect_1 = br.ReadByte();
                        skill.CasterEffect_2 = br.ReadByte();
                        skill.UnknownR_2 = br.ReadByte();
                        skill.Area_Type = br.ReadByte();
                        skill.Damage_Stat = br.ReadByte();
                        skill.Cost_Type = br.ReadByte();
                        skill.SkillCost = br.ReadUInt16();
                        skill.SkillCostScale = br.ReadByte();
                        skill.PhysicalSkill = br.ReadBoolean();
                        skill.TargetType = br.ReadByte();
                        skill.Valid_Targets = br.ReadByte();
                        skill.Target_Restrictions = br.ReadByte();
                        skill.Unknown_1 = br.ReadByte();
                        skill.Unknown_2 = br.ReadByte();
                        skill.Unknown_3 = br.ReadByte();
                        skill.Unknown_4 = br.ReadByte();
                        skill.Unknown_5 = br.ReadByte();
                        skill.Accuracy = br.ReadByte();
                        skill.NumberOfHits_Min = br.ReadByte();
                        skill.NumberOfHits_Max = br.ReadByte();
                        skill.DamageType = br.ReadByte();
                        skill.BaseDamage = br.ReadUInt16();
                        skill.DepleteOrRestoreSP = br.ReadByte();
                        skill.Unknown_6 = br.ReadByte();
                        skill.SPAmount = br.ReadUInt16();
                        skill.ApplyOrCureEffect = br.ReadByte();
                        skill.EffectChance = br.ReadByte();
                        skill.Unknown_7 = br.ReadByte();
                        skill.EffectList1 = ConvertByteToBools(br.ReadByte());
                        skill.EffectList2 = ConvertByteToBools(br.ReadByte());
                        skill.EffectList3 = ConvertByteToBools(br.ReadByte());
                        skill.EffectList4 = ConvertByteToBools(br.ReadByte());
                        skill.EffectList5 = ConvertByteToBools(br.ReadByte());
                        skill.EffectList6 = ConvertByteToBools(br.ReadByte());
                        skill.BuffsAndDebuffs = ConvertByteToBools(br.ReadByte());
                        skill.UnknownR_3 = br.ReadByte();
                        skill.RESERVE_2A = br.ReadUInt16();
                        skill.Other_Buffs = br.ReadByte();
                        skill.Extra_Effects = br.ReadByte();
                        skill.CritChance = br.ReadByte();
                        skill.UnknownForItem = br.ReadByte();
                        skill.Unknown_8 = br.ReadByte();

                        tblData.ActiveSkillData.Add(skill);
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 2: Technical Combo Map
                    uint segment2Size = br.ReadUInt32();
                    for (int i = 0; i < (segment2Size / SKILL_SEGMENT2_ENTRY_SIZE); i++)
                    {
                        TechnicalCombo combo = new TechnicalCombo();

                        combo.ApplicableAilments = ReadAilmentStatus(br);
                        combo.AllAffinitiesAreTechnical = Convert.ToBoolean(br.ReadInt32());
                        combo.TechnicalAffinities = new int[] { br.ReadInt32(),
                            br.ReadInt32(), br.ReadInt32(), br.ReadInt32(), br.ReadInt32() };
                        combo.DamageMultiplier = br.ReadUInt32();
                        combo.UnknownR = br.ReadInt32();
                        int requiresKnowHeart = br.ReadInt32();
                        if (requiresKnowHeart == 0x3000013d)
                            combo.RequiresKnowTheHeart = true;
                        

                        tblData.TechnicalComboMap.Add(combo);
                    }

                    br.BaseStream.Position += Get16ByteAlignmentPadding(br);

                    // Segment 3: Trait Data
                    uint segment3Size = br.ReadUInt32();
                    for (int i = 0; i < (segment3Size / SKILL_SEGMENT3_ENTRY_SIZE); i++)
                    {
                        TraitData trait = new TraitData();

                        trait.Effect = br.ReadUInt16();
                        trait.Field2 = br.ReadUInt16();
                        trait.EffectRate = br.ReadInt32();
                        trait.SubTrait = br.ReadInt32();
                        trait.EffectSize = br.ReadSingle();
                        trait.SubstituteTraits = new int[] { br.ReadInt32(),
                            br.ReadInt32(),br.ReadInt32(),br.ReadInt32(),br.ReadInt32(),
                        br.ReadInt32(),br.ReadInt32(),br.ReadInt32(),br.ReadInt32(),
                        br.ReadInt32()};
                        trait.Flags = ReadTraitFlags(br);

                        tblData.Traits.Add(trait);
                    }
                }
            }

            return tblData;
        }

        private void WriteP5RSkillTbl(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (EndianBinaryWriter bw = new EndianBinaryWriter(fs, Endianness.BigEndian))
                {
                    // Segment 0: Skill Elements
                    uint segment0Size = Convert.ToUInt32(SKILL_SEGMENT0_ENTRY_SIZE * SkillTblData.SkillElements.Count);
                    bw.Write(segment0Size);
                    foreach (var element in SkillTblData.SkillElements)
                    {
                        bw.Write(element.ElementType);
                        bw.Write(element.ActiveOrPassive);
                        bw.Write(element.Inheritable);
                        bw.Write(element.UnknownR_1);
                        bw.Write(element.UnknownR_2);
                        bw.Write(element.UnknownR_3);
                        bw.Write(element.UnknownR_4);
                        bw.Write(element.RedundantBitfield);
                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 1: Active Skill Data
                    uint segment1Size = Convert.ToUInt32(SKILL_SEGMENT1_ENTRY_SIZE * SkillTblData.ActiveSkillData.Count);
                    bw.Write(segment1Size);
                    foreach (var skill in SkillTblData.ActiveSkillData)
                    {
                        bw.Write(skill.UnknownR_1);
                        bw.Write(skill.ConditionUsage);
                        bw.Write(skill.CasterEffect_1);
                        bw.Write(skill.CasterEffect_2);
                        bw.Write(skill.UnknownR_2);
                        bw.Write(skill.Area_Type);
                        bw.Write(skill.Damage_Stat);
                        bw.Write(skill.Cost_Type);
                        bw.Write(skill.SkillCost);
                        bw.Write(skill.SkillCostScale);
                        bw.Write(skill.PhysicalSkill);
                        bw.Write(skill.TargetType);
                        bw.Write(skill.Valid_Targets);
                        bw.Write(skill.Target_Restrictions);
                        bw.Write(skill.Unknown_1);
                        bw.Write(skill.Unknown_2);
                        bw.Write(skill.Unknown_3);
                        bw.Write(skill.Unknown_4);
                        bw.Write(skill.Unknown_5);
                        bw.Write(skill.Accuracy);
                        bw.Write(skill.NumberOfHits_Min);
                        bw.Write(skill.NumberOfHits_Max);
                        bw.Write(skill.DamageType);
                        bw.Write(skill.BaseDamage);
                        bw.Write(skill.DepleteOrRestoreSP);
                        bw.Write(skill.Unknown_6);
                        bw.Write(skill.SPAmount);
                        bw.Write(skill.ApplyOrCureEffect);
                        bw.Write(skill.EffectChance);
                        bw.Write(skill.Unknown_7);
                        bw.Write(ConvertBoolsToByte(skill.EffectList1));
                        bw.Write(ConvertBoolsToByte(skill.EffectList2));
                        bw.Write(ConvertBoolsToByte(skill.EffectList3));
                        bw.Write(ConvertBoolsToByte(skill.EffectList4));
                        bw.Write(ConvertBoolsToByte(skill.EffectList5));
                        bw.Write(ConvertBoolsToByte(skill.EffectList6));
                        bw.Write(ConvertBoolsToByte(skill.BuffsAndDebuffs));
                        bw.Write(skill.UnknownR_3);
                        bw.Write(skill.RESERVE_2A);
                        bw.Write(skill.Other_Buffs);
                        bw.Write(skill.Extra_Effects);
                        bw.Write(skill.CritChance);
                        bw.Write(skill.UnknownForItem);
                        bw.Write(skill.Unknown_8);
                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 2: Technical Combo Map
                    uint segment2Size = Convert.ToUInt32(SKILL_SEGMENT2_ENTRY_SIZE * SkillTblData.TechnicalComboMap.Count);
                    bw.Write(segment2Size);
                    foreach (var combo in SkillTblData.TechnicalComboMap)
                    {
                        WriteAilmentStatus(bw, combo.ApplicableAilments);

                        bw.Write(Convert.ToInt32(combo.AllAffinitiesAreTechnical));
                        bw.Write(combo.TechnicalAffinities);
                        bw.Write(combo.DamageMultiplier);
                        bw.Write(combo.UnknownR);
                        if (combo.RequiresKnowTheHeart)
                            bw.Write(0x3000013D);
                        else
                            bw.Write(new int());
                    }

                    Add16ByteAlignmentPadding(bw);

                    // Segment 3: Trait Data
                    uint segment3Size = Convert.ToUInt32(SKILL_SEGMENT3_ENTRY_SIZE * SkillTblData.Traits.Count);
                    bw.Write(segment3Size);
                    foreach (var trait in SkillTblData.Traits)
                    {
                        bw.Write(trait.Effect);
                        bw.Write(trait.Field2);
                        bw.Write(trait.EffectRate);
                        bw.Write(trait.SubTrait);
                        bw.Write(trait.EffectSize);
                        bw.Write(trait.SubstituteTraits);

                        WriteTraitFlags(bw, trait.Flags);
                    }

                    Add16ByteAlignmentPadding(bw);
                }
            }
        }
    }
}
