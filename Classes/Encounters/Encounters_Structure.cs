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
        public class EncountTableData
        {
            public List<Encounter> Encounters { get; set; } = new List<Encounter>(); // segment 0, 1
            public List<ChallengeBattleData> ChallengeBtlData { get; set; } = new List<ChallengeBattleData>(); // segment 2
        }

        public class Encounter
        {
            public EncounterData EncounterData { get; set; } = new EncounterData(); // segment 0
            public ushort[] ForcedPartyData { get; set; } = new ushort[4]; // segment 1
        }

        public class EncounterData
        {
            public List<bool[]> Flags { get; set; } = new List<bool[]>() { new bool[8], new bool[8], new bool[8], new bool[8] };
            public ushort Field04 { get; set; } = 0;
            public ushort Field06 { get; set; } = 0;
            public ushort[] BattleUnits { get; set; } = new ushort[5];
            public ushort FieldMajor { get; set; } = 0;
            public ushort FieldMinor { get; set; } = 0;
            public ushort Music { get; set; } = Convert.ToUInt16(MusicNames.LastSurprise);
            public EnemyReplacementData Replacements { get; set; } = new EnemyReplacementData();
            public DiasterShadowData Disastershadows { get; set; } = new DiasterShadowData();
            public byte Field0F { get; set; } = 0x00; // 3 or 4 = disaster shadows spawn with sleep and rage
            public byte Field10 { get; set; } = 0x00; // how likely it is for normal shadows to attack disaster allies
            public byte Field11 { get; set; } = 0x00;
            public byte Field12 { get; set; } = 0x00;
            public byte Field13 { get; set; } = 0x00;
        }

        public class DiasterShadowData
        {
            public byte Chance { get; set; } = 0x00;
            public byte[] ChancePerSlot { get; set; } = new byte[5];
            public byte MaxDisasterShadows { get; set; } = 0x00;

        }

        public class EnemyReplacementData
        {
            public ushort EnemyID { get; set; } = 0;
            public byte Chance { get; set; } = 0x00; // chance increases by 30% when On
            public byte[] ChancePerSlot { get; set; } = new byte[5];
        }
    }
}
