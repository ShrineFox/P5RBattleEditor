using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
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
    }
}
