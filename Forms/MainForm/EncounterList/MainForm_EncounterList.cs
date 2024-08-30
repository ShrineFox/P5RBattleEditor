using MetroSet_UI.Forms;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public static int selectedEncounterID = -1;

        // Initial setup for dropdown list of Encounters
        private static BindingSource bindingSource_EncounterList = new BindingSource();
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

        // Show encounter ID and enemy names in Encounter list (plus comment)
        private void EncounterListFormat(object sender, ListControlConvertEventArgs e)
        {
            var encounter = (Encounter)e.ListItem;

            string newValue = $"[{encounter.Id}]";

            foreach(var unit in encounter.BattleUnits)
                newValue += $" {EnemyUnitNames[unit]} |";

            newValue.TrimEnd('|').Trim();
            if (!string.IsNullOrEmpty(encounter.Comment))
                newValue += $" ({encounter.Comment})";

            e.Value = newValue.Replace("Not Used","");
        }

        // Save selected encounter ID and update fields related to encounter selection
        private void EncounterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Encounters.Items != null && comboBox_Encounters.Items.Count > 0)
            {
                selectedEncounterID = comboBox_Encounters.SelectedIndex;
                UpdateEncounterUnits();
                UpdateEncounterMusic();
                UpdateFieldIDs();
                UpdateEncounterFlagsList();
                UpdateEncounterNotes();
            }
        }

        private void UpdateEncounterFlagsList()
        {
            var selectedEncounter = (Encounter)comboBox_Encounters.SelectedItem;
            chkListBox_EncounterFlags.Items.Clear();

            foreach (PropertyInfo pi in selectedEncounter.Flags.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(bool))
                {
                    bool value = (bool)pi.GetValue(selectedEncounter.Flags);
                    chkListBox_EncounterFlags.Items.Add(pi.Name);
                    chkListBox_EncounterFlags.SetItemChecked(chkListBox_EncounterFlags.Items.Count - 1, value);
                }
            }
        }

        private void UpdateEncounterNotes()
        {
            var selectedEncounter = (Encounter)comboBox_Encounters.SelectedItem;

            txt_EncounterNotes.Text = selectedEncounter.Comment;
        }

        // Show current encounter's field IDs in Encounter tab

        private void UpdateFieldIDs()
        {
            var selectedEncounter = (Encounter)comboBox_Encounters.SelectedItem;

            numUpDwn_FieldIDMajor.Value = selectedEncounter.FieldMajor;
            numUpDwn_FieldIDMinor.Value = selectedEncounter.FieldMinor;
        }

        // Show current encounter's music in Encounter tab
        private void UpdateEncounterMusic()
        {
            var selectedEncounter = (Encounter)comboBox_Encounters.SelectedItem;
            comboBox_EncounterMusic.SelectedIndex = BattleBGMs.P5RBattleBGMs.IndexOf(BattleBGMs.P5RBattleBGMs.Single(x => x.Id == selectedEncounter.Music));
        }

        // Show current encounter's battle units in Encounter tab
        private void UpdateEncounterUnits()
        {
            comboBox_BattleUnit0.Enabled = false; comboBox_BattleUnit1.Enabled = false;
            comboBox_BattleUnit2.Enabled = false; comboBox_BattleUnit3.Enabled = false;
            comboBox_BattleUnit4.Enabled = false;

            if (comboBox_BattleUnit0.Items.Count <= 0)
                return;

            var selectedEncounter = (Encounter)comboBox_Encounters.SelectedItem;
            comboBox_BattleUnit0.SelectedIndex = selectedEncounter.BattleUnits[0];
            comboBox_BattleUnit1.SelectedIndex = selectedEncounter.BattleUnits[1];
            comboBox_BattleUnit2.SelectedIndex = selectedEncounter.BattleUnits[2];
            comboBox_BattleUnit3.SelectedIndex = selectedEncounter.BattleUnits[3];
            comboBox_BattleUnit4.SelectedIndex = selectedEncounter.BattleUnits[4];

            comboBox_BattleUnit0.Enabled = true; comboBox_BattleUnit1.Enabled = true;
            comboBox_BattleUnit2.Enabled = true; comboBox_BattleUnit3.Enabled = true;
            comboBox_BattleUnit4.Enabled = true;
        }
    }
}
