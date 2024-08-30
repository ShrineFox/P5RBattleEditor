using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
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

        enum EncountFlagNames
        {
            Bit0,
            Bit1,
            Bit2,
            Bit3,
            Bit4,
            Bit5,
            Bit6,
            Bit7,

            Bit8,
            Bit9,
            Bit10,
            Bit11,
            NoNegotiation, // makes all enemies unable to negotiate with
            Bit13,
            Bit14,
            Bit15,

            NoKnockdown, // enemies can never get knocked down
            PositionHack, // triggers position hack at start of battle
            NoHoldUp, // hold up will not trigger after downing all enemies
            NoDisappear, // enemy models won't dissipate after defeat
            BulletHailOnStart, // always start battle by using bullet hail
            NoNavi, // disables navigator in this battle
            Bit22,
            LoadBattleScript, // game will freeze if battle script does not exist

            Bit24,
            Bit25,
            LoadBFLBattleScript, // game will freeze if battle script does not exist (including battle formation layout)
            EnemyFirstAct, // causes enemy to act first as if you were ambushed
            NoCritical, // makes it so you can't land critical hits
            Bit29,
            Bit30,
            NoEscape // makes battle unescapable
        }
    }
}
