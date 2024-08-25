using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        private List<Skill> ReadP5RSkillTbl(string path)
        {
            List<Skill> skills = new List<Skill>();

            return skills;
        }

        internal class Skill
        {
            ElementData Segment0 { get; set; } = new ElementData(); // 1056
            List<ActiveSkill> Segment1 { get; set; } = new List<ActiveSkill>(); // 1056
            // Segment2: Combo Map
            // Segment3: Trait Data
        }

        internal class ActiveSkill
        {
            byte UnknownR_1 { get; set; } = 0;
            byte ConditionUsage { get; set; } = Convert.ToByte(SkillCondition.UnknownForMaruki); // Must be accompanied with Value 8 in Caster Effect 2
            byte CasterEffect_1 { get; set; } = Convert.ToByte(CasterEffect1.NoCasterEffect1);
            byte CasterEffect_2 { get; set; } = Convert.ToByte(CasterEffect2.NoCasterEffect2);
            byte UnknownR_2 { get; set; } = 0;
            byte Area_Type { get; set;} = Convert.ToByte(AreaType.UsableInBattle);
            byte Damage_Stat { get; set; } = Convert.ToByte(DamageStat.NoApplicableStat);
            byte Cost_Type { get; set; } = Convert.ToByte(CostType.SPCost);
            short SkillCost { get; set; } = 0;
            byte SkillCostScale { get; set; } = 0x00; // add 256 cost for every 1 value
            bool PhysicalSkill { get; set; } = true; // false for magic, determines what's affected by either Charge or
                                                     // Concentrate, but doesn't seem to change what's reflected by Tetrakarn
                                                     // or Makarakarn. Needs more testing
            byte TargetType { get; set; } = Convert.ToByte(TargetKind.SingleTarget);
            byte Valid_Targets { get; set; } = Convert.ToByte(ValidTargets.EnemiesNotAllies);
            byte Target_Restrictions { get; set; } = Convert.ToByte(TargetRestrictions.NoAdditionalRestrictions);
            byte Unknown_1 { get; set; } = 0x00;
            byte Unknown_2 { get; set; } = 0x00;
            byte Unknown_3 { get; set; } = 0x00;
            byte Unknown_4 { get; set; } = 0x00;
            byte Unknown_5 { get; set; } = 0x00;
            byte Accuracy { get; set; } = 0x00;
            byte NumberOfHits_Min { get; set; } = 0x01;
            byte NumberOfHits_Max { get; set; } = 0x01;
            byte DamageType { get; set; } = Convert.ToByte(HPEffect.DealDamage);
            ushort BaseDamage { get; set; } = 0x0F;
            byte DepleteOrRestoreSP { get; set; } = Convert.ToByte(SPEffect.DepleteSP);
            byte Unknown_6 { get; set; } = 0x00;
            ushort SPAmount { get; set; } = 0;
            byte ApplyOrCureEffect { get; set; } = Convert.ToByte(ApplyCureEffect.NoEffect); // Ignore resistance works 100%
                                                                // for Physical. Magic including Light, Dark, Almighty can only
                                                                // Semi Pierce (NULL, DRAIN, REPEL can't be pierced)
            byte EffectChance { get; set; } = 0x32;
            byte Unknown_7 { get; set; } = 0x00;
            EffectList1 EffectList_1 = new EffectList1();
            EffectList2 EffectList_2 = new EffectList2();
            EffectList3 EffectList_3 = new EffectList3();
            EffectList4 EffectList_4 = new EffectList4();
            EffectList5 EffectList_5 = new EffectList5();
            EffectList6 EffectList_6 = new EffectList6();
            BuffsDebuffs BuffsAndDebuffs = new BuffsDebuffs();
            byte UnknownR_3 { get; set; } = 0;
            byte RESERVE_2A { get; set; } = 0x00;
            byte Other_Buffs = Convert.ToByte(OtherBuffs.None);
            byte Extra_Effects = Convert.ToByte(ExtraEffects.NoEffect6); // Ignore resistance works 100% for Physical.
                                                                         // Magic including Light, Dark, Almighty can only Semi Pierce
                                                                         // (NULL, DRAIN, REPEL can't be pierced).
            byte CritChance { get; set; } = 0x00; // Only works for Physical or Gun skills
            byte UnknownForItem { get; set; } = 0x00; // Not sure what this does since it has 20 value on Firecracker, Magatama item
            byte Unknown_8 { get; set; } = 0x00;

        }

        enum ExtraEffects
        {
            NoEffect6 = 0,
            OnlyHitTargetsInflictedWithFear = 1, // used by Ghastly Wail
            EscapeBattle = 2,
            BonusDamageFoeKnockdown = 3,
            ThrowAwayMoney = 6,
            AffectMaleAlliesonly = 7,
            AffectFemaleAlliesonly = 8,
            BLOCKskillifguardbutkillifdizzyUNTESTED = 9,
            DizzyDown1moreGuaranteedUNTESTED = 10,
            randomresistancechangesUNTESTED = 11,
            Allfoesweaklightanddarkto1UNTESTED = 12,
            AlwaysKills = 13, // used for 9999 damage Megidolaon (603)
            killallfoeswithailments = 14,
            BigBangBurgerDocumentVisualUNTESTED = 15, // used by Shadow Okumura's Sacrifice Order
            PowerUpIfSurrounded = 16,
            BatonPassDamageUp = 17,
            ignoreresistance = 18,
            TargetedChanceUp = 19, // increases chance of being targeted by enemies
            TargetedChanceWayUp = 20, // greatly increases chance of being targeted by enemies
            IfHungerAilmentExistsHealAndCureInstead = 21, // used for Big Bang Challenge; needs testing with other ailments
            CasterAttackWayDownNonNegatable = 22, // used for Beast Weaver
            LessChanceTobeTargeted = 23,
        }

        enum OtherBuffs
        {
            None = 0,
            AllBarriersThatDrain = 2
        }

        class BuffsDebuffs
        {
            bool AccuracyDown { get; set; } = false;
            bool AccuracyUp { get; set; } = false;
            bool DefenseDown { get; set; } = false;
            bool DefenseUp { get; set; } = false;
            bool EvasionDown { get; set; } = false;
            bool EvasionUp { get; set; } = false;
            bool AttackDown { get; set; } = false;
            bool AttackUp { get; set; } = false;
            bool Wrath { get; set; } = false;
        }

        class EffectList1
        {
            bool Counter { get; set; } = false; // maybe?
            bool Mouse { get; set; } = false; // only affects party
            bool Gluttony { get; set; } = false; // maybe?
            bool KnockDown { get; set; } = false;
            bool Unconscious { get; set; } = false;
            bool WeakToAllElements { get; set; } = false;
            bool Jealousy { get; set; } = false;
        }

        class EffectList2
        {
            bool Lust { get; set; } = false; // Lust, Rage, Berserk can be combined into 1 single ailment
            bool Panic { get; set; } = false; // Will cause Shadows to run away
            bool Berserk { get; set; } = false; // Visual effect only. Also, Lust, Rage, Berserk can be combined into 1 single ailment
            bool Desparation { get; set; } = false;  // Attack up, Defense down; not affected by other buffs/debuffs
            bool Brainwash { get; set; } = false; // Attack up, Defense down; not affected by other buffs/debuffs
            bool Despair { get; set; } = false; // Sleep,Hunger,Forget,Fear,Confuse,Weak,Despair can be combined into 1 single ailment
            bool Rage { get; set; } = false; // Lust, Rage, Berserk can be combined into 1 single ailment
            bool Sleep { get; set; } = false; // Sleep,Hunger,Forget,Fear,Confuse,Weak,Despair can be combined into 1 single ailment
        }

        class EffectList3
        {
            bool Hunger { get; set; } = false; // only affects party
            bool Forget { get; set; } = false;
            bool Fear { get; set; } = false;
            bool Confuse { get; set; } = false;
            bool Dizzy { get; set; } = false;
            bool Shock { get; set; } = false;
            bool Freeze { get; set; } = false;
            bool Burn { get; set; } = false;
        }
        class EffectList4
        {
            bool CoverPsy { get; set; } = false; // Changes innate Psy weakness to neutral
            bool CoverNuke { get; set; } = false; // Changes innate Nuke weakness to neutral
            bool CoverWind { get; set; } = false; // Changes innate Wind weakness to neutral
            bool CoverElec { get; set; } = false; // Changes innate Electric weakness to neutral
            bool CoverIce { get; set; } = false; // Changes innate Ice weakness to neutral
            bool CoverFire { get; set; } = false; // Changes innate Fire weakness to neutral
            bool InstakillShield { get; set; } = false; // Blocks one instakill attack
            bool BreakMagicShield { get; set; } = false; // Breaks magic-reflecting shields like Makarakarn
        }

        class EffectList5
        {
            bool BreakPhysicalShield { get; set; } = false; // Breaks physical-reflecting shields like Tetrakarn
            bool AilmentSusceptibility { get; set; } = false; // increases the likelihood of recieving effects from Effect Lists 2 and 3
            bool NegatePsyResist { get; set; } = false; // Changes innate Psy resistance to neutral; does not override Cover Weakness effects from Effect List 4
            bool NegateNukeResist { get; set; } = false; // Changes innate Nuke resistance to neutral; does not override Cover Weakness effects from Effect List 4
            bool NegateWindResist { get; set; } = false; // Changes innate Wind resistance to neutral; does not override Cover Weakness effects from Effect List 4
            bool NegateElecResist { get; set; } = false; // Changes innate Electric resistance to neutral; does not override Cover Weakness effects from Effect List 4
            bool NegateIceResist { get; set; } = false; // Changes innate Ice resistance to neutral; does not override Cover Weakness effects from Effect List 4
            bool NegateFireResist { get; set; } = false;  // Changes innate Fire resistance to neutral; does not override Cover Weakness effects from Effect List 4

        }
        class EffectList6
        {
            bool MagicShield { get; set; } = false; // Reflects the next magic attack received
            bool PhysicalShield { get; set; } = false; //  Reflects the next physical attack received
            bool CritWayUp { get; set; } = false; // Critical Chance Way Up
            bool CritUp { get; set; } = false; 
            bool RemoveDebuffs { get; set; } = false; // Removes stat-lowering debuffs from the Buff/Debuff List
            bool RemoveBuffs { get; set; } = false; // Removes stat-raising buffs from the Buff/Debuff List
            bool Concentrate { get; set; } = false; // Next Magic-based attack deals 2.5x damage
            bool Charge { get; set; } = false; // Next Strength-based attack deals 2.5x damage
        }

        enum ApplyCureEffect
        {
            NoEffect = 0,
            ApplySingleorMultipleEffect = 1,
            CureEffect = 2,
            ApplyMultipleEffects = 3
        }

        enum SPEffect
        {
            NoSPEffect = 0,
            DepleteFixedSP = 4,
            RestoreSP = 5,
            DepleteSP = 8,
            RestorePercentMaxSPUNKNOWN = 9, // this one does not reflect the exact percentage value
            DepletePercentMaxSP = 10,
            RestorePercentMaxSP = 11,
            DrainSPbasedonMagic = 12,
            DrainFixedSP = 13,
        }

        enum HPEffect
        {
            NoDamageOrHealing = 0,
            DealDamage = 1, // deal damage, affected by damage stat
            RestoreHealth = 2, // restore health, varies based on stats
            SetHP = 3, // set HP to a specified value
            DealExactDamage = 4, // deals EXACTLY the amount of damage specified, regardless of stats
            RestoreExactHealth = 5, // restores EXACTLY the amount of health specified, regardless of stats
            Unknown_Damage6 = 6, // seems to be the same as DealDamage? Needs more testing
            Unknown_Healing7 = 7, // seems to be the same as RestoreHealth? Needs more testing
            DamagePercentCurrentHP = 8, // deal a percent of current HP as damage
            RestorePercentCurrentHP = 9, // restore a percent of current HP as health
            DamagePercentMaxHP = 10, // deal a percent of max HP as damage
            RestorePercentMaxHP = 11, // restore a percent of max HP as health
            DrainDamage = 12, // deals damage, affected by damage stat, and restores equal HP to the user
            DrainExactDamage = 13, // deals EXACTLY the amount of damage specified and restores equal HP to the user
            Unknown_Damage14 = 14, // seems to be the same as DealDamage? Needs more testing
            RestoreHealthWhiffChance = 15, // Has a chance to whiff, healing for minimal HP instead
            DamageBasedOnHealthyPartyMembers = 16 // used for All-Out Attacks
        }

        enum TargetRestrictions
        {
            NoAdditionalRestrictions = 0,
            RandomTwoFromSelection = 1, // used by Diffraction Arrow, Distortion Wave
            Unknown_DreadfulScreamRelated = 2, // used by Cognitive Wakaba's Dreadful Scream
            Unknown_WingBlastRelated = 4, // used by Cognitive Wakaba's Wing Blast
            SelfOnly = 16,
            SelfNotAllowed = 32,
            UnconsciousOnly = 64, // used for revival skills
        }

        enum ValidTargets
        {
            NeitherEnemiesNorAllies = 0,
            AlliesNotEnemies = 1,
            EnemiesNotAllies = 2,
            BothAlliesAndEnemies = 3,
        }
        enum TargetKind
        {
            SingleTarget = 0,
            MultiTarget = 1,
            MultiTargetExceptSelf = 2, // might be redundant with Multi + SelfNotAllowed
            Unknown_PlumeOfDuskRelated = 3, // used by the unused Plume of Dusk item ability - description reads "When MC is KO'd, fully recover to all allies"
        }

        enum CostType
        {
            NoCost = 0,
            HPCost = 1,
            SPCost = 2,
        }

        enum DamageStat
        {
            NoApplicableStat = 0,
            StrengthStat = 1,
            MagicStat = 2,
        }

        enum AreaType
        {
            Unusable = 0,
            UsableInField = 1,
            UsableInBattle = 2,
            UsableInFieldAndBattle = 3
        };

        enum CasterEffect1
        {
            NoCasterEffect1 = 0,
            UnknownCasterEffect_SpecialMoveRelated = 1, // used by All-Out Attacks, Navigator skills, and other unique skills. Sometimes plays a mini-cutscene?
            ModifiedByEquippedGun = 2,
            ReduceOwnHPTo1 = 4,
            UnknownCasterEffect1_StealInfoRelated = 32, // used by Steal Info
        }

        enum CasterEffect2
        {
            NoCasterEffect2 = 0,
            KOSelf = 1,
            MeleeContact = 2, // needs to be tested
            SummonAlly_CRASHES_ON_USE = 4, // summons an ally in enemy encounters - DO NOT USE LIKE A NORMAL SKILL, THE GAME WILL CRASH
            UnknownCasterEffect_SupportRelated = 8, // used by healing and support skills
	        KillYourselfAfterCasting = 9, // it kills yourself when you use the skill
	        UsePercentageSPCost = 16, // used to make the sp cost by percentage usage
            UnknownCasterEffect_RecarmdraRelated = 24, // used by Recarmdra
	        SaeRouletteSkill = 32,
            UnknownCasterEffect_TrafuriRelated = 40, // used by Trafuri
            UnknownCasterEffect_FollowUpRelated = 66, // used by Follow-Up Attacks
            UnknownCasterEffect_RouletteRelated1 = 128, // used by Roulette: HP and Roulette: SP. Suspect it has to do with being able to be reversed.
	        UnknownForMaruki1 = 130,
            UnknownCasterEffect_RouletteRelated2 = 136, // used by Roulette: Aid.
            CRASHES_OFTEN_UnknownCasterEffect2_160 = 160, // used by Barrage and Dispose Item - DO NOT USE WITHOUT APPLYING THE "ThrowAwayMoney" EXTRA EFFECT, THE GAME WILL CRASH
        }

        enum SkillCondition
        {
            UnknownShowtimeRelated = 1,
            StopTheContinuousUsageForExplosionSkill = 2, // if used on active skill, it will crash 100%. Disable this. This is for the explosion only
            UnknownForMaruki = 4,
            UnknownForItemSegamiRice = 8,
            UsableOnlyinAmbush = 16,
        }

        internal class ElementData
        {
            byte ElementType { get; set; } = Convert.ToByte(ElementalType.Physical);
            byte ActiveOrPassive { get; set; } = Convert.ToByte(PassiveActive.ActiveSkill);
            bool Inheritable { get; set; } = false;
            byte UnknownR_1 { get; set; } = 0x00;
            byte UnknownR_2 { get; set; } = 0x00;
            byte UnknownR_3 { get; set; } = 0x00;
            byte UnknownR_4 { get; set; } = 0x00;
            byte[] RedundantBitfield = new byte[8];
        }

        enum PassiveActive
        {
            ActiveSkill = 0,
            PassiveSkill = 1, // MUST be enabled for passive skills to function properly
            NULL_Skill = 255
        }
    }


}