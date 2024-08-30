using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml;
using static P5RBattleEditor.MainForm;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public static EncountTableData EncountTblData = new EncountTableData();
        public static UnitTableData UnitTblData = new UnitTableData();
        public static SkillTableData SkillTblData = new SkillTableData();
        public static PersonaTableData PersonaTblData = new PersonaTableData();
        public static List<TblSection> NameTblData = new List<TblSection>();

        public MainForm()
        {
            InitializeComponent();
            //LoadTables();
            ReadJsons();
            //WriteJsons();
            //WriteTables();

            SetupFormControls();
        }

        private void LoadTables()
        {
            EncountTblData = ReadP5REncountTbl("./TBL/ENCOUNT.TBL");
            UnitTblData = ReadP5RUnitTbl("./TBL/UNIT.TBL");
            SkillTblData = ReadP5RSkillTbl("./TBL/SKILL.TBL");
            PersonaTblData = ReadP5RPersonaTbl("./TBL/PERSONA.TBL");
            NameTblData = ReadNameTBL("./TBL/NAME.TBL");
        }

        private void ReadJsons()
        {
            EncountTblData = LoadJson(typeof(EncountTableData), "./JSON/ENCOUNT.JSON");
            UnitTblData = LoadJson(typeof(UnitTableData), "./JSON/UNIT.JSON");
            SkillTblData = LoadJson(typeof(SkillTableData), "./JSON/SKILL.JSON");
            PersonaTblData = LoadJson(typeof(PersonaTableData), "./JSON/PERSONA.JSON");
            NameTblData = LoadJson(typeof(List<TblSection>), "./JSON/NAME.JSON");
        }

        private void WriteJsons()
        {
            SaveJson(EncountTblData, "./JSON/ENCOUNT.JSON");
            SaveJson(UnitTblData, "./JSON/UNIT.JSON");
            SaveJson(SkillTblData, "./JSON/SKILL.JSON");
            SaveJson(PersonaTblData, "./JSON/PERSONA.JSON");
            SaveJson(NameTblData, "./JSON/NAME.JSON");
        }

        private void WriteTables()
        {
            WriteP5REncountTbl("./TBL_NEW/ENCOUNT.TBL");
            WriteP5RUnitTbl("./TBL_NEW/UNIT.TBL");
            WriteP5RSkillTbl("./TBL_NEW/SKILL.TBL");
            WriteP5RPersonaTbl("./TBL_NEW/PERSONA.TBL");
            WriteNameTbl("./TBL_NEW/NAME.TBL");
        }

        private void EncounterSearch_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            string searchTxt = txt_EncounterSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchTxt))
                return;
            if (e.KeyData == Keys.Enter)
            {
                // stop windows ding noise
                e.Handled = true;
                e.SuppressKeyPress = true;
            
                int i = selectedEncounterID + 1;
                while (i < comboBox_Encounters.Items.Count)
                {
                    if (i == selectedEncounterID)
                        return;

                    var encounter = (Encounter)comboBox_Encounters.Items[i];

                    if (encounter.Comment.ToLower().Contains(searchTxt)
                        || encounter.BattleUnits.Any(x => EnemyUnitNames[x].ToLower().Contains(searchTxt)))
                    {
                        comboBox_Encounters.SelectedIndex = i;
                        return;
                    }

                    if (i == comboBox_Encounters.Items.Count - 1)
                        i = 0;
                    else
                        i++;
                }
            }
        }
    }
}
