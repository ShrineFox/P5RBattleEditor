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
        public class TraitData
        {
            public ushort Effect { get; set; } = 0; // Selects the effect of the trait from a
                                                    // preprogrammed list.
            public ushort Field2 = 0;
            public int EffectRate { get; set; } = 100; // Percent chance that the trait triggers.
            public int SubTrait { get; set; } = 0; // Adds effect of trait with given ID to
                                                   // this trait. Requires 'Use Sub Trait'=1.
            public float EffectSize { get; set; } = 1; // Strength of effect. Usually a
                            // multiplier for damage, healing, skill costs, ailment chance, etc.
            public int[] SubstituteTraits { get; set; } = new int[10]; // Alternate inheritable traits 
                                // during fusion if this one is a duplicate or a Treasure Demon trait.
            public TraitFlags Flags { get; set; } = new TraitFlags();

        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct TraitFlags
        {
            public uint UnknownBitfield; // 29 bits
            public bool UseSubTrait; // 1 bit
            public bool IsTreasure;   // 1 bit
            public bool IsUnique;      // 1 bit


            public uint Pack()
            {
                uint packedValue = 0;
                packedValue |= UnknownBitfield & 0xFFFFF; // 29 bits
                packedValue |= (uint)(UseSubTrait ? 1 : 0) << 29;
                packedValue |= (uint)(IsTreasure ? 1 : 0) << 30;
                packedValue |= (uint)(IsUnique ? 1 : 0) << 31;
                return packedValue;
            }

            public void Unpack(uint packedValue)
            {
                UnknownBitfield = packedValue & 0xFFFFF; // 29 bits
                UseSubTrait = (packedValue & (1 << 29)) != 0;
                IsTreasure = (packedValue & (1 << 30)) != 0;
                IsUnique = (packedValue & (1 << 31)) != 0;
            }
        }

        public TraitFlags ReadTraitFlags(EndianBinaryReader reader)
        {
            uint packedValue = reader.ReadUInt32();
            TraitFlags status = new TraitFlags();
            status.Unpack(packedValue);
            return status;
        }

        public void WriteTraitFlags(EndianBinaryWriter writer, TraitFlags status)
        {
            uint packedValue = status.Pack();
            writer.Write(packedValue);
        }
    }
}
