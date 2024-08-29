using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        public static EncountTableData EncountTblData = new EncountTableData();
        public static UnitTableData UnitTblData = new UnitTableData();
        public static SkillTableData SkillTblData = new SkillTableData();
        public static PersonaTableData PersonaTblData = new PersonaTableData();
        public static List<TblSection> NameTblData = new List<TblSection>();

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
            PersonaTblData = ReadP5RPersonaTbl("./TBL/PERSONA.TBL");
            NameTblData = ReadNameTBL("./TBL/NAME.TBL");
        }

        private void WriteTables()
        {
            WriteP5REncountTbl("./TBL_NEW/ENCOUNT.TBL");
            WriteP5RUnitTbl("./TBL_NEW/UNIT.TBL");
            WriteP5RSkillTbl("./TBL_NEW/SKILL.TBL");
            WriteP5RPersonaTbl("./TBL_NEW/PERSONA.TBL");
            WriteNameTbl("./TBL_NEW/NAME.TBL");
        }
    }
}
