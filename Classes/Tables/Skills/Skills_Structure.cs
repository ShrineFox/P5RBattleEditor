using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public class SkillTableData
        {
            public List<ElementData> SkillElements { get; set; } = new List<ElementData>(); // 1056
            public List<ActiveSkill> ActiveSkillData { get; set; } = new List<ActiveSkill>(); // 800
            public List<TechnicalCombo> TechnicalComboMap { get; set; } = new List<TechnicalCombo>(); // 17
            public List<TraitData> Traits { get; set; } = new List<TraitData>(); // 299
        }

        public class ElementData
        {
            public int Id { get; set; } = 0; // added for convenience
            public string Comment { get; set; } = ""; // added for convenience
            public byte ElementType { get; set; } = Convert.ToByte(ElementalType.Physical);
            public byte ActiveOrPassive { get; set; } = Convert.ToByte(PassiveActive.ActiveSkill);
            public byte Inheritable { get; set; } = 0x00;
            public byte UnknownR_1 { get; set; } = 0x00;
            public byte UnknownR_2 { get; set; } = 0x00;
            public byte UnknownR_3 { get; set; } = 0x00;
            public byte UnknownR_4 { get; set; } = 0x00;
            public byte RedundantBitfield { get; set; } = 0x00;
        }

        public class ActiveSkill
        {
            public int Id { get; set; } = 0; // added for convenience
            public string Comment { get; set; } = ""; // added for convenience
            public byte UnknownR_1 { get; set; } = 0;
            public byte ConditionUsage { get; set; } = Convert.ToByte(SkillCondition.UnknownForMaruki); // Must be accompanied with Value 8 in Caster Effect 2
            public byte CasterEffect_1 { get; set; } = Convert.ToByte(CasterEffect1.NoCasterEffect1);
            public byte CasterEffect_2 { get; set; } = Convert.ToByte(CasterEffect2.NoCasterEffect2);
            public byte UnknownR_2 { get; set; } = 0x00;
            public byte Area_Type { get; set; } = Convert.ToByte(AreaType.UsableInBattle);
            public byte Damage_Stat { get; set; } = Convert.ToByte(DamageStat.NoApplicableStat);
            public byte Cost_Type { get; set; } = Convert.ToByte(CostType.SPCost);
            public ushort SkillCost { get; set; } = 0x00;
            public byte SkillCostScale { get; set; } = 0x00; // add 256 cost for every 1 value
            public bool PhysicalSkill { get; set; } = true; // false for magic, determines what's affected by either Charge or
                                                     // Concentrate, but doesn't seem to change what's reflected by Tetrakarn
                                                     // or Makarakarn. Needs more testing
            public byte TargetType { get; set; } = Convert.ToByte(TargetKind.SingleTarget);
            public byte Valid_Targets { get; set; } = Convert.ToByte(ValidTargets.EnemiesNotAllies);
            public byte Target_Restrictions { get; set; } = Convert.ToByte(TargetRestrictions.NoAdditionalRestrictions);
            public byte Unknown_1 { get; set; } = 0x00;
            public byte Unknown_2 { get; set; } = 0x00;
            public byte Unknown_3 { get; set; } = 0x00;
            public byte Unknown_4 { get; set; } = 0x00;
            public byte Unknown_5 { get; set; } = 0x00;
            public byte Accuracy { get; set; } = 0x00;
            public byte NumberOfHits_Min { get; set; } = 0x01;
            public byte NumberOfHits_Max { get; set; } = 0x01;
            public byte DamageType { get; set; } = Convert.ToByte(HPEffect.DealDamage);
            public ushort BaseDamage { get; set; } = 0x0F;
            public byte DepleteOrRestoreSP { get; set; } = Convert.ToByte(SPEffect.DepleteSP);
            public byte Unknown_6 { get; set; } = 0x00;
            public ushort SPAmount { get; set; } = 0;
            public byte ApplyOrCureEffect { get; set; } = Convert.ToByte(ApplyCureEffect.NoEffect); // Ignore resistance works 100%
                                                                                                    // for Physical. Magic including Light, Dark, Almighty can only
                                                                                                    // Semi Pierce (NULL, DRAIN, REPEL can't be pierced)
            public byte EffectChance { get; set; } = 0x32;
            public byte Unknown_7 { get; set; } = 0x00;
            public bool[] EffectList1 { get; set; } = new bool[8];
            public bool[] EffectList2 { get; set; } = new bool[8];
            public bool[] EffectList3 { get; set; } = new bool[8];
            public bool[] EffectList4 { get; set; } = new bool[8];
            public bool[] EffectList5 { get; set; } = new bool[8];
            public bool[] EffectList6 { get; set; } = new bool[8];

            public bool[] BuffsAndDebuffs { get; set; } = new bool[8];
            public byte UnknownR_3 { get; set; } = 0;
            public ushort RESERVE_2A { get; set; } = 0x00;
            public byte Other_Buffs = Convert.ToByte(OtherBuffs.None);
            public byte Extra_Effects = Convert.ToByte(ExtraEffects.NoEffect6); // Ignore resistance works 100% for Physical.
                                                                         // Magic including Light, Dark, Almighty can only Semi Pierce
                                                                         // (NULL, DRAIN, REPEL can't be pierced).
            public byte CritChance { get; set; } = 0x00; // Only works for Physical or Gun skills
            public byte UnknownForItem { get; set; } = 0x00; // Not sure what this does since it has 20 value on Firecracker, Magatama item
            public byte Unknown_8 { get; set; } = 0x00;

        }
    }
}