using MetroSet_UI.Forms;
using System;
using static System.ComponentModel.TypeConverter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using System.Reflection;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        private void SetupFormControls()
        {
            // Fetch strings for dropdowns
            GetMusicNameList();
            ApplyUnitNames();
            SetupUnitAffinityForm();

            // Set up dropdowns
            SetEnemyUnitDropdowns();
            SetMusicListDropdown();
            SetUnitComboBoxSources();

            // Set up tab pages
            UpdateEncounterListComboBox();
            UpdateUnitListComboBox();
        }

        private void SetupUnitAffinityForm()
        {
            var affinities = Enum.GetValues(typeof(ElementalAffinityNames)).Cast<ElementalAffinityNames>()
                .Select(e => e.ToString()).ToList();

            var affinityAttributes = Enum.GetValues(typeof(AffinityAttributeNames)).Cast<AffinityAttributeNames>()
                .Select(e => e.ToString()).ToList();

            AnchorStyles anchorStyle = (AnchorStyles.Left | AnchorStyles.Right);

            for (int i = 0; i < affinities.Count; i++)
            {
                tlp_ElementalAffinities.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = 20f });

                Label lbl = new Label { Name = $"lbl_AffinityName_{affinities[i]}", Text = affinities[i], Anchor = anchorStyle };
                tlp_ElementalAffinities.Controls.Add(lbl, 0, i + 1);

                for (int x = 0; x < affinityAttributes.Count; x++)
                {
                    CheckBox chkBox = new CheckBox { Name = $"chk_AffinityAttr_{affinities[i]}_{affinityAttributes[x]}", Anchor = anchorStyle };
                    tlp_ElementalAffinities.Controls.Add(chkBox, x + 1, i + 1);
                }

                NumericUpDown num = new NumericUpDown { Name = $"num_AffinityMultiplier_{affinities[i]}", Minimum = 0, Maximum = 255, Anchor = anchorStyle };
                tlp_ElementalAffinities.Controls.Add(num, 9, i + 1);
            }
        }

        P5RBattleBGMList BattleBGMs = new P5RBattleBGMList();

        public class P5RBattleBGMList
        {
            public List<P5RBattleBGM> P5RBattleBGMs {get;set;} = new List<P5RBattleBGM>();
        }

        public class P5RBattleBGM
        {
            public ushort Id { get; set; } = 0;
            public string SongName { get; set; } = "";
            public string Comment { get; set; } = "";
        }

        private void GetMusicNameList()
        {
            BattleBGMs = LoadJson(typeof(P5RBattleBGMList), "./Dependencies/Json/P5R_BATTLE_BGM.JSON");
        }

        BindingSource bs_battleBgm = new BindingSource();
        private void SetMusicListDropdown()
        {
            bs_battleBgm.DataSource = BattleBGMs.P5RBattleBGMs;
            comboBox_EncounterMusic.FormattingEnabled = true;
            comboBox_EncounterMusic.DisplayMember = "SongName";
            comboBox_EncounterMusic.ValueMember = "Id";
            comboBox_EncounterMusic.DataSource = bs_battleBgm;
        }

        public static List<string> EnemyUnitNames = new List<string>();
        private void GetEnemyUnitNames()
        {
            EnemyUnitNames.Clear();
            var enemiesSectionID = Array.IndexOf(TblNamesR, "Enemies");
            foreach (var entry in project.NameTblData[enemiesSectionID].TblEntries)
                EnemyUnitNames.Add(entry.Name);
        }

        public static List<string> PersonaUnitNames = new List<string>();
        private void GetPersonaUnitNames()
        {
            PersonaUnitNames.Clear();
            var personaSectionID = Array.IndexOf(TblNamesR, "Personas");
            foreach (var entry in project.NameTblData[personaSectionID].TblEntries)
                PersonaUnitNames.Add(entry.Name);
        }

        public static List<string> ArcanaNamess = new List<string>();
        private void GetArcanaNames()
        {
            ArcanaNamess.Clear();
            var arcanaSectionID = Array.IndexOf(TblNamesR, "Arcanas");
            foreach (var entry in project.NameTblData[arcanaSectionID].TblEntries)
                ArcanaNamess.Add(entry.Name);
        }

        public static List<string> SkillNames = new List<string>();
        private void GetSkillNames()
        {
            SkillNames.Clear();
            var skillSectionID = Array.IndexOf(TblNamesR, "Skills");
            foreach (var entry in project.NameTblData[skillSectionID].TblEntries)
                SkillNames.Add(entry.Name);
        }

        public static List<string> ItemCategories = new List<string>() { "Melee Weapons", "Protectors", "Accessories",
                "Consumables", "Key Items", "Materials", "Skill Cards", "Outfits", "Ranged Weapons" };

        public static List<List<string>> ItemNames = new List<List<string>>();
        private void GetItemNames()
        {
            ItemNames.Clear();
            
            foreach(var section in ItemCategories)
            {
                List<string> strings = new List<string>();
                foreach (var entry in project.NameTblData[Array.IndexOf(TblNamesR, section)].TblEntries)
                    strings.Add(entry.Name);
                ItemNames.Add(strings);
            }
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
            
            if (newValue == "[0] Not Used")
                newValue = "";

            e.Value = newValue;
        }

    }
}
