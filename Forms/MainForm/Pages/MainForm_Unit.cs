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

            string newValue = $"[{unit.Id}] {unit.ShadowName} ({unit.PersonaName})";

            if (!string.IsNullOrEmpty(unit.Comment))
                newValue += $" // {unit.Comment}";

            e.Value = newValue.Replace("Not Used","");
        }

        private void UpdateUnitNameFields()
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            txt_UnitID.Text = selectedUnit.Id.ToString();
            txt_PersonaName.Text = selectedUnit.PersonaName;
            txt_ShadowName.Text = selectedUnit.ShadowName;
        }

        private void UpdateUnitStatFields()
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            numUpDwn_UnitLevel.Value = selectedUnit.EnemyStats.Level;
            numUpDwn_UnitHP.Value = selectedUnit.EnemyStats.HP;
            numUpDwn_UnitSP.Value = selectedUnit.EnemyStats.SP;

            num_Strength.Value = selectedUnit.EnemyStats.Stats.Strength;
            num_Magic.Value = selectedUnit.EnemyStats.Stats.Magic;
            num_Endurance.Value = selectedUnit.EnemyStats.Stats.Endurance;
            num_Agility.Value = selectedUnit.EnemyStats.Stats.Agility;
            num_Luck.Value = selectedUnit.EnemyStats.Stats.Luck;

            num_UnitAttackDamage.Value = selectedUnit.EnemyStats.AttackAttributes.AttackDamage;

            num_UnitEXP.Value = selectedUnit.EnemyStats.EXPReward;
            num_UnitMoney.Value = selectedUnit.EnemyStats.MoneyReward;

            num_UnitVoiceID.Value = selectedUnit.VoiceData.VoiceID;
            num_UnitACBValue.Value = selectedUnit.VoiceData.VoiceAcbValue;
            num_UnitTalkMoneyMin.Value = selectedUnit.VoiceData.TALK_MONEY_MIN;
            num_UnitTalkMoneyMax.Value = selectedUnit.VoiceData.TALK_MONEY_MAX;
            num_UnitTalkPerson.Value = selectedUnit.VoiceData.TALK_PERSON;

            num_UnitVisualUnknownR.Value = selectedUnit.VisualData.UnknownR;
            num_UnitModelID.Value = selectedUnit.VisualData.ModelID;
            num_UnitPersonaID.Value = selectedUnit.VisualData.PersonaID;

            num_EventItemDrop0.Value = selectedUnit.EnemyStats.EventItemDrop.Probability;
            num_EventItemFlag0.Value = selectedUnit.EnemyStats.EventItemDrop.EventID;

            num_ItemDrop0.Value = selectedUnit.EnemyStats.ItemDrops[0].Probability;
            num_ItemDrop1.Value = selectedUnit.EnemyStats.ItemDrops[1].Probability;
            num_ItemDrop2.Value = selectedUnit.EnemyStats.ItemDrops[2].Probability;
            num_ItemDrop3.Value = selectedUnit.EnemyStats.ItemDrops[3].Probability;
        }

        private void UpdateUnitComboBoxFields()
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            comboBox_UnitArcana.Items.Clear();
            for(int i = 0; i < ArcanaNamess.Count; i++)
            {
                comboBox_UnitArcana.Items.Add(ArcanaNamess[i]);
            }
            comboBox_UnitArcana.SelectedIndex = selectedUnit.EnemyStats.Arcana;
        }

        // Save selected unit ID and update fields related to unit selection
        private void UnitList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Units.Items != null && comboBox_Units.Items.Count > 0)
            {
                selectedUnitID = comboBox_Units.SelectedIndex;

                UpdateUnitFlagsList();
                UpdateUnitNameFields();
                UpdateUnitStatFields();
                UpdateUnitComboBoxFields();
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

        private void UnitSearch_KeyDown(object sender, KeyEventArgs e)
        {
            string searchTxt = txt_UnitSearch.Text.ToLower();
            if (string.IsNullOrEmpty(searchTxt))
                return;
            if (e.KeyData == Keys.Enter)
            {
                // stop windows ding noise
                e.Handled = true;
                e.SuppressKeyPress = true;

                int i = selectedUnitID + 1;
                while (i < comboBox_Units.Items.Count)
                {
                    if (i == selectedUnitID)
                        return;

                    var unit = (EnemyUnit)comboBox_Units.Items[i];

                    if (unit.Comment.ToLower().Contains(searchTxt.ToLower())
                        || unit.PersonaName.ToLower().Contains(searchTxt.ToLower()) 
                        || unit.ShadowName.ToLower().Contains(searchTxt.ToLower()))
                    {
                        comboBox_Units.SelectedIndex = i;
                        return;
                    }

                    if (i == comboBox_Units.Items.Count - 1)
                        i = 0;
                    else
                        i++;
                }
            }
        }
    }
}
