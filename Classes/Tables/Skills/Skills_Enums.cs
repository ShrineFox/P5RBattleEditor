using MetroSet_UI.Forms;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
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

        enum BuffsDebuffsNames
        {
            AccuracyDown,
            AccuracyUp,
            DefenseDown,
            DefenseUp,
            EvasionDown,
            EvasionUp,
            AttackDown,
            AttackUp,
        }

        enum EffectList1Names
        {
            Counter, // maybe?
            Mouse, // only affects party
            Gluttony, // maybe?
            KnockDown,
            Unconscious,
            WeakToAllElements,
            Jealousy,
            Wrath
        }

        enum EffectList2Names
        {
            Lust, // Lust, Rage, Berserk can be combined into 1 single ailment
            Panic, // Will cause Shadows to run away
            Berserk, // Visual effect only. Also, Lust, Rage, Berserk can be combined into 1 single ailment
            Desparation,  // Attack up, Defense down; not affected by other buffs/debuffs
            Brainwash, // Attack up, Defense down; not affected by other buffs/debuffs
            Despair, // Sleep,Hunger,Forget,Fear,Confuse,Weak,Despair can be combined into 1 single ailment
            Rage, // Lust, Rage, Berserk can be combined into 1 single ailment
            Sleep, // Sleep,Hunger,Forget,Fear,Confuse,Weak,Despair can be combined into 1 single ailment
        }

        enum EffectList3Names
        {
            Hunger, // only affects party
            Forget,
            Fear,
            Confuse,
            Dizzy,
            Shock,
            Freeze,
            Burn,
        }

        enum EffectList4Names {
            CoverPsy, // Changes innate Psy weakness to neutral
            CoverNuke, // Changes innate Nuke weakness to neutral
            CoverWind, // Changes innate Wind weakness to neutral
            CoverElec, // Changes innate Electric weakness to neutral
            CoverIce, // Changes innate Ice weakness to neutral
            CoverFire, // Changes innate Fire weakness to neutral
            InstakillShield, // Blocks one instakill attack
            BreakMagicShield, // Breaks magic-reflecting shields like Makarakarn
        }

        enum EffectList5Names
        {
            BreakPhysicalShield, // Breaks physical-reflecting shields like Tetrakarn
            AilmentSusceptibility, // increases the likelihood of recieving effects from Effect Lists 2 and 3
            NegatePsyResist, // Changes innate Psy resistance to neutral; does not override Cover Weakness effects from Effect List 4
            NegateNukeResist, // Changes innate Nuke resistance to neutral; does not override Cover Weakness effects from Effect List 4
            NegateWindResist, // Changes innate Wind resistance to neutral; does not override Cover Weakness effects from Effect List 4
            NegateElecResist, // Changes innate Electric resistance to neutral; does not override Cover Weakness effects from Effect List 4
            NegateIceResist, // Changes innate Ice resistance to neutral; does not override Cover Weakness effects from Effect List 4
            NegateFireResist,  // Changes innate Fire resistance to neutral; does not override Cover Weakness effects from Effect List 4
        }
        enum EffectList6Names
        {
            MagicShield, // Reflects the next magic attack received
            PhysicalShield, //  Reflects the next physical attack received
            CritWayUp, // Critical Chance Way Up
            CritUp,
            RemoveDebuffs, // Removes stat-lowering debuffs from the Buff/Debuff List
            RemoveBuffs, // Removes stat-raising buffs from the Buff/Debuff List
            Concentrate, // Next Magic-based attack deals 2.5x damage
            Charge, // Next Strength-based attack deals 2.5x damage
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



        enum PassiveActive
        {
            ActiveSkill = 0,
            PassiveSkill = 1, // MUST be enabled for passive skills to function properly
            NULL_Skill = 255
        }
    }


}