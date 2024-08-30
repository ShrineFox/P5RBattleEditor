using MetroSet_UI.Forms;
using System;
using static System.ComponentModel.TypeConverter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        private void SetupFormControls()
        {
            GetEnemyUnitNames();
            SetEnemyUnitDropdowns();
            UpdateEncounterListComboBox();
        }

        public static List<string> EnemyUnitNames = new List<string>();
        private void GetEnemyUnitNames()
        {
            EnemyUnitNames.Clear();
            var enemiesSectionID = Array.IndexOf(TblNamesR, "Enemies");
            foreach (var entry in NameTblData[enemiesSectionID].TblEntries)
                EnemyUnitNames.Add(entry.Name);
        }

        private static BindingSource bs_Enemy0 = new BindingSource();
        private static BindingSource bs_Enemy1 = new BindingSource();
        private static BindingSource bs_Enemy2 = new BindingSource();
        private static BindingSource bs_Enemy3 = new BindingSource();
        private static BindingSource bs_Enemy4 = new BindingSource();

        private void SetEnemyUnitDropdowns()
        {
            bs_Enemy0.DataSource = EnemyUnitNames;
            bs_Enemy1.DataSource = EnemyUnitNames;
            bs_Enemy2.DataSource = EnemyUnitNames;
            bs_Enemy3.DataSource = EnemyUnitNames;
            bs_Enemy4.DataSource = EnemyUnitNames;

            comboBox_BattleUnit0.FormattingEnabled = true;
            comboBox_BattleUnit0.Format += EnemyListFormat;
            comboBox_BattleUnit0.DataSource = bs_Enemy0;
            comboBox_BattleUnit1.FormattingEnabled = true;
            comboBox_BattleUnit1.Format += EnemyListFormat;
            comboBox_BattleUnit1.DataSource = bs_Enemy1;
            comboBox_BattleUnit2.FormattingEnabled = true;
            comboBox_BattleUnit2.Format += EnemyListFormat;
            comboBox_BattleUnit2.DataSource = bs_Enemy2;
            comboBox_BattleUnit3.FormattingEnabled = true;
            comboBox_BattleUnit3.Format += EnemyListFormat;
            comboBox_BattleUnit3.DataSource = bs_Enemy3;
            comboBox_BattleUnit4.FormattingEnabled = true;
            comboBox_BattleUnit4.Format += EnemyListFormat;
            comboBox_BattleUnit4.DataSource = bs_Enemy4;
        }

        private void EnemyListFormat(object sender, ListControlConvertEventArgs e)
        {
            int enemyID = EnemyUnitNames.IndexOf(e.ListItem.ToString());
            if (enemyID == -1)
                return;

            string newValue = $"[{enemyID}] {EnemyUnitNames[enemyID]}";

            e.Value = newValue;
        }



        // Search Box
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
