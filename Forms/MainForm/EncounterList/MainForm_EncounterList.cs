using MetroSet_UI.Forms;
using System;
using static System.ComponentModel.TypeConverter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;
using static P5RBattleEditor.MainForm;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        private static BindingSource bindingSource_EncounterList = new BindingSource();
        public static int selectedEncounterID = -1;
        public static List<string> EnemyUnitNames = new List<string>();
        private void GetEnemyUnitNames()
        {
            EnemyUnitNames.Clear();
            var enemiesSectionID = Array.IndexOf(TblNamesR, "Enemies");
            foreach (var entry in NameTblData[enemiesSectionID].TblEntries)
                EnemyUnitNames.Add(entry.Name);
        }

        private void UpdateEncounterListComboBox()
        {
            if (EncountTblData.Encounters != null && EncountTblData.Encounters.Count > 0)
            {
                bindingSource_EncounterList.DataSource = EncountTblData.Encounters;
                comboBox_Encounters.DataSource = bindingSource_EncounterList;
                comboBox_Encounters.FormattingEnabled = true;
                comboBox_Encounters.Format += EncounterListFormat;
            }
        }

        private void EncounterListFormat(object sender, ListControlConvertEventArgs e)
        {
            var encounter = (Encounter)e.ListItem;

            e.Value = $"[{encounter.Id}] ";
            foreach(var unit in encounter.BattleUnits)
                e.Value += $"{EnemyUnitNames[unit]} - ";
            e.Value += encounter.Comment;
        }
    }
}
