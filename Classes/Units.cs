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
        private List<Unit> ReadP5RUnitTbl(string path)
        {
            List<Unit> units = new List<Unit>();

            return units;
        }

        internal class Unit
        {
            EnemyStats Segment0 { get; set; } = new EnemyStats(); // 783
            ElementalAffinities Segment1 { get; set; } = new ElementalAffinities(); // 783
            ElementalAffinities Segment2 { get; set; } = new ElementalAffinities(); // 464
            VoiceData Segment3 { get; set; } = new VoiceData(); // 783
            List<VisualData> Segment4 { get; set; } = new List<VisualData>(); // 783
            // Segment5: unknown byte array
        }

        internal class VisualData
        {
            ushort PersonaID { get; set; } = 0;
            ushort ModelID { get; set; } = 0;
            ushort UnknownR { get; set; } = 0;
        }

        internal class VoiceData
        {
            byte VoiceID { get; set; } = 0x00; // Subtract 1 from the id i.e. 9 to load voicepack 10
            byte TALK_PERSON { get; set; } = 0x00;
            byte VoiceAcbValue { get; set; } = 0x00;
            byte Padding = 0x00;
            ushort TALK_MONEY_MIN { get; set; } = 0;
            ushort TALK_MONEY_MAX { get; set; } = 0;
            ItemDropList TALK_ITEM { get; set; } = new ItemDropList();
            ItemDropList TALK_ITEM_RARE { get; set; } = new ItemDropList();

        }

        internal class ElementalAffinities
        {
            Affinity Physical { get; set; } = new Affinity();
            Affinity Gun { get; set; } = new Affinity();
            Affinity Fire { get; set; } = new Affinity();
            Affinity Ice { get; set; } = new Affinity();
            Affinity Electric { get; set; } = new Affinity();
            Affinity Wind { get; set; } = new Affinity();
            Affinity Psy { get; set; } = new Affinity();
            Affinity Nuke { get; set; } = new Affinity();
            Affinity Bless { get; set; } = new Affinity();
            Affinity Curse { get; set; } = new Affinity();
            Affinity Almighty { get; set; } = new Affinity();
            Affinity Dizzy { get; set; } = new Affinity();
            Affinity Confuse { get; set; } = new Affinity();
            Affinity Fear { get; set; } = new Affinity();
            Affinity Forget { get; set; } = new Affinity();
            Affinity Hunger { get; set; } = new Affinity();
            Affinity Sleep { get; set; } = new Affinity();
            Affinity Rage { get; set; } = new Affinity();
            Affinity Despair { get; set; } = new Affinity();
            Affinity Brainwash { get; set; } = new Affinity();
        }

        internal class Affinity
        {
            bool DoubleAilmentChance = false; // Used on Fire/Ice/Elec affinity to double the chance that an incoming attack
                                              // inflicts the corresponding ailment (Burn/Freeze/Shock).
            bool GuaranteeAilment = false; // Incoming attacks with an ailment chance always inflict the ailment.
            bool AilmentImmune = false; // Incoming attacks never inflict ailments (including insta-kill).
                                        // Overrides Guarantee Ailment. Does NOT prevent Critical hits.
            bool Resist = false; // Displays Resist text and halves damage (by default) when hit.
                                 // (However, If Mutliplier field is specified (non-zero),
                                 // it replaces the default 0.5x multiplier.)
            bool Weak = false; // Damage x 1.25 (by default) and knockdown. (However, if Multiplier field is specified (non-zero),
                               // it replaces the default 1.25x mutliplier.)
            bool Repel = false;
            bool Drain = false;
            bool Block = false;

            // Multiplies damage & ailment chance. 20 is Neutral since 20 x 5% = 100% of normal dmg &
            // ail. chance. 80 x 5% = 400% = 4x multiplier. 0 is ignored (does not nullify attack).
            byte Multiplier = 0x00;
        }

        internal class EnemyStats
        {
            UnitFlags Flags { get; set; } = new UnitFlags();
            byte Arcana { get; set; } = Convert.ToByte(ArcanaName.Fool);
            byte RESERVE = 0x00;
            ushort Level { get; set; } = 0;
            uint HP { get; set; } = 0;
            uint SP { get; set; } = 0;
            BattleStats Stats { get; set; } = new BattleStats();
            byte RESERVE2 = 0x00;
            BattleSkills Skills { get; set; } = new BattleSkills();
            ushort EXPReward { get; set; } = 0;
            ushort MoneyReward { get; set; } = 0;
            ItemDropList ItemDrops { get; set; } = new ItemDropList();
            ItemDrop EventItemDrop { get; set; } = new ItemDrop();
            AttackData AttackAttributes { get; set; } = new AttackData();
        }

        internal class AttackData
        {
            byte AttackType { get; set; } = Convert.ToByte(ElementalType.Physical);
            byte AttackAccuracy { get; set; } = 0x00;
            ushort AttackDamage { get; set; } = 0;
        }

        enum ElementalType
        {
            Physical = 0,
            Gun = 1,
            Fire = 2,
            Ice = 3,
            Electric = 4,
            Wind = 5,
            Psy = 6,
            Nuke = 7,
            Bless = 8,
            Curse = 9,
            Almighty = 10,
            Dizzy = 11,
            Confuse = 12,
            Fear = 13,
            Forget = 14,
            Hunger = 15,
            Sleep = 16,
            Rage = 17,
            Despair = 18,
            Brainwash = 19,
            Healing = 20,
            Support = 21,
            Passive = 255
        }

        internal class ItemDropList
        {
            ItemDrop Drop_1 { get; set; } = new ItemDrop();
            ItemDrop Drop_2 { get; set; } = new ItemDrop();
            ItemDrop Drop_3 { get; set; } = new ItemDrop();
            ItemDrop Drop_4 { get; set; } = new ItemDrop();
        }

        internal class ItemDrop
        {
            ushort EventID = 0;
            ushort ItemID = 0;
            ushort Probability = 0;
        }

        internal class BattleSkills
        {
            ushort Skill1 { get; set; } = 0;
            ushort Skill2 { get; set; } = 0;
            ushort Skill3 { get; set; } = 0;
            ushort Skill4 { get; set; } = 0;
            ushort Skill5 { get; set; } = 0;
            ushort Skill6 { get; set; } = 0;
            ushort Skill7 { get; set; } = 0;
            ushort Skill8 { get; set; } = 0;

        }

        internal class BattleStats
        {
            byte Strength { get; set; } = 0x00;
            byte Magic { get; set; } = 0x00;
            byte Endurance { get; set; } = 0x00;
            byte Agility { get; set; } = 0x00;
            byte Luck { get; set; } = 0x00;
        }

        enum ArcanaName
        {
            Fool = 1,
            Magician = 2,
            HighPriestess = 3,
            Empress = 4,
            Emperor = 5,
            Hierophant = 6,
            Lovers = 7,
            Chariot = 8,
            Justice = 9,
            Hermit = 10,
            Fortune = 11,
            Strength = 12,
            HangedMan = 13,
            Death = 14,
            Temperance = 15,
            Devil = 16,
            Tower = 17,
            Star = 18,
            Moon = 19,
            Sun = 20,
            Judgement = 21,
            Aeon = 22,
            Other = 23,
            World = 24,
            Faith = 29,
            Councillor = 30,
        }

        internal class UnitFlags
        {
            bool bit0 = false;
            bool bit1 = false;
            bool bit2 = false;
            bool bit3 = false;
            bool bit4 = false;
            bool bit5 = false;
            bool bit6 = false;
            bool bit7 = false;
            bool bit8 = false;
            bool bit9 = false;
            bool bit10 = false;
            bool bit11 = false;
            bool bit12 = false;
            bool bit13 = false;
            bool bit14 = false;
            bool bit15 = false;
            bool NoBeggingShadows = false; // shadows will never beg for their life
            bool HiddenStatus = false; // status can be hidden (similar to boss)
            bool bit18 = false;
            bool bit19 = false; 
            bool GuaranteePersonaMask = false; // makes enemy appear to have item drop, ends battle when obtained
            bool NoNegotiation = false; // enemy will be unable to negotiate
            bool bit22 = false;
            bool bit23 = false; 
            bool bit24 = false;
            bool bit25 = false;
            bool bit26 = false;
            bool bit27 = false;
            bool bit28 = false;
            bool HiddenStatus_Boss = false; // status can be hidden (used for bosses)
            bool InfiniteSP = false; // shadow will be able to use any skill regardless of SP cost
            bool bit31 = false; 
        }
    }


}
