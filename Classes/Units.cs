using MetroSet_UI.Forms;
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
        private UnitTableData ReadP5RUnitTbl(string path)
        {
            UnitTableData unitTblData = new UnitTableData();

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (BinaryReader br = new BinaryReader(fs, Encoding.Unicode))
                {
                    // Segment 0: Enemy Unit Stats
                    uint segment0Size = br.ReadUInt32();
                    for (int i = 0; i < (segment0Size / 68); i++)
                    {
                        // Bit flags
                        unitTblData.EnemyUnits[0].EnemyStats.Flags = new List<bool[]>
                        {
                            ConvertByteToBools(br.ReadByte()), ConvertByteToBools(br.ReadByte()),
                            ConvertByteToBools(br.ReadByte()), ConvertByteToBools(br.ReadByte())
                        };
                        // Misc
                        unitTblData.EnemyUnits[0].EnemyStats.Arcana = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.RESERVE = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.Level = br.ReadUInt16();
                        unitTblData.EnemyUnits[0].EnemyStats.HP = br.ReadUInt32();
                        unitTblData.EnemyUnits[0].EnemyStats.SP = br.ReadUInt32();
                        // Enemy Stats
                        unitTblData.EnemyUnits[0].EnemyStats.Stats.Strength = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.Stats.Magic = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.Stats.Endurance = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.Stats.Agility = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.Stats.Luck = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.RESERVE2 = br.ReadByte();
                        // Enemy Skills
                        for (int x = 0; x < 8; x++)
                            unitTblData.EnemyUnits[0].EnemyStats.Skills[x] = br.ReadUInt16();
                        // Rewards
                        unitTblData.EnemyUnits[0].EnemyStats.EXPReward = br.ReadUInt16();
                        unitTblData.EnemyUnits[0].EnemyStats.MoneyReward = br.ReadUInt16();
                        for (int x = 0; x < 4; x++)
                            unitTblData.EnemyUnits[0].EnemyStats.ItemDrops[x] = new ItemDrop() { ItemID = br.ReadUInt16(), Probability = br.ReadUInt16() };
                        unitTblData.EnemyUnits[0].EnemyStats.EventItemDrop = new ItemDrop() { EventID = br.ReadUInt16(), ItemID = br.ReadUInt16(), Probability = br.ReadUInt16() };
                        // Attack Attributes
                        unitTblData.EnemyUnits[0].EnemyStats.AttackAttributes.AttackType = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.AttackAttributes.AttackAccuracy = br.ReadByte();
                        unitTblData.EnemyUnits[0].EnemyStats.AttackAttributes.AttackDamage = br.ReadUInt16();
                    }

                    // Segment 1: Elemental Affinities (Enemies)
                    uint segment1Size = br.ReadUInt32();
                    for (int i = 0; i < (segment1Size / 40); i++)
                    {
                        UnitTblData.EnemyUnits[i].Affinities.Add(
                            new Affinity()
                            {
                                Attributes = ConvertByteToBools(br.ReadByte()),
                                Multiplier = br.ReadByte()
                            });
                    }

                    // Segment 2: Elemental Affinities (Personas)
                    uint segment2Size = br.ReadUInt32();
                    for (int i = 0; i < (segment2Size / 40); i++)
                    {
                        UnitTblData.PersonaUnits[i].Affinities.Add( 
                            new Affinity() { Attributes = ConvertByteToBools(br.ReadByte()), 
                                Multiplier = br.ReadByte() });
                    }

                    // Segment 3: Voice Data (Enemies)
                    uint segment3Size = br.ReadUInt32();
                    for (int i = 0; i < (segment3Size / 24); i++)
                    {
                        UnitTblData.EnemyUnits[i].VoiceData.VoiceID = br.ReadByte();
                        UnitTblData.EnemyUnits[i].VoiceData.TALK_PERSON = br.ReadByte();
                        UnitTblData.EnemyUnits[i].VoiceData.VoiceAcbValue = br.ReadByte();
                        UnitTblData.EnemyUnits[i].VoiceData.Padding = br.ReadByte();
                        UnitTblData.EnemyUnits[i].VoiceData.TALK_MONEY_MIN = br.ReadUInt16();
                        UnitTblData.EnemyUnits[i].VoiceData.TALK_MONEY_MAX = br.ReadUInt16();
                        for (int x = 0; x < 4; x++)
                            unitTblData.EnemyUnits[0].VoiceData.TALK_ITEM[x] = new ItemDrop() { ItemID = br.ReadUInt16() };
                        for (int x = 0; x < 4; x++)
                            unitTblData.EnemyUnits[0].VoiceData.TALK_ITEM_RARE[x] = new ItemDrop() { ItemID = br.ReadUInt16() };
                    }

                    // Segment 4: Visual Data (Enemies)
                    uint segment4Size = br.ReadUInt32();
                    for (int i = 0; i < (segment4Size / 6); i++)
                    {
                        unitTblData.EnemyUnits[i].VisualData.Add(new VisualData() { PersonaID = br.ReadUInt16(), ModelID = br.ReadUInt16(), UnknownR = br.ReadUInt16() });
                    }

                    // Segment 5: Unknown
                    unitTblData.Segment5 = br.ReadBytes(1800);
                }
            }

            return unitTblData;
        }

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

        private void WriteP5RUnitTbl(UnitTableData unitTblData, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
                {
                    // Segment 0: Enemy Unit Stats
                    uint segment0Size = Convert.ToUInt32(68 * unitTblData.EnemyUnits.Count);
                    bw.Write(segment0Size);
                    foreach (var unit in unitTblData.EnemyUnits)
                    {
                        // Bit flags
                        foreach(var flagCollection in unit.EnemyStats.Flags)
                            bw.Write(ConvertBoolsToByte(flagCollection));
                        // Misc
                        bw.Write(unit.EnemyStats.Arcana);
                        bw.Write(unit.EnemyStats.RESERVE);
                        bw.Write(unit.EnemyStats.Level);
                        bw.Write(unit.EnemyStats.HP);
                        bw.Write(unit.EnemyStats.SP);
                        // Enemy Stats
                        bw.Write(unit.EnemyStats.Stats.Strength);
                        bw.Write(unit.EnemyStats.Stats.Magic);
                        bw.Write(unit.EnemyStats.Stats.Endurance);
                        bw.Write(unit.EnemyStats.Stats.Agility);
                        bw.Write(unit.EnemyStats.Stats.Luck);
                        bw.Write(unit.EnemyStats.RESERVE2);
                        // Enemy Skills
                        foreach (var skill in unit.EnemyStats.Skills)
                            bw.Write(skill);
                        // Rewards
                        bw.Write(unit.EnemyStats.EXPReward);
                        bw.Write(unit.EnemyStats.MoneyReward);
                        foreach(var itemDrop in unit.EnemyStats.ItemDrops)
                        {
                            bw.Write(itemDrop.ItemID);
                            bw.Write(itemDrop.Probability);
                        }
                        bw.Write(unit.EnemyStats.EventItemDrop.EventID);
                        bw.Write(unit.EnemyStats.EventItemDrop.ItemID);
                        bw.Write(unit.EnemyStats.EventItemDrop.Probability);
                        // Attack Attributes
                        bw.Write(unit.EnemyStats.AttackAttributes.AttackType);
                        bw.Write(unit.EnemyStats.AttackAttributes.AttackAccuracy);
                        bw.Write(unit.EnemyStats.AttackAttributes.AttackDamage);
                    }

                    // Segment 1: Elemental Affinities (Enemies)
                    uint segment1Size = Convert.ToUInt32(40 * unitTblData.EnemyUnits.Count);
                    bw.Write(segment1Size);
                    foreach (var unit in unitTblData.EnemyUnits)
                    {
                        foreach (var affinity in unit.Affinities)
                        {
                            bw.Write(ConvertBoolsToByte(affinity.Attributes));
                            bw.Write(affinity.Multiplier);
                        }
                    }

                    // Segment 2: Elemental Affinities (Personas)
                    uint segment2Size = Convert.ToUInt32(40 * unitTblData.PersonaUnits.Count);
                    bw.Write(segment2Size);
                    foreach (var unit in unitTblData.PersonaUnits)
                    {
                        foreach (var affinity in unit.Affinities)
                        {
                            bw.Write(ConvertBoolsToByte(affinity.Attributes));
                            bw.Write(affinity.Multiplier);
                        }
                    }

                    // Segment 3: Voice Data (Enemies)
                    uint segment3Size = Convert.ToUInt32(24 * unitTblData.EnemyUnits.Count);
                    bw.Write(segment3Size);
                    foreach (var unit in unitTblData.EnemyUnits)
                    {
                        bw.Write(unit.VoiceData.VoiceID);
                        bw.Write(unit.VoiceData.TALK_PERSON);
                        bw.Write(unit.VoiceData.VoiceAcbValue);
                        bw.Write(unit.VoiceData.Padding);
                        bw.Write(unit.VoiceData.TALK_MONEY_MIN);
                        bw.Write(unit.VoiceData.TALK_MONEY_MAX);
                        foreach (var itemDrop in unit.VoiceData.TALK_ITEM)
                            bw.Write(itemDrop.ItemID);
                        foreach (var itemDrop in unit.VoiceData.TALK_ITEM_RARE)
                            bw.Write(itemDrop.ItemID);
                    }

                    // Segment 4: Visual Data (Enemies)
                    uint segment4Size = Convert.ToUInt32(6 * unitTblData.EnemyUnits.Count);
                    bw.Write(segment4Size);
                    foreach (var unit in unitTblData.EnemyUnits)
                    {
                        bw.Write(unit.VoiceData.VoiceID);
                        bw.Write(unit.VoiceData.TALK_PERSON);
                        bw.Write(unit.VoiceData.VoiceAcbValue);
                        bw.Write(unit.VoiceData.Padding);
                        bw.Write(unit.VoiceData.TALK_MONEY_MIN);
                        bw.Write(unit.VoiceData.TALK_MONEY_MAX);
                        foreach (var itemDrop in unit.VoiceData.TALK_ITEM)
                            bw.Write(itemDrop.ItemID);
                        foreach (var itemDrop in unit.VoiceData.TALK_ITEM_RARE)
                            bw.Write(itemDrop.ItemID);
                    }

                    // Segment 5: Unknown
                    bw.Write(Convert.ToUInt32(unitTblData.Segment5.Length));
                    bw.Write(unitTblData.Segment5);
                }
            }
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

        public class UnitTableData
        {
            public List<EnemyUnit> EnemyUnits { get; set; } = new List<EnemyUnit>(); // segment 0, 1, 3, 4
            public List<PersonaUnit> PersonaUnits { get; set; } = new List<PersonaUnit>(); // segment 2
            public byte[] Segment5 { get; set; } = new byte[1800]; // unknown byte
        }

        public class EnemyUnit
        {
            public EnemyStats EnemyStats { get; set; } = new EnemyStats(); // segment 0
            public List<Affinity> Affinities { get; set; } = new List<Affinity>(); // segment 1
            public VoiceData VoiceData { get; set; } = new VoiceData(); // segment 3
            public List<VisualData> VisualData { get; set; } = new List<VisualData>(); // segment 4
        }

        public class PersonaUnit
        {
            public List<Affinity> Affinities { get; set; } = new List<Affinity>(); // 464
        }

        public class VisualData
        {
            public ushort PersonaID { get; set; } = 0;
            public ushort ModelID { get; set; } = 0;
            public ushort UnknownR { get; set; } = 0;
        }

        public class VoiceData
        {
            public byte VoiceID { get; set; } = 0x00; // Subtract 1 from the id i.e. 9 to load voicepack 10
            public byte TALK_PERSON { get; set; } = 0x00;
            public byte VoiceAcbValue { get; set; } = 0x00;
            public byte Padding = 0x00;
            public ushort TALK_MONEY_MIN { get; set; } = 0;
            public ushort TALK_MONEY_MAX { get; set; } = 0;
            public ItemDrop[] TALK_ITEM { get; set; } = new ItemDrop[4];
            public ItemDrop[] TALK_ITEM_RARE { get; set; } = new ItemDrop[4];

        }

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

        public class Affinity
        {
            public bool[] Attributes { get; set; } = new bool[8];

            // Multiplies damage & ailment chance. 20 is Neutral since 20 x 5% = 100% of normal dmg &
            // ail. chance. 80 x 5% = 400% = 4x multiplier. 0 is ignored (does not nullify attack).
            public byte Multiplier = 0x00;
        }

        public class EnemyStats
        {
            public List<bool[]> Flags { get; set; } = new List<bool[]>() { new bool[8], new bool[8], new bool[8], new bool[8] };
            public byte Arcana { get; set; } = Convert.ToByte(ArcanaName.Fool);
            public byte RESERVE = 0x00;
            public ushort Level { get; set; } = 0;
            public uint HP { get; set; } = 0;
            public uint SP { get; set; } = 0;
            public BattleStats Stats { get; set; } = new BattleStats();
            public byte RESERVE2 = 0x00;
            public ushort[] Skills { get; set; } = new ushort[8];
            public ushort EXPReward { get; set; } = 0;
            public ushort MoneyReward { get; set; } = 0;
            public ItemDrop[] ItemDrops { get; set; } = new ItemDrop[4];
            public ItemDrop EventItemDrop { get; set; } = new ItemDrop();
            public AttackData AttackAttributes { get; set; } = new AttackData();
        }

        public class AttackData
        {
            public byte AttackType { get; set; } = Convert.ToByte(ElementalType.Physical);
            public byte AttackAccuracy { get; set; } = 0x00;
            public ushort AttackDamage { get; set; } = 0;
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

        public class ItemDrop
        {
            public ushort EventID = 0;
            public ushort ItemID = 0;
            public ushort Probability = 0;
        }

        public class BattleSkills
        {
            public ushort Skill1 { get; set; } = 0;
            public ushort Skill2 { get; set; } = 0;
            public ushort Skill3 { get; set; } = 0;
            public ushort Skill4 { get; set; } = 0;
            public ushort Skill5 { get; set; } = 0;
            public ushort Skill6 { get; set; } = 0;
            public ushort Skill7 { get; set; } = 0;
            public ushort Skill8 { get; set; } = 0;

        }

        public class BattleStats
        {
            public byte Strength { get; set; } = 0x00;
            public byte Magic { get; set; } = 0x00;
            public byte Endurance { get; set; } = 0x00;
            public byte Agility { get; set; } = 0x00;
            public byte Luck { get; set; } = 0x00;
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
