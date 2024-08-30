using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static P5RBattleEditor.MainForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public enum ElementalAffinityNames
        {
            Physical,
            Gun,
            Fire,
            Ice,
            Electric,
            Wind,
            Psy,
            Nuke,
            Bless,
            Curse,
            Almighty,
            Dizzy,
            Confuse,
            Fear,
            Forget,
            Hunger,
            Sleep,
            Rage,
            Despair,
            Brainwash
        }

        public enum AffinityAttributeNames
        {
            DoubleAilmentChance, // Used on Fire/Ice/Elec affinity to double the chance that an incoming attack
                                 // inflicts the corresponding ailment (Burn/Freeze/Shock).
            GuaranteeAilment, // Incoming attacks with an ailment chance always inflict the ailment.
            AilmentImmune, // Incoming attacks never inflict ailments (including insta-kill).
                           // Overrides Guarantee Ailment. Does NOT prevent Critical hits.
            Resist, // Displays Resist text and halves damage (by default) when hit.
                    // (However, If Mutliplier field is specified (non-zero),
                    // it replaces the default 0.5x multiplier.)
            Weak, // Damage x 1.25 (by default) and knockdown. (However, if Multiplier field is specified (non-zero),
                  // it replaces the default 1.25x mutliplier.)
            Repel,
            Drain,
            Block
        }

        public enum ElementalType
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

        public enum UnitFlagNames
        {
            Bit0,
            Bit1,
            Bit2,
            Bit3,
            Bit4,
            Bit5,
            Bit6,
            Bit7
        }

        public enum UnitFlag2Names
        {
            Bit8,
            Bit9,
            Bit10,
            Bit11,
            Bit12,
            Bit13,
            Bit14,
            Bit15
        }

        public enum UnitFlag3Names
        {
            NoBeggingShadows, // shadows will never beg for their life
            HiddenStatus, // status can be hidden (similar to boss)
            Bit18,
            Bit19,
            GuaranteePersonaMask, // makes enemy appear to have item drop, ends battle when obtained
            NoNegotiation, // enemy will be unable to negotiate
            Bit22,
            Bit23
        }

        public enum UnitFlag4Names
        {
            Bit24,
            Bit25,
            Bit26,
            Bit27,
            Bit28,
            HiddenStatus_Boss, // status can be hidden (used for bosses)
            InfiniteSP, // shadow will be able to use any skill regardless of SP cost
            Bit31
        }
    }
}