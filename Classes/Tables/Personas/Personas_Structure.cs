using MetroSet_UI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public class PersonaTableData
        {
            public List<PersonaStats> Stats { get; set; } = new List<PersonaStats>(); // segment 0, 1
            public PtyLvlUp[] PartyLevelUpThresholds { get; set; } = new PtyLvlUp[9]; // segment 2
            public List<PtyMemberPersona> PartyMemberPersonas { get; set; } = new List<PtyMemberPersona>(); // segment 3
        }

        public class PersonaStats
        {
            // Segment 0: Stats
            public byte DLCorTreasureDemon { get; set; } = 0x00;
            public bool[] Bitflags { get; set; } = new bool[8];
            public byte Arcana { get; set; } = 0x01;
            public byte BaseLevel { get; set; } = 0x01;
            public BattleStats Stats { get; set; } = new BattleStats();
            public ushort SkillInheritance { get; set; } = 0;
            public ushort Unknown = 0;

            // Segment 1: Stat Growth & Skills
            public BattleStats WeightedStatGrowthDistribution { get; set; } = new BattleStats();
            public byte UnknownU8 = 0x00;
            public PendingSkillorTrait[] PendingSkillsorTraits = new PendingSkillorTrait[16];

        }

        public class PendingSkillorTrait
        {
            public byte PendingLevels { get; set; } = 0x00;
            public byte Learnability { get; set; } = 0x00;
            public short SkillID { get; set; } = 0;
            public short TraitID { get; set; } = 0;

        }

        public class PtyLvlUp
        {
            public uint[] ExpRequired { get; set; } = new uint[98];
        }

        public class PtyMemberPersona
        {
            public ushort Character { get; set; } = 0;
            public byte LevelsAvailable { get; set; } = 0x63;
            public byte UnknownU8 = 0x00;
            public PendingSkillorTrait[] PendingSkillsorTraits { get; set; } = new PendingSkillorTrait[32];
            public BattleStats[] StatGainPerLevel { get; set; } = new BattleStats[98];
        }
    }
}
