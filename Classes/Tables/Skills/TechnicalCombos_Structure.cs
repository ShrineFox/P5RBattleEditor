using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public class TechnicalCombo
        {
            // If the target has any of these ailments, the affinities in the
            // TechnicalAffinities fields will deal Technical damage.
            public AilmentStatus ApplicableAilments { get; set; } = new AilmentStatus();
            // If set to 1, the TechnicalAffinities array is ignored; instead,
            // ALL damaging skills inflict Technical damage agaisnt these ailments.
            public bool AllAffinitiesAreTechnical { get; set; } = false; // uint
            // Skills of these affinities are Technical against foes with the above ailments.
            public int[] TechnicalAffinities { get; set; } = new int[5];
            // Technicals of this type will multiply damage by this amount,
            // plus up to 0.3 for party's Techncial Rank.
            public uint DamageMultiplier { get; set; } = 2;
            public int UnknownR { get; set; } = 0;
            // If set to Yes, this entry of the map only applies if you've read the book
            // "Knowing the Heart" for extra Tech combos.
            public bool RequiresKnowTheHeart { get; set; } = false; // uint, yes = 0x3000013d
        }

        enum TechnicalSkillAffinityNames // int
        {
            TechAffinity_BLANK = -1,
            TechAffinity_Physical = 0,
            TechAffinity_Gun = 1,
            TechAffinity_Fire = 2,
            TechAffinity_Ice = 3,
            TechAffinity_Electric = 4,
            TechAffinity_Wind = 5,
            TechAffinity_Psy = 6,
            TechAffinity_Nuke = 7,
            TechAffinity_Bless = 8,
            TechAffinity_Curse = 9,
            TechAffinity_Almighty = 10
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct AilmentStatus
        {
            public uint OtherAilments; // Bitfield for the various 'special' ailments
                                       // that players don't normally inflict
            public bool AilmentStatus_11_Brainwash; // 1 bit
            public bool AilmentStatus_10_Despair;   // 1 bit
            public bool AilmentStatus_09_Rage;      // 1 bit
            public bool AilmentStatus_08_Sleep;     // 1 bit
            public bool AilmentStatus_07_Hunger;    // 1 bit
            public bool AilmentStatus_06_Forget;    // 1 bit
            public bool AilmentStatus_05_Fear;      // 1 bit
            public bool AilmentStatus_04_Confuse;   // 1 bit
            public bool AilmentStatus_03_Dizzy;     // 1 bit
            public bool AilmentStatus_02_Shock;     // 1 bit
            public bool AilmentStatus_01_Freeze;    // 1 bit
            public bool AilmentStatus_00_Burn;      // 1 bit


            public uint Pack()
            {
                uint packedValue = 0;
                packedValue |= OtherAilments & 0xFFFFF; // 20 bits
                packedValue |= (uint)(AilmentStatus_11_Brainwash ? 1 : 0) << 20;
                packedValue |= (uint)(AilmentStatus_10_Despair ? 1 : 0) << 21;
                packedValue |= (uint)(AilmentStatus_09_Rage ? 1 : 0) << 22;
                packedValue |= (uint)(AilmentStatus_08_Sleep ? 1 : 0) << 23;
                packedValue |= (uint)(AilmentStatus_07_Hunger ? 1 : 0) << 24;
                packedValue |= (uint)(AilmentStatus_06_Forget ? 1 : 0) << 25;
                packedValue |= (uint)(AilmentStatus_05_Fear ? 1 : 0) << 26;
                packedValue |= (uint)(AilmentStatus_04_Confuse ? 1 : 0) << 27;
                packedValue |= (uint)(AilmentStatus_03_Dizzy ? 1 : 0) << 28;
                packedValue |= (uint)(AilmentStatus_02_Shock ? 1 : 0) << 29;
                packedValue |= (uint)(AilmentStatus_01_Freeze ? 1 : 0) << 30;
                packedValue |= (uint)(AilmentStatus_00_Burn ? 1 : 0) << 31;
                return packedValue;
            }

            public void Unpack(uint packedValue)
            {
                OtherAilments = packedValue & 0xFFFFF; // 20 bits
                AilmentStatus_11_Brainwash = (packedValue & (1 << 20)) != 0;
                AilmentStatus_10_Despair = (packedValue & (1 << 21)) != 0;
                AilmentStatus_09_Rage = (packedValue & (1 << 22)) != 0;
                AilmentStatus_08_Sleep = (packedValue & (1 << 23)) != 0;
                AilmentStatus_07_Hunger = (packedValue & (1 << 24)) != 0;
                AilmentStatus_06_Forget = (packedValue & (1 << 25)) != 0;
                AilmentStatus_05_Fear = (packedValue & (1 << 26)) != 0;
                AilmentStatus_04_Confuse = (packedValue & (1 << 27)) != 0;
                AilmentStatus_03_Dizzy = (packedValue & (1 << 28)) != 0;
                AilmentStatus_02_Shock = (packedValue & (1 << 29)) != 0;
                AilmentStatus_01_Freeze = (packedValue & (1 << 30)) != 0;
                AilmentStatus_00_Burn = (packedValue & (1 << 31)) != 0;
            }
        }

        public AilmentStatus ReadAilmentStatus(EndianBinaryReader reader)
        {
            uint packedValue = reader.ReadUInt32();
            AilmentStatus status = new AilmentStatus();
            status.Unpack(packedValue);
            return status;
        }

        public void WriteAilmentStatus(EndianBinaryWriter writer, AilmentStatus status)
        {
            uint packedValue = status.Pack();
            writer.Write(packedValue);
        }
    }
}
