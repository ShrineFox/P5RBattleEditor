using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        const int SKILL_SEGMENT0_ENTRY_SIZE = 8;
        const int SKILL_SEGMENT1_ENTRY_SIZE = 48;

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
                        element.Inheritable = br.ReadBoolean();
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

                    // Segment 0: Skill Elements
                    uint segment1Size = Convert.ToUInt32(SKILL_SEGMENT1_ENTRY_SIZE * SkillTblData.SkillElements.Count);
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
                }
            }
        }
    }
}
