using MetroSet_UI.Forms;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Reflection;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public static int selectedUnitID = -1;

        // Initial setup for dropdown list of Units
        private static BindingSource bindingSource_UnitList = new BindingSource();
        private void UpdateUnitListComboBox()
        {
            if (project.UnitTblData.EnemyUnits != null && project.UnitTblData.EnemyUnits.Count > 0)
            {
                bindingSource_UnitList.DataSource = project.UnitTblData.EnemyUnits;
                comboBox_Units.DataSource = bindingSource_UnitList;
                comboBox_Units.FormattingEnabled = true;
                comboBox_Units.Format += UnitListFormat;
            }
        }

        // Show Unit ID and enemy names in Units list (plus comment)
        private void UnitListFormat(object sender, ListControlConvertEventArgs e)
        {
            var unit = (EnemyUnit)e.ListItem;

            string newValue = $"[{unit.Id}] {EnemyUnitNames[unit.Id]}";
            // TODO: Append Persona Unit name

            if (!string.IsNullOrEmpty(unit.Comment))
                newValue += $" ({unit.Comment})";

            e.Value = newValue.Replace("Not Used","");
        }

        // Save selected unit ID and update fields related to unit selection
        private void UnitList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Units.Items != null && comboBox_Units.Items.Count > 0)
            {
                selectedUnitID = comboBox_Units.SelectedIndex;

                UpdateUnitFlagsList();
                // TODO: UPDATE FORM FIELD VALUES
            }
        }

        private void UnitFlags_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string itemText = chkListBox_UnitFlags.GetItemText(chkListBox_UnitFlags.Items[e.Index]);
            bool checkedBox = (e.NewValue == CheckState.Checked);
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            foreach (PropertyInfo pi in selectedUnit.EnemyStats.Flags.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(bool) && pi.Name == itemText)
                {
                    pi.SetValue(selectedUnit.EnemyStats.Flags, checkedBox);
                }
            }
        }

        private void UpdateUnitFlagsList()
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;
            chkListBox_UnitFlags.Items.Clear();

            foreach (PropertyInfo pi in selectedUnit.EnemyStats.Flags.GetType().GetProperties())
            {
                if (pi.PropertyType == typeof(bool))
                {
                    bool value = (bool)pi.GetValue(selectedUnit.EnemyStats.Flags);
                    chkListBox_UnitFlags.Items.Add(pi.Name);
                    chkListBox_UnitFlags.SetItemChecked(chkListBox_UnitFlags.Items.Count - 1, value);
                }
            }
        }

        private void UpdateUnitNotes()
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            // txt_EncounterNotes.Text = selectedEncounter.Comment;
            // TODO: Add Unit notes section
        }
    }
}
