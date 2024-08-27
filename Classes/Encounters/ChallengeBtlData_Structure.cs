using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        public class ChallengeBattleData
        {
            public ushort Category { get; set; } = 0;
            public ushort CategoryIndex { get; set; } = 0;
            public uint Flag { get; set; } = 0;
            public ushort TurnBonusCount { get; set; } = 0;
            public uint TurnBonus { get; set; } = 0;
            public Bonus[] Bonuses { get; set; } = new Bonus[5];
            public uint[] WaveEncounters { get; set; } = new uint[5];
            public uint Level { get; set; } = 0;
            public uint IconCount { get; set; } = 0;
            public Award[] Awards { get; set; } = new Award[3];
        }

        public class Award
        {
            public uint RequiredScore { get; set; } = 0;
            public ushort ItemID { get; set; } = 0;

        }

        public class Bonus
        {
            public uint Target { get; set; } = 0;
            public uint Type { get; set; } = 0;
            public float Multiplier { get; set; } = 0f;
        }
    }
}
