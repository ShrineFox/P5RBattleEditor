using MetroSet_UI.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

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

        private static BindingSource bs_EnemySkill0 = new BindingSource();
        private static BindingSource bs_EnemySkill1 = new BindingSource();
        private static BindingSource bs_EnemySkill2 = new BindingSource();
        private static BindingSource bs_EnemySkill3 = new BindingSource();
        private static BindingSource bs_EnemySkill4 = new BindingSource();
        private static BindingSource bs_EnemySkill5 = new BindingSource();
        private static BindingSource bs_EnemySkill6 = new BindingSource();
        private static BindingSource bs_EnemySkill7 = new BindingSource();

        private static BindingSource bs_ItemDropType0 = new BindingSource();
        private static BindingSource bs_ItemDropType1 = new BindingSource();
        private static BindingSource bs_ItemDropType2 = new BindingSource();
        private static BindingSource bs_ItemDropType3 = new BindingSource();
        private static BindingSource bs_EventItemDropType0 = new BindingSource();

        private static BindingSource bs_ItemDrop0 = new BindingSource();
        private static BindingSource bs_ItemDrop1 = new BindingSource();
        private static BindingSource bs_ItemDrop2 = new BindingSource();
        private static BindingSource bs_ItemDrop3 = new BindingSource();
        private static BindingSource bs_EventItemDrop0 = new BindingSource();

        private void SetUnitComboBoxSources()
        {
            // Enemy Skills
            bs_EnemySkill0.DataSource = SkillNames;
            comboBox_UnitSkill0.DataSource = bs_EnemySkill0;
            bs_EnemySkill1.DataSource = SkillNames;
            comboBox_UnitSkill1.DataSource = bs_EnemySkill1;
            bs_EnemySkill2.DataSource = SkillNames;
            comboBox_UnitSkill2.DataSource = bs_EnemySkill2;
            bs_EnemySkill3.DataSource = SkillNames;
            comboBox_UnitSkill3.DataSource = bs_EnemySkill3;
            bs_EnemySkill4.DataSource = SkillNames;
            comboBox_UnitSkill4.DataSource = bs_EnemySkill4;
            bs_EnemySkill5.DataSource = SkillNames;
            comboBox_UnitSkill5.DataSource = bs_EnemySkill5;
            bs_EnemySkill6.DataSource = SkillNames;
            comboBox_UnitSkill6.DataSource = bs_EnemySkill6;
            bs_EnemySkill7.DataSource = SkillNames;
            comboBox_UnitSkill7.DataSource = bs_EnemySkill7;

            // Item Drops
            bs_ItemDropType0.DataSource = ItemCategories;
            bs_ItemDropType1.DataSource = ItemCategories;
            bs_ItemDropType2.DataSource = ItemCategories;
            bs_ItemDropType3.DataSource = ItemCategories;
            bs_EventItemDropType0.DataSource = ItemCategories;

            comboBox_ItemDropType0.DataSource = bs_ItemDropType0;
            comboBox_ItemDropType1.DataSource = bs_ItemDropType1;
            comboBox_ItemDropType2.DataSource = bs_ItemDropType2;
            comboBox_ItemDropType3.DataSource = bs_ItemDropType3;
            comboBox_EventItemDropType0.DataSource = bs_EventItemDropType0;

            bs_ItemDrop0.DataSource = ItemNames[0];
            bs_ItemDrop1.DataSource = ItemNames[0];
            bs_ItemDrop2.DataSource = ItemNames[0];
            bs_ItemDrop3.DataSource = ItemNames[0];
            bs_EventItemDrop0.DataSource = ItemNames[0];

            comboBox_ItemDrop0.DataSource = bs_ItemDrop0;
            comboBox_ItemDrop1.DataSource = bs_ItemDrop1;
            comboBox_ItemDrop2.DataSource = bs_ItemDrop2;
            comboBox_ItemDrop3.DataSource = bs_ItemDrop3;
            comboBox_EventItemDrop0.DataSource = bs_EventItemDrop0;
        }

        private void ItemType_Changed(object sender, EventArgs e)
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            if (selectedUnit == null)
                return;

            ComboBox comboBox = sender as ComboBox;
            int categoryIndex = comboBox.SelectedIndex;

            if (comboBox.Name.Contains("Event"))
            {
                bs_EventItemDrop0.DataSource = ItemNames[categoryIndex];
                return;
            }

            int itemSlot = Convert.ToInt32(comboBox.Name.Replace("comboBox_ItemDropType", ""));

            switch(itemSlot)
            {
                case 0:
                    bs_ItemDrop0.DataSource = ItemNames[categoryIndex];
                    break;
                case 1:
                    bs_ItemDrop1.DataSource = ItemNames[categoryIndex];
                    break;
                case 2:
                    bs_ItemDrop2.DataSource = ItemNames[categoryIndex];
                    break;
                case 3:
                    bs_ItemDrop3.DataSource = ItemNames[categoryIndex];
                    break;
            }
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
                UpdateUnitItemFields();
                UpdateUnitSkillFields();
            }
        }

        private void UpdateUnitSkillFields()
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            comboBox_UnitSkill0.SelectedIndex = selectedUnit.EnemyStats.Skills[0];
            comboBox_UnitSkill1.SelectedIndex = selectedUnit.EnemyStats.Skills[1];
            comboBox_UnitSkill2.SelectedIndex = selectedUnit.EnemyStats.Skills[2];
            comboBox_UnitSkill3.SelectedIndex = selectedUnit.EnemyStats.Skills[3];
            comboBox_UnitSkill4.SelectedIndex = selectedUnit.EnemyStats.Skills[4];
            comboBox_UnitSkill5.SelectedIndex = selectedUnit.EnemyStats.Skills[5];
            comboBox_UnitSkill6.SelectedIndex = selectedUnit.EnemyStats.Skills[6];
            comboBox_UnitSkill7.SelectedIndex = selectedUnit.EnemyStats.Skills[7];
        }

        private void UpdateUnitItemFields()
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            int categoryIndex = selectedUnit.EnemyStats.ItemDrops[0].ItemID / 0x1000;
            comboBox_ItemDropType0.SelectedIndex = categoryIndex;
            int itemOffset = selectedUnit.EnemyStats.ItemDrops[0].ItemID - (categoryIndex * 0x1000);
            bs_ItemDrop0.DataSource = ItemNames[categoryIndex];
            comboBox_ItemDrop0.SelectedIndex = itemOffset;

            categoryIndex = selectedUnit.EnemyStats.ItemDrops[1].ItemID / 0x1000;
            comboBox_ItemDropType1.SelectedIndex = categoryIndex;
            itemOffset = selectedUnit.EnemyStats.ItemDrops[1].ItemID - (categoryIndex * 0x1000);
            bs_ItemDrop1.DataSource = ItemNames[categoryIndex];
            comboBox_ItemDrop1.SelectedIndex = itemOffset;

            categoryIndex = selectedUnit.EnemyStats.ItemDrops[2].ItemID / 0x1000;
            comboBox_ItemDropType2.SelectedIndex = categoryIndex;
            itemOffset = selectedUnit.EnemyStats.ItemDrops[2].ItemID - (categoryIndex * 0x1000);
            bs_ItemDrop2.DataSource = ItemNames[categoryIndex];
            comboBox_ItemDrop2.SelectedIndex = itemOffset;

            categoryIndex = selectedUnit.EnemyStats.ItemDrops[3].ItemID / 0x1000;
            comboBox_ItemDropType3.SelectedIndex = categoryIndex;
            itemOffset = selectedUnit.EnemyStats.ItemDrops[3].ItemID - (categoryIndex * 0x1000);
            bs_ItemDrop3.DataSource = ItemNames[categoryIndex];
            comboBox_ItemDrop3.SelectedIndex = itemOffset;

            categoryIndex = selectedUnit.EnemyStats.EventItemDrop.ItemID / 0x1000;
            comboBox_EventItemDropType0.SelectedIndex = categoryIndex;
            itemOffset = selectedUnit.EnemyStats.EventItemDrop.ItemID - (categoryIndex * 0x1000);
            bs_EventItemDrop0.DataSource = ItemNames[categoryIndex];
            comboBox_EventItemDrop0.SelectedIndex = itemOffset;
        }

        private void SelectedItem_Changed(object sender, EventArgs e)
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            if (selectedUnit == null)
                return;

            ComboBox comboBox = sender as ComboBox;

            int categoryIndex = -1;

            if (comboBox.Name.Contains("Event"))
            {
                categoryIndex = comboBox_EventItemDropType0.SelectedIndex;
                selectedUnit.EnemyStats.EventItemDrop.ItemID = 
                    Convert.ToUInt16((categoryIndex * 0x1000) + comboBox.SelectedIndex);
                return;
            }

            int itemSlot = Convert.ToInt32(comboBox.Name.Replace("comboBox_ItemDrop", ""));
            
            switch (itemSlot)
            {
                case 0:
                    categoryIndex = comboBox_ItemDropType0.SelectedIndex;
                    break;
                case 1:
                    categoryIndex = comboBox_ItemDropType1.SelectedIndex;
                    break;
                case 2:
                    categoryIndex = comboBox_ItemDropType2.SelectedIndex;
                    break;
                case 3:
                    categoryIndex = comboBox_ItemDropType3.SelectedIndex;
                    break;
            }

            selectedUnit.EnemyStats.ItemDrops[itemSlot].ItemID =
                Convert.ToUInt16((categoryIndex * 0x1000) + comboBox.SelectedIndex);
        }

        private void SelectedSkill_Changed(object sender, EventArgs e)
        {
            var selectedUnit = (EnemyUnit)comboBox_Units.SelectedItem;

            if (selectedUnit == null)
                return;

            ComboBox comboBox = sender as ComboBox;

            int skillSlot = Convert.ToInt32(comboBox.Name.Replace("comboBox_UnitSkill", ""));

            selectedUnit.EnemyStats.Skills[skillSlot] = Convert.ToUInt16(comboBox.SelectedIndex);
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

            txt_UnitNotes.Text = selectedUnit.Comment;
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
