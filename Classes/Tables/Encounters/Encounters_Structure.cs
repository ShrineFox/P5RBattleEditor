using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public class EncountTableData
        {
            public List<Encounter> Encounters { get; set; } = new List<Encounter>();
            public List<ChallengeBattleData> ChallengeBtlData { get; set; } = new List<ChallengeBattleData>();
        }

        public class Encounter
        {
            public int Id { get; set; } = 0; // added for convenience
            public string Comment { get; set; } = ""; // added for convenience
            public EncounterFlags Flags { get; set; } = new EncounterFlags();
            public ushort Field04 { get; set; } = 0;
            public ushort Field06 { get; set; } = 0;
            public ushort[] BattleUnits { get; set; } = new ushort[5];
            public ushort FieldMajor { get; set; } = 0;
            public ushort FieldMinor { get; set; } = 0;
            public ushort Music { get; set; } = Convert.ToUInt16(MusicNames.LastSurprise);
            public EnemyReplacementData Replacements { get; set; } = new EnemyReplacementData();
            public DiasterShadowData Disastershadows { get; set; } = new DiasterShadowData();
            [Description("If value is 3 or 4, Disaster Shadows spawn with sleep and rage.")]
            public byte Field0F { get; set; } = 0x00;
            [Description("Controls how likely it is for normal shadows to attack disaster allies.")]
            public byte Field10 { get; set; } = 0x00;
            public byte Field11 { get; set; } = 0x00;
            public byte Field12 { get; set; } = 0x00;
            public byte Field13 { get; set; } = 0x00;
            public ushort[] ForcedPartyData { get; set; } = new ushort[4]; // from a separate section

        }

        public class EncounterFlags
        {
            public bool Bit0 { get; set; } = false;
            public bool Bit1 { get; set; } = false;
            public bool Bit2 { get; set; } = false;
            public bool Bit3 { get; set; } = false;
            public bool Bit4 { get; set; } = false;
            public bool Bit5 { get; set; } = false;
            public bool Bit6 { get; set; } = false;
            public bool Bit7 { get; set; } = false;

            public bool Bit8 { get; set; } = false;
            public bool Bit9 { get; set; } = false;
            public bool Bit10 { get; set; } = false;
            public bool Bit11 { get; set; } = false;
            [Description("Makes all enemies unable to negotiate with.")]
            public bool NoNegotiation { get; set; } = false;
            public bool Bit13 { get; set; } = false;
            public bool Bit14 { get; set; } = false;
            public bool Bit15 { get; set; } = false;
            [Description("Makes all enemies unable to be knocked down.")]
            public bool NoKnockdown { get; set; } = false;
            [Description("Triggers Position Hack at the start of battle.")]
            public bool PositionHack { get; set; } = false;
            [Description("Hold up will not trigger after downing all enemies.")]
            public bool NoHoldUp { get; set; } = false;
            [Description("Enemy models won't dissipate after defeat in this battle.")] 
            public bool NoDisappear { get; set; } = false;
            [Description("Bullet Hail will activate automatically when this battle starts.")] 
            public bool BulletHailOnStart { get; set; } = false;
            [Description("Disables Navigator in this battle.")] 
            public bool NoNavi { get; set; } = false;
            public bool Bit22 { get; set; } = false;
            [Description("Game will freeze if battle script does not exist.")] 
            public bool LoadBattleScript { get; set; } = false;
            public bool Bit24 { get; set; } = false;
            public bool Bit25 { get; set; } = false;
            [Description("Game will freeze if battle script does not exist (uses battle formation layout).")] 
            public bool LoadBFLBattleScript { get; set; } = false;
            [Description("Causes enemy to act first as if you were ambushed.")]
            public bool EnemyFirstAct { get; set; } = false;
            [Description("Makes it so you can't land Critical Hits in this battle.")]
            public bool NoCritical { get; set; } = false;
            public bool Bit29 { get; set; } = false;
            public bool Bit30 { get; set; } = false;
            [Description("Makes this battle unescapable.")]
            public bool NoEscape { get; set; } = false;
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
            [Description("Percent chance of each enemy being replaced increases by 30% when set to 1.")]
            public byte Chance { get; set; } = 0x00;
            public byte[] ChancePerSlot { get; set; } = new byte[5];
        }
    }
}
