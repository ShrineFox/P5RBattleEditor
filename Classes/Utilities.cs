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
using static P5RBattleEditor.P5RBattleEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        public static bool[] ConvertByteToBools(byte b)
        {
            return new bool[]
            {
                (b & 0b00000001) != 0,
                (b & 0b00000010) != 0,
                (b & 0b00000100) != 0,
                (b & 0b00001000) != 0,
                (b & 0b00010000) != 0,
                (b & 0b00100000) != 0,
                (b & 0b01000000) != 0,
                (b & 0b10000000) != 0
            };
        }

        byte ConvertBoolsToByte(bool[] bools)
        {
            byte result = 0x00;
            result |= (byte)((bools[0] ? 1 : 0) << 0);
            result |= (byte)((bools[1] ? 1 : 0) << 1);
            result |= (byte)((bools[2] ? 1 : 0) << 2);
            result |= (byte)((bools[3] ? 1 : 0) << 3);
            result |= (byte)((bools[4] ? 1 : 0) << 4);
            result |= (byte)((bools[5] ? 1 : 0) << 5);
            result |= (byte)((bools[6] ? 1 : 0) << 6);
            result |= (byte)((bools[7] ? 1 : 0) << 7);
            return result;
        }

        public static int Get16ByteAlignmentPadding(EndianBinaryReader reader)
        {
            long currentPosition = reader.BaseStream.Position;
            int paddingNeeded = (int)(16 - (currentPosition % 16)) % 16;

            return paddingNeeded;
        }

        public static void Add16ByteAlignmentPadding(EndianBinaryWriter writer)
        {
            long currentPosition = writer.BaseStream.Position;
            int paddingNeeded = (int)(16 - (currentPosition % 16)) % 16;

            if (paddingNeeded > 0)
            {
                writer.Write(new byte[paddingNeeded]);
            }
        }

        public struct Bitfield
        {
            public bool Bit0;
            public bool Bit1;

            public byte Pack()
            {
                byte packedValue = 0;
                packedValue |= (byte)(Bit0 ? 1 : 0);
                packedValue |= (byte)((Bit1 ? 1 : 0) << 1);
                return packedValue;
            }

            public void Unpack(byte packedValue)
            {
                Bit0 = (packedValue & 1) != 0;
                Bit1 = (packedValue & (1 << 1)) != 0;
            }
        }

        public Bitfield ReadBitfield(EndianBinaryReader reader)
        {
            byte packedValue = reader.ReadByte();
            Bitfield bitfield = new Bitfield();
            bitfield.Unpack(packedValue);
            return bitfield;
        }

        public void WriteBitfield(EndianBinaryWriter writer, Bitfield bitfield)
        {
            byte packedValue = bitfield.Pack();
            writer.Write(packedValue);
        }

        public struct UnionBitfield
        {
            public short Field1; // Lower 8 bits (0-7)
            public short Field2; // Upper 8 bits (8-15)

            public ushort Pack()
            {
                ushort packedValue = 0;
                packedValue |= (ushort)(Field1 & 0xFF); // Mask to ensure only lower 8 bits are used
                packedValue |= (ushort)((Field2 & 0xFF) << 8); // Shift Field2 to the upper 8 bits
                return packedValue;
            }

            public void Unpack(ushort packedValue)
            {
                Field1 = (short)(packedValue & 0xFF); // Extract lower 8 bits
                Field2 = (short)((packedValue >> 8) & 0xFF); // Extract upper 8 bits
            }
        }

        public UnionBitfield ReadUnionBitfield(EndianBinaryReader reader)
        {
            ushort packedValue = reader.ReadUInt16();
            UnionBitfield bitfield = new UnionBitfield();
            bitfield.Unpack(packedValue);
            return bitfield;
        }

        public void WriteUnionBitfield(EndianBinaryWriter writer, UnionBitfield bitfield)
        {
            ushort packedValue = bitfield.Pack();
            writer.Write(packedValue);
        }
    }
}
