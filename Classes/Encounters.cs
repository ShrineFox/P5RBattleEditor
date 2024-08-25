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
        private List<Encounter> ReadP5REncountTbl(string path)
        {
            List<Encounter> encounters = new List<Encounter>();

            return encounters;
        }

        internal class Encounter
        {
            EncounterSegment0 Segment0 { get; set; } = new EncounterSegment0();
            ForcedPartyData Segment1 { get; set; } = new ForcedPartyData();
            // Segment2: challenge battle data
        }

        internal class ForcedPartyData
        {
            ushort Slot1 { get; set; } = Convert.ToUInt16(PartyMembers.Null);
            ushort Slot2 { get; set; } = Convert.ToUInt16(PartyMembers.Null);
            ushort Slot3 { get; set; } = Convert.ToUInt16(PartyMembers.Null);
            ushort Slot4 { get; set; } = Convert.ToUInt16(PartyMembers.Null);
        }

        enum PartyMembers
        {
            Null = 0,
            Joker = 1,
            Ryuji = 2,
            Morgana = 3,
            Ann = 4,
            Yusuke = 5,
            Makoto = 6,
            Haru = 7,
            Futaba = 8,
            Akechi = 9,
            Kasumi = 10,
            NoChange = 100,
            Protagonist = 101
        }

        internal class EncounterSegment0
        {
            EncounterFlags flags { get; set; } = new EncounterFlags();
            ushort Field04;
            ushort Field06;
            BattleUnits units { get; set; } = new BattleUnits();
            ushort FieldMajor = 0;
            ushort FieldMinor = 0;
            ushort Music = Convert.ToUInt16(MusicNames.LastSurprise);
            EnemyReplacementData replacements { get; set; } = new EnemyReplacementData();
            DiasterShadowData disastershadows { get; set; } = new DiasterShadowData();
            byte Field0F; // 3 or 4 = disaster shadows spawn with sleep and rage
            byte Field10; // how likely it is for normal shadows to attack disaster allies
            byte Field11;
            byte Field12;
            byte Field13;
        }

        internal class DiasterShadowData
        {
            byte Chance { get; set; } = 0;
            byte Slot1Chance { get; set; } = 0x00;
            byte Slot2Chance { get; set; } = 0x00;
            byte Slot3Chance { get; set; } = 0x00;
            byte Slot4Chance { get; set; } = 0x00;
            byte Slot5Chance { get; set; } = 0x00;
            byte MaxDisasterShadows { get; set; } = 0x00;

        }

        internal class EnemyReplacementData
        {
            ushort EnemyID { get; set; } = 0;
            byte Chance { get; set; } = 0; // chance increases by 30% when On
            byte Slot1Chance { get; set; } = 0x00;
            byte Slot2Chance { get; set; } = 0x00;
            byte Slot3Chance { get; set; } = 0x00;
            byte Slot4Chance { get; set; } = 0x00;
            byte Slot5Chance { get; set; } = 0x00;
        }

        enum MusicNames
        {
            LastSurprise = 0,
            KeeperOfLust = 4,
            BloomingVillain = 5,
            RiversInTheDesert_Inst = 6,
            WillPower = 7,
            RiversInTheDesert = 8,
            Yaldabaoth = 12,
            OurBeginning = 14
        }

        internal class BattleUnits
        {
            ushort Unit1 { get; set; } = 0;
            ushort Unit2 { get; set; } = 0;
            ushort Unit3 { get; set; } = 0;
            ushort Unit4 { get; set; } = 0;
            ushort Unit5 { get; set; } = 0;
        }

        internal class EncounterFlags
        {
            bool bit0 = false;
            bool bit1 = false;
            bool bit2 = false;
            bool bit3 = false;
            bool bit4 = false;
            bool bit5 = false;
            bool bit6 = false;
            bool bit7 = false;
            bool bit8 = false;
            bool bit9 = false;
            bool bit10 = false;
            bool bit11 = false;
            bool NoNegotiation = false; // makes all enemies unable to negotiate with
            bool bit13 = false;
            bool bit14 = false;
            bool bit15 = false;
            bool NoKnockdown = false; // enemies can never get knocked down
            bool PositionHack = false; // triggers position hack at start of battle
            bool NoHoldUp = false; // hold up will not trigger after downing all enemies
            bool NoDisappear = false; // enemy models won't dissipate after defeat
            bool BulletHailOnStart = false; // always start battle by using bullet hail
            bool NoNavi = false; // disables navigator in this battle
            bool bit22 = false;
            bool LoadBattleScript = false; // game will freeze if battle script does not exist
            bool bit24 = false;
            bool bit25 = false;
            bool LoadBFLBattleScript = false; // game will freeze if battle script does not exist (including battle formation layout)
            bool EnemyFirstAct = false; // causes enemy to act first as if you were ambushed
            bool NoCritical = false; // makes it so you can't land critical hits
            bool bit29 = false;
            bool bit30 = false;
            bool NoEscape = false; // makes battle unescapable
        }
    }
}
