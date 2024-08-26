using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static P5RBattleEditor.P5RBattleEditor;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        List<Encounter> Encounters = new List<Encounter>();
        UnitTableData UnitTblData = new UnitTableData();
        List<Skill> Skills = new List<Skill>();


        public P5RBattleEditor()
        {
            InitializeComponent();
            LoadTables();
            WriteTables();
        }

        private void LoadTables()
        {
            //Encounters = ReadP5REncountTbl("./TBL/ENCOUNT.TBL");
            UnitTblData = ReadP5RUnitTbl("./TBL/UNIT.TBL");
            //Skills = ReadP5RSkillTbl("./TBL/SKILL.TBL");
        }

        private void WriteTables()
        {
            //WriteP5REncountTbl(Encounters, "./TBL_NEW/ENCOUNT.TBL");
            WriteP5RUnitTbl(UnitTblData, "./TBL_NEW/UNIT.TBL");
            //WriteP5RSkillTbl(Skills, "./TBL_NEW/SKILL.TBL");
        }
    }
}
