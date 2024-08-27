using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        EncountTableData EncountTblData = new EncountTableData();
        UnitTableData UnitTblData = new UnitTableData();
        SkillTableData SkillTblData = new SkillTableData();


        public P5RBattleEditor()
        {
            InitializeComponent();
            LoadTables();
            WriteTables();
        }

        private void LoadTables()
        {
            EncountTblData = ReadP5REncountTbl("./TBL/ENCOUNT.TBL");
            UnitTblData = ReadP5RUnitTbl("./TBL/UNIT.TBL");
            SkillTblData = ReadP5RSkillTbl("./TBL/SKILL.TBL");
        }

        private void WriteTables()
        {
            WriteP5REncountTbl("./TBL_NEW/ENCOUNT.TBL");
            WriteP5RUnitTbl("./TBL_NEW/UNIT.TBL");
            WriteP5RSkillTbl("./TBL_NEW/SKILL.TBL");
        }
    }
}
