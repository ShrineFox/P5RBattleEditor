using MetroSet_UI.Forms;

namespace P5RBattleEditor
{
    partial class MainForm : MetroSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTBLDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTBLsAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Units = new System.Windows.Forms.TabPage();
            this.panel_Units = new System.Windows.Forms.Panel();
            this.tlp_Units = new System.Windows.Forms.TableLayoutPanel();
            this.txt_UnitSearch = new System.Windows.Forms.TextBox();
            this.comboBox_Units = new System.Windows.Forms.ComboBox();
            this.groupBox_UnitVoiceData = new System.Windows.Forms.GroupBox();
            this.tlp_UnitVoiceData = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_TalkItemRare3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TalkItemRare3 = new System.Windows.Forms.ComboBox();
            this.comboBox_TalkItemRareType3 = new System.Windows.Forms.ComboBox();
            this.tlp_TalkItemRare2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TalkItemRare2 = new System.Windows.Forms.ComboBox();
            this.comboBox_TalkItemRareType2 = new System.Windows.Forms.ComboBox();
            this.tlp_TalkItemRare1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TalkItemRare1 = new System.Windows.Forms.ComboBox();
            this.comboBox_TalkItemRareType1 = new System.Windows.Forms.ComboBox();
            this.tlp_TalkItemRare0 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TalkItemRare0 = new System.Windows.Forms.ComboBox();
            this.comboBox_TalkItemRareType0 = new System.Windows.Forms.ComboBox();
            this.tlp_TalkItem3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TalkItem3 = new System.Windows.Forms.ComboBox();
            this.comboBox_TalkItemType3 = new System.Windows.Forms.ComboBox();
            this.tlp_TalkItem2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TalkItem2 = new System.Windows.Forms.ComboBox();
            this.comboBox_TalkItemType2 = new System.Windows.Forms.ComboBox();
            this.tlp_TalkItem1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TalkItem1 = new System.Windows.Forms.ComboBox();
            this.comboBox_TalkItemType1 = new System.Windows.Forms.ComboBox();
            this.lbl_TalkItems = new System.Windows.Forms.Label();
            this.tlp_UnitTalkMoneyMin = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitTalkMoneyMin = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitTalkMoneyMin = new System.Windows.Forms.Label();
            this.tlp_UnitACBValue = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitACBValue = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitACBValue = new System.Windows.Forms.Label();
            this.tlp_UnitTalkPerson = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitTalkPerson = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitTalkPerson = new System.Windows.Forms.Label();
            this.tlp_UnitVoiceID = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitVoiceID = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitVoiceID = new System.Windows.Forms.Label();
            this.tlp_TalkMoneyMax = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitTalkMoneyMax = new System.Windows.Forms.NumericUpDown();
            this.lbl_TalkMoneyMax = new System.Windows.Forms.Label();
            this.lbl_TalkItemsRare = new System.Windows.Forms.Label();
            this.tlp_TalkItem0 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_TalkItem0 = new System.Windows.Forms.ComboBox();
            this.comboBox_TalkItemType0 = new System.Windows.Forms.ComboBox();
            this.groupBox_UnitName = new System.Windows.Forms.GroupBox();
            this.tlp_UnitName = new System.Windows.Forms.TableLayoutPanel();
            this.txt_UnitNotes = new System.Windows.Forms.TextBox();
            this.lbl_UnitNotes = new System.Windows.Forms.Label();
            this.lbl_PersonaName = new System.Windows.Forms.Label();
            this.txt_PersonaName = new System.Windows.Forms.TextBox();
            this.lbl_ShadowName = new System.Windows.Forms.Label();
            this.txt_ShadowName = new System.Windows.Forms.TextBox();
            this.lbl_UnitArcana = new System.Windows.Forms.Label();
            this.comboBox_UnitArcana = new System.Windows.Forms.ComboBox();
            this.chkListBox_UnitFlags = new System.Windows.Forms.CheckedListBox();
            this.groupBox_UnitBasicStats = new System.Windows.Forms.GroupBox();
            this.tlp_UnitBasicStats = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Luck = new System.Windows.Forms.TableLayoutPanel();
            this.num_Luck = new System.Windows.Forms.NumericUpDown();
            this.lbl_Luck = new System.Windows.Forms.Label();
            this.tlp_UnitID = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitEXP = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitEXP = new System.Windows.Forms.Label();
            this.tlp_Agility = new System.Windows.Forms.TableLayoutPanel();
            this.num_Agility = new System.Windows.Forms.NumericUpDown();
            this.lbl_Agility = new System.Windows.Forms.Label();
            this.tlp_UnitSP = new System.Windows.Forms.TableLayoutPanel();
            this.numUpDwn_UnitSP = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tlp_Endurance = new System.Windows.Forms.TableLayoutPanel();
            this.num_Endurance = new System.Windows.Forms.NumericUpDown();
            this.lbl_Endurance = new System.Windows.Forms.Label();
            this.tlp_UnitHP = new System.Windows.Forms.TableLayoutPanel();
            this.numUpDwn_UnitHP = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tlp_Magic = new System.Windows.Forms.TableLayoutPanel();
            this.num_Magic = new System.Windows.Forms.NumericUpDown();
            this.lbl_Magic = new System.Windows.Forms.Label();
            this.tlp_UnitLevel = new System.Windows.Forms.TableLayoutPanel();
            this.numUpDwn_UnitLevel = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitLevel = new System.Windows.Forms.Label();
            this.tlp_Strength = new System.Windows.Forms.TableLayoutPanel();
            this.num_Strength = new System.Windows.Forms.NumericUpDown();
            this.lbl_Strength = new System.Windows.Forms.Label();
            this.tlp_UnitArcana = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitMoney = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitMoney = new System.Windows.Forms.Label();
            this.groupBox_ItemDrops = new System.Windows.Forms.GroupBox();
            this.tlp_ItemDrops = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Chances = new System.Windows.Forms.Label();
            this.lbl_Items = new System.Windows.Forms.Label();
            this.lbl_ItemTypes = new System.Windows.Forms.Label();
            this.comboBox_ItemDropType3 = new System.Windows.Forms.ComboBox();
            this.comboBox_ItemDrop3 = new System.Windows.Forms.ComboBox();
            this.num_ItemDrop3 = new System.Windows.Forms.NumericUpDown();
            this.num_ItemDrop2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_ItemDrop2 = new System.Windows.Forms.ComboBox();
            this.comboBox_ItemDropType2 = new System.Windows.Forms.ComboBox();
            this.comboBox_ItemDropType1 = new System.Windows.Forms.ComboBox();
            this.comboBox_ItemDrop1 = new System.Windows.Forms.ComboBox();
            this.num_ItemDrop1 = new System.Windows.Forms.NumericUpDown();
            this.num_ItemDrop0 = new System.Windows.Forms.NumericUpDown();
            this.comboBox_ItemDrop0 = new System.Windows.Forms.ComboBox();
            this.comboBox_ItemDropType0 = new System.Windows.Forms.ComboBox();
            this.groupBox_UnitSkills = new System.Windows.Forms.GroupBox();
            this.tlp_UnitSkills = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_UnitSkill1 = new System.Windows.Forms.ComboBox();
            this.comboBox_UnitSkill0 = new System.Windows.Forms.ComboBox();
            this.comboBox_UnitSkill6 = new System.Windows.Forms.ComboBox();
            this.comboBox_UnitSkill7 = new System.Windows.Forms.ComboBox();
            this.comboBox_UnitSkill5 = new System.Windows.Forms.ComboBox();
            this.comboBox_UnitSkill4 = new System.Windows.Forms.ComboBox();
            this.comboBox_UnitSkill2 = new System.Windows.Forms.ComboBox();
            this.comboBox_UnitSkill3 = new System.Windows.Forms.ComboBox();
            this.groupBox_UnitAttackStats = new System.Windows.Forms.GroupBox();
            this.tlp_UnitAttackStats = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitAttackAccuracy = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitAttackDamage = new System.Windows.Forms.Label();
            this.lbl_Accuracy = new System.Windows.Forms.Label();
            this.num_UnitAttackDamage = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitAttackType = new System.Windows.Forms.Label();
            this.comboBox_UnitAttackType = new System.Windows.Forms.ComboBox();
            this.groupBox_UnitVisualData = new System.Windows.Forms.GroupBox();
            this.tlp_UnitVisualData = new System.Windows.Forms.TableLayoutPanel();
            this.num_UnitPersonaID = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitPersonaID = new System.Windows.Forms.Label();
            this.num_UnitModelID = new System.Windows.Forms.NumericUpDown();
            this.lbl_UnitVisualUnknownR = new System.Windows.Forms.Label();
            this.lbl_UnitModelID = new System.Windows.Forms.Label();
            this.num_UnitVisualUnknownR = new System.Windows.Forms.NumericUpDown();
            this.groupBox_EventItemDrops = new System.Windows.Forms.GroupBox();
            this.tlp_EventItemDrops = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.num_EventItemFlag0 = new System.Windows.Forms.NumericUpDown();
            this.lbl_EventID = new System.Windows.Forms.Label();
            this.lbl_Chance = new System.Windows.Forms.Label();
            this.num_EventItemDrop0 = new System.Windows.Forms.NumericUpDown();
            this.lbl_EventItem = new System.Windows.Forms.Label();
            this.comboBox_EventItemDrop0 = new System.Windows.Forms.ComboBox();
            this.comboBox_EventItemDropType0 = new System.Windows.Forms.ComboBox();
            this.groupBox_UnitElementalAffinities = new System.Windows.Forms.GroupBox();
            this.pnl_ElementalAffinities = new System.Windows.Forms.Panel();
            this.tlp_ElementalAffinities = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Multiplier = new System.Windows.Forms.Label();
            this.lbl_Block = new System.Windows.Forms.Label();
            this.lbl_Repel = new System.Windows.Forms.Label();
            this.lbl_Drain = new System.Windows.Forms.Label();
            this.lbl_Weak = new System.Windows.Forms.Label();
            this.lbl_x2Ailment = new System.Windows.Forms.Label();
            this.lbl_GuaranteeAilment = new System.Windows.Forms.Label();
            this.lbl_AilmentImmune = new System.Windows.Forms.Label();
            this.lbl_Resist = new System.Windows.Forms.Label();
            this.tabPage_Encounters = new System.Windows.Forms.TabPage();
            this.tlp_Encounters = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_Encounters = new System.Windows.Forms.ComboBox();
            this.txt_EncounterSearch = new System.Windows.Forms.TextBox();
            this.chkListBox_EncounterFlags = new System.Windows.Forms.CheckedListBox();
            this.tlp_EncounterProperties = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_EncounterEtc = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_EncounterNotes = new System.Windows.Forms.GroupBox();
            this.txt_EncounterNotes = new System.Windows.Forms.TextBox();
            this.groupBox_FieldData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_EncounterMusic = new System.Windows.Forms.GroupBox();
            this.comboBox_EncounterMusic = new System.Windows.Forms.ComboBox();
            this.groupBox_FieldIDMajor = new System.Windows.Forms.GroupBox();
            this.numUpDwn_FieldIDMinor = new System.Windows.Forms.NumericUpDown();
            this.groupBox_FieldIDMinor = new System.Windows.Forms.GroupBox();
            this.numUpDwn_FieldIDMajor = new System.Windows.Forms.NumericUpDown();
            this.groupBox_BattleUnits = new System.Windows.Forms.GroupBox();
            this.tlp_EncounterBattleUnits = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_BattleUnit4 = new System.Windows.Forms.ComboBox();
            this.comboBox_BattleUnit3 = new System.Windows.Forms.ComboBox();
            this.comboBox_BattleUnit2 = new System.Windows.Forms.ComboBox();
            this.comboBox_BattleUnit1 = new System.Windows.Forms.ComboBox();
            this.comboBox_BattleUnit0 = new System.Windows.Forms.ComboBox();
            this.tabPage_Skills = new System.Windows.Forms.TabPage();
            this.menuStrip_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Units.SuspendLayout();
            this.panel_Units.SuspendLayout();
            this.tlp_Units.SuspendLayout();
            this.groupBox_UnitVoiceData.SuspendLayout();
            this.tlp_UnitVoiceData.SuspendLayout();
            this.tlp_TalkItemRare3.SuspendLayout();
            this.tlp_TalkItemRare2.SuspendLayout();
            this.tlp_TalkItemRare1.SuspendLayout();
            this.tlp_TalkItemRare0.SuspendLayout();
            this.tlp_TalkItem3.SuspendLayout();
            this.tlp_TalkItem2.SuspendLayout();
            this.tlp_TalkItem1.SuspendLayout();
            this.tlp_UnitTalkMoneyMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitTalkMoneyMin)).BeginInit();
            this.tlp_UnitACBValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitACBValue)).BeginInit();
            this.tlp_UnitTalkPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitTalkPerson)).BeginInit();
            this.tlp_UnitVoiceID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitVoiceID)).BeginInit();
            this.tlp_TalkMoneyMax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitTalkMoneyMax)).BeginInit();
            this.tlp_TalkItem0.SuspendLayout();
            this.groupBox_UnitName.SuspendLayout();
            this.tlp_UnitName.SuspendLayout();
            this.groupBox_UnitBasicStats.SuspendLayout();
            this.tlp_UnitBasicStats.SuspendLayout();
            this.tlp_Luck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Luck)).BeginInit();
            this.tlp_UnitID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitEXP)).BeginInit();
            this.tlp_Agility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Agility)).BeginInit();
            this.tlp_UnitSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_UnitSP)).BeginInit();
            this.tlp_Endurance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Endurance)).BeginInit();
            this.tlp_UnitHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_UnitHP)).BeginInit();
            this.tlp_Magic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Magic)).BeginInit();
            this.tlp_UnitLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_UnitLevel)).BeginInit();
            this.tlp_Strength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Strength)).BeginInit();
            this.tlp_UnitArcana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitMoney)).BeginInit();
            this.groupBox_ItemDrops.SuspendLayout();
            this.tlp_ItemDrops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemDrop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemDrop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemDrop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemDrop0)).BeginInit();
            this.groupBox_UnitSkills.SuspendLayout();
            this.tlp_UnitSkills.SuspendLayout();
            this.groupBox_UnitAttackStats.SuspendLayout();
            this.tlp_UnitAttackStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitAttackAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitAttackDamage)).BeginInit();
            this.groupBox_UnitVisualData.SuspendLayout();
            this.tlp_UnitVisualData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitPersonaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitModelID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitVisualUnknownR)).BeginInit();
            this.groupBox_EventItemDrops.SuspendLayout();
            this.tlp_EventItemDrops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EventItemFlag0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EventItemDrop0)).BeginInit();
            this.groupBox_UnitElementalAffinities.SuspendLayout();
            this.pnl_ElementalAffinities.SuspendLayout();
            this.tlp_ElementalAffinities.SuspendLayout();
            this.tabPage_Encounters.SuspendLayout();
            this.tlp_Encounters.SuspendLayout();
            this.tlp_EncounterProperties.SuspendLayout();
            this.groupBox_EncounterEtc.SuspendLayout();
            this.groupBox_EncounterNotes.SuspendLayout();
            this.groupBox_FieldData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_EncounterMusic.SuspendLayout();
            this.groupBox_FieldIDMajor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_FieldIDMinor)).BeginInit();
            this.groupBox_FieldIDMinor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_FieldIDMajor)).BeginInit();
            this.groupBox_BattleUnits.SuspendLayout();
            this.tlp_EncounterBattleUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(2, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip_Main.Size = new System.Drawing.Size(803, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.importTBLDataToolStripMenuItem,
            this.exportTBLsAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProject_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.LoadProject_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // importTBLDataToolStripMenuItem
            // 
            this.importTBLDataToolStripMenuItem.Name = "importTBLDataToolStripMenuItem";
            this.importTBLDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importTBLDataToolStripMenuItem.Text = "Import TBL Data";
            this.importTBLDataToolStripMenuItem.Click += new System.EventHandler(this.ImportTBLData_Click);
            // 
            // exportTBLsAsToolStripMenuItem
            // 
            this.exportTBLsAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBLToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.exportTBLsAsToolStripMenuItem.Name = "exportTBLsAsToolStripMenuItem";
            this.exportTBLsAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportTBLsAsToolStripMenuItem.Text = "Export TBLs As...";
            // 
            // tBLToolStripMenuItem
            // 
            this.tBLToolStripMenuItem.Name = "tBLToolStripMenuItem";
            this.tBLToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.tBLToolStripMenuItem.Text = "TBL";
            this.tBLToolStripMenuItem.Click += new System.EventHandler(this.ExportTBLs_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.ExportJSONs_Click);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tabControl_Main.AnimateTime = 200;
            this.tabControl_Main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabControl_Main.Controls.Add(this.tabPage_Units);
            this.tabControl_Main.Controls.Add(this.tabPage_Encounters);
            this.tabControl_Main.Controls.Add(this.tabPage_Skills);
            this.tabControl_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.IsDerivedStyle = true;
            this.tabControl_Main.ItemSize = new System.Drawing.Size(100, 38);
            this.tabControl_Main.Location = new System.Drawing.Point(2, 24);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.SelectedTextColor = System.Drawing.Color.White;
            this.tabControl_Main.Size = new System.Drawing.Size(803, 527);
            this.tabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Main.Speed = 100;
            this.tabControl_Main.Style = MetroSet_UI.Enums.Style.Dark;
            this.tabControl_Main.StyleManager = null;
            this.tabControl_Main.TabIndex = 1;
            this.tabControl_Main.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.tabControl_Main.ThemeAuthor = "Narwin";
            this.tabControl_Main.ThemeName = "MetroDark";
            this.tabControl_Main.UnselectedTextColor = System.Drawing.Color.Gray;
            this.tabControl_Main.UseAnimation = false;
            // 
            // tabPage_Units
            // 
            this.tabPage_Units.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_Units.Controls.Add(this.panel_Units);
            this.tabPage_Units.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Units.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Units.Name = "tabPage_Units";
            this.tabPage_Units.Size = new System.Drawing.Size(795, 481);
            this.tabPage_Units.TabIndex = 1;
            this.tabPage_Units.Text = "Units";
            // 
            // panel_Units
            // 
            this.panel_Units.AutoScroll = true;
            this.panel_Units.Controls.Add(this.tlp_Units);
            this.panel_Units.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Units.Location = new System.Drawing.Point(0, 0);
            this.panel_Units.Name = "panel_Units";
            this.panel_Units.Size = new System.Drawing.Size(795, 481);
            this.panel_Units.TabIndex = 2;
            // 
            // tlp_Units
            // 
            this.tlp_Units.AutoSize = true;
            this.tlp_Units.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Units.ColumnCount = 3;
            this.tlp_Units.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Units.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Units.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Units.Controls.Add(this.txt_UnitSearch, 2, 0);
            this.tlp_Units.Controls.Add(this.comboBox_Units, 0, 0);
            this.tlp_Units.Controls.Add(this.groupBox_UnitVoiceData, 0, 5);
            this.tlp_Units.Controls.Add(this.groupBox_UnitName, 0, 1);
            this.tlp_Units.Controls.Add(this.chkListBox_UnitFlags, 2, 2);
            this.tlp_Units.Controls.Add(this.groupBox_UnitBasicStats, 1, 1);
            this.tlp_Units.Controls.Add(this.groupBox_ItemDrops, 0, 4);
            this.tlp_Units.Controls.Add(this.groupBox_UnitSkills, 0, 3);
            this.tlp_Units.Controls.Add(this.groupBox_UnitAttackStats, 1, 2);
            this.tlp_Units.Controls.Add(this.groupBox_UnitVisualData, 0, 2);
            this.tlp_Units.Controls.Add(this.groupBox_EventItemDrops, 2, 3);
            this.tlp_Units.Controls.Add(this.groupBox_UnitElementalAffinities, 0, 6);
            this.tlp_Units.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_Units.Location = new System.Drawing.Point(0, 0);
            this.tlp_Units.Name = "tlp_Units";
            this.tlp_Units.RowCount = 7;
            this.tlp_Units.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlp_Units.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Units.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Units.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Units.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Units.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp_Units.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tlp_Units.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Units.Size = new System.Drawing.Size(774, 1475);
            this.tlp_Units.TabIndex = 1;
            // 
            // txt_UnitSearch
            // 
            this.txt_UnitSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UnitSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_UnitSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UnitSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txt_UnitSearch.ForeColor = System.Drawing.Color.Silver;
            this.txt_UnitSearch.Location = new System.Drawing.Point(516, 26);
            this.txt_UnitSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txt_UnitSearch.Name = "txt_UnitSearch";
            this.txt_UnitSearch.Size = new System.Drawing.Size(258, 23);
            this.txt_UnitSearch.TabIndex = 13;
            this.txt_UnitSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitSearch_KeyDown);
            // 
            // comboBox_Units
            // 
            this.comboBox_Units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Units.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tlp_Units.SetColumnSpan(this.comboBox_Units, 2);
            this.comboBox_Units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_Units.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_Units.FormattingEnabled = true;
            this.comboBox_Units.Location = new System.Drawing.Point(3, 25);
            this.comboBox_Units.Name = "comboBox_Units";
            this.comboBox_Units.Size = new System.Drawing.Size(510, 24);
            this.comboBox_Units.TabIndex = 12;
            this.comboBox_Units.SelectedIndexChanged += new System.EventHandler(this.UnitList_SelectedIndexChanged);
            // 
            // groupBox_UnitVoiceData
            // 
            this.tlp_Units.SetColumnSpan(this.groupBox_UnitVoiceData, 3);
            this.groupBox_UnitVoiceData.Controls.Add(this.tlp_UnitVoiceData);
            this.groupBox_UnitVoiceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_UnitVoiceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_UnitVoiceData.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_UnitVoiceData.Location = new System.Drawing.Point(3, 878);
            this.groupBox_UnitVoiceData.Name = "groupBox_UnitVoiceData";
            this.groupBox_UnitVoiceData.Size = new System.Drawing.Size(768, 194);
            this.groupBox_UnitVoiceData.TabIndex = 9;
            this.groupBox_UnitVoiceData.TabStop = false;
            this.groupBox_UnitVoiceData.Text = "Voice Data";
            // 
            // tlp_UnitVoiceData
            // 
            this.tlp_UnitVoiceData.ColumnCount = 5;
            this.tlp_UnitVoiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.61452F));
            this.tlp_UnitVoiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.34637F));
            this.tlp_UnitVoiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.34637F));
            this.tlp_UnitVoiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.34637F));
            this.tlp_UnitVoiceData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.34637F));
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkItemRare3, 4, 2);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkItemRare2, 3, 2);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkItemRare1, 2, 2);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkItemRare0, 1, 2);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkItem3, 4, 1);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkItem2, 3, 1);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkItem1, 2, 1);
            this.tlp_UnitVoiceData.Controls.Add(this.lbl_TalkItems, 0, 1);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_UnitTalkMoneyMin, 3, 0);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_UnitACBValue, 2, 0);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_UnitTalkPerson, 1, 0);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_UnitVoiceID, 0, 0);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkMoneyMax, 4, 0);
            this.tlp_UnitVoiceData.Controls.Add(this.lbl_TalkItemsRare, 0, 2);
            this.tlp_UnitVoiceData.Controls.Add(this.tlp_TalkItem0, 1, 1);
            this.tlp_UnitVoiceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitVoiceData.Location = new System.Drawing.Point(3, 19);
            this.tlp_UnitVoiceData.Name = "tlp_UnitVoiceData";
            this.tlp_UnitVoiceData.RowCount = 3;
            this.tlp_UnitVoiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_UnitVoiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_UnitVoiceData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_UnitVoiceData.Size = new System.Drawing.Size(762, 172);
            this.tlp_UnitVoiceData.TabIndex = 0;
            // 
            // tlp_TalkItemRare3
            // 
            this.tlp_TalkItemRare3.ColumnCount = 1;
            this.tlp_TalkItemRare3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare3.Controls.Add(this.comboBox_TalkItemRare3, 0, 1);
            this.tlp_TalkItemRare3.Controls.Add(this.comboBox_TalkItemRareType3, 0, 0);
            this.tlp_TalkItemRare3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkItemRare3.Location = new System.Drawing.Point(593, 114);
            this.tlp_TalkItemRare3.Name = "tlp_TalkItemRare3";
            this.tlp_TalkItemRare3.RowCount = 2;
            this.tlp_TalkItemRare3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare3.Size = new System.Drawing.Size(166, 55);
            this.tlp_TalkItemRare3.TabIndex = 20;
            // 
            // comboBox_TalkItemRare3
            // 
            this.comboBox_TalkItemRare3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemRare3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemRare3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemRare3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemRare3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemRare3.FormattingEnabled = true;
            this.comboBox_TalkItemRare3.Location = new System.Drawing.Point(3, 30);
            this.comboBox_TalkItemRare3.Name = "comboBox_TalkItemRare3";
            this.comboBox_TalkItemRare3.Size = new System.Drawing.Size(160, 24);
            this.comboBox_TalkItemRare3.TabIndex = 12;
            this.comboBox_TalkItemRare3.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_TalkItemRareType3
            // 
            this.comboBox_TalkItemRareType3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemRareType3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemRareType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemRareType3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemRareType3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemRareType3.FormattingEnabled = true;
            this.comboBox_TalkItemRareType3.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TalkItemRareType3.Name = "comboBox_TalkItemRareType3";
            this.comboBox_TalkItemRareType3.Size = new System.Drawing.Size(160, 24);
            this.comboBox_TalkItemRareType3.TabIndex = 11;
            this.comboBox_TalkItemRareType3.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // tlp_TalkItemRare2
            // 
            this.tlp_TalkItemRare2.ColumnCount = 1;
            this.tlp_TalkItemRare2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare2.Controls.Add(this.comboBox_TalkItemRare2, 0, 1);
            this.tlp_TalkItemRare2.Controls.Add(this.comboBox_TalkItemRareType2, 0, 0);
            this.tlp_TalkItemRare2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkItemRare2.Location = new System.Drawing.Point(423, 114);
            this.tlp_TalkItemRare2.Name = "tlp_TalkItemRare2";
            this.tlp_TalkItemRare2.RowCount = 2;
            this.tlp_TalkItemRare2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare2.Size = new System.Drawing.Size(164, 55);
            this.tlp_TalkItemRare2.TabIndex = 19;
            // 
            // comboBox_TalkItemRare2
            // 
            this.comboBox_TalkItemRare2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemRare2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemRare2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemRare2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemRare2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemRare2.FormattingEnabled = true;
            this.comboBox_TalkItemRare2.Location = new System.Drawing.Point(3, 30);
            this.comboBox_TalkItemRare2.Name = "comboBox_TalkItemRare2";
            this.comboBox_TalkItemRare2.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemRare2.TabIndex = 12;
            this.comboBox_TalkItemRare2.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_TalkItemRareType2
            // 
            this.comboBox_TalkItemRareType2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemRareType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemRareType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemRareType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemRareType2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemRareType2.FormattingEnabled = true;
            this.comboBox_TalkItemRareType2.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TalkItemRareType2.Name = "comboBox_TalkItemRareType2";
            this.comboBox_TalkItemRareType2.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemRareType2.TabIndex = 11;
            this.comboBox_TalkItemRareType2.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // tlp_TalkItemRare1
            // 
            this.tlp_TalkItemRare1.ColumnCount = 1;
            this.tlp_TalkItemRare1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare1.Controls.Add(this.comboBox_TalkItemRare1, 0, 1);
            this.tlp_TalkItemRare1.Controls.Add(this.comboBox_TalkItemRareType1, 0, 0);
            this.tlp_TalkItemRare1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkItemRare1.Location = new System.Drawing.Point(253, 114);
            this.tlp_TalkItemRare1.Name = "tlp_TalkItemRare1";
            this.tlp_TalkItemRare1.RowCount = 2;
            this.tlp_TalkItemRare1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare1.Size = new System.Drawing.Size(164, 55);
            this.tlp_TalkItemRare1.TabIndex = 18;
            // 
            // comboBox_TalkItemRare1
            // 
            this.comboBox_TalkItemRare1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemRare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemRare1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemRare1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemRare1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemRare1.FormattingEnabled = true;
            this.comboBox_TalkItemRare1.Location = new System.Drawing.Point(3, 30);
            this.comboBox_TalkItemRare1.Name = "comboBox_TalkItemRare1";
            this.comboBox_TalkItemRare1.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemRare1.TabIndex = 12;
            this.comboBox_TalkItemRare1.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_TalkItemRareType1
            // 
            this.comboBox_TalkItemRareType1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemRareType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemRareType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemRareType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemRareType1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemRareType1.FormattingEnabled = true;
            this.comboBox_TalkItemRareType1.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TalkItemRareType1.Name = "comboBox_TalkItemRareType1";
            this.comboBox_TalkItemRareType1.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemRareType1.TabIndex = 11;
            this.comboBox_TalkItemRareType1.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // tlp_TalkItemRare0
            // 
            this.tlp_TalkItemRare0.ColumnCount = 1;
            this.tlp_TalkItemRare0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare0.Controls.Add(this.comboBox_TalkItemRare0, 0, 1);
            this.tlp_TalkItemRare0.Controls.Add(this.comboBox_TalkItemRareType0, 0, 0);
            this.tlp_TalkItemRare0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkItemRare0.Location = new System.Drawing.Point(83, 114);
            this.tlp_TalkItemRare0.Name = "tlp_TalkItemRare0";
            this.tlp_TalkItemRare0.RowCount = 2;
            this.tlp_TalkItemRare0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItemRare0.Size = new System.Drawing.Size(164, 55);
            this.tlp_TalkItemRare0.TabIndex = 17;
            // 
            // comboBox_TalkItemRare0
            // 
            this.comboBox_TalkItemRare0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemRare0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemRare0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemRare0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemRare0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemRare0.FormattingEnabled = true;
            this.comboBox_TalkItemRare0.Location = new System.Drawing.Point(3, 30);
            this.comboBox_TalkItemRare0.Name = "comboBox_TalkItemRare0";
            this.comboBox_TalkItemRare0.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemRare0.TabIndex = 12;
            this.comboBox_TalkItemRare0.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_TalkItemRareType0
            // 
            this.comboBox_TalkItemRareType0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemRareType0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemRareType0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemRareType0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemRareType0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemRareType0.FormattingEnabled = true;
            this.comboBox_TalkItemRareType0.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TalkItemRareType0.Name = "comboBox_TalkItemRareType0";
            this.comboBox_TalkItemRareType0.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemRareType0.TabIndex = 11;
            this.comboBox_TalkItemRareType0.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // tlp_TalkItem3
            // 
            this.tlp_TalkItem3.ColumnCount = 1;
            this.tlp_TalkItem3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem3.Controls.Add(this.comboBox_TalkItem3, 0, 1);
            this.tlp_TalkItem3.Controls.Add(this.comboBox_TalkItemType3, 0, 0);
            this.tlp_TalkItem3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkItem3.Location = new System.Drawing.Point(593, 54);
            this.tlp_TalkItem3.Name = "tlp_TalkItem3";
            this.tlp_TalkItem3.RowCount = 2;
            this.tlp_TalkItem3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem3.Size = new System.Drawing.Size(166, 54);
            this.tlp_TalkItem3.TabIndex = 16;
            // 
            // comboBox_TalkItem3
            // 
            this.comboBox_TalkItem3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItem3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItem3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItem3.FormattingEnabled = true;
            this.comboBox_TalkItem3.Location = new System.Drawing.Point(3, 30);
            this.comboBox_TalkItem3.Name = "comboBox_TalkItem3";
            this.comboBox_TalkItem3.Size = new System.Drawing.Size(160, 24);
            this.comboBox_TalkItem3.TabIndex = 12;
            this.comboBox_TalkItem3.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_TalkItemType3
            // 
            this.comboBox_TalkItemType3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemType3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemType3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemType3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemType3.FormattingEnabled = true;
            this.comboBox_TalkItemType3.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TalkItemType3.Name = "comboBox_TalkItemType3";
            this.comboBox_TalkItemType3.Size = new System.Drawing.Size(160, 24);
            this.comboBox_TalkItemType3.TabIndex = 11;
            this.comboBox_TalkItemType3.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // tlp_TalkItem2
            // 
            this.tlp_TalkItem2.ColumnCount = 1;
            this.tlp_TalkItem2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem2.Controls.Add(this.comboBox_TalkItem2, 0, 1);
            this.tlp_TalkItem2.Controls.Add(this.comboBox_TalkItemType2, 0, 0);
            this.tlp_TalkItem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkItem2.Location = new System.Drawing.Point(423, 54);
            this.tlp_TalkItem2.Name = "tlp_TalkItem2";
            this.tlp_TalkItem2.RowCount = 2;
            this.tlp_TalkItem2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem2.Size = new System.Drawing.Size(164, 54);
            this.tlp_TalkItem2.TabIndex = 15;
            // 
            // comboBox_TalkItem2
            // 
            this.comboBox_TalkItem2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItem2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItem2.FormattingEnabled = true;
            this.comboBox_TalkItem2.Location = new System.Drawing.Point(3, 30);
            this.comboBox_TalkItem2.Name = "comboBox_TalkItem2";
            this.comboBox_TalkItem2.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItem2.TabIndex = 12;
            // 
            // comboBox_TalkItemType2
            // 
            this.comboBox_TalkItemType2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemType2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemType2.FormattingEnabled = true;
            this.comboBox_TalkItemType2.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TalkItemType2.Name = "comboBox_TalkItemType2";
            this.comboBox_TalkItemType2.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemType2.TabIndex = 11;
            this.comboBox_TalkItemType2.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // tlp_TalkItem1
            // 
            this.tlp_TalkItem1.ColumnCount = 1;
            this.tlp_TalkItem1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem1.Controls.Add(this.comboBox_TalkItem1, 0, 1);
            this.tlp_TalkItem1.Controls.Add(this.comboBox_TalkItemType1, 0, 0);
            this.tlp_TalkItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkItem1.Location = new System.Drawing.Point(253, 54);
            this.tlp_TalkItem1.Name = "tlp_TalkItem1";
            this.tlp_TalkItem1.RowCount = 2;
            this.tlp_TalkItem1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem1.Size = new System.Drawing.Size(164, 54);
            this.tlp_TalkItem1.TabIndex = 14;
            // 
            // comboBox_TalkItem1
            // 
            this.comboBox_TalkItem1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItem1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItem1.FormattingEnabled = true;
            this.comboBox_TalkItem1.Location = new System.Drawing.Point(3, 30);
            this.comboBox_TalkItem1.Name = "comboBox_TalkItem1";
            this.comboBox_TalkItem1.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItem1.TabIndex = 12;
            this.comboBox_TalkItem1.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_TalkItemType1
            // 
            this.comboBox_TalkItemType1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemType1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemType1.FormattingEnabled = true;
            this.comboBox_TalkItemType1.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TalkItemType1.Name = "comboBox_TalkItemType1";
            this.comboBox_TalkItemType1.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemType1.TabIndex = 11;
            this.comboBox_TalkItemType1.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // lbl_TalkItems
            // 
            this.lbl_TalkItems.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_TalkItems.AutoSize = true;
            this.lbl_TalkItems.Location = new System.Drawing.Point(32, 64);
            this.lbl_TalkItems.Name = "lbl_TalkItems";
            this.lbl_TalkItems.Size = new System.Drawing.Size(45, 34);
            this.lbl_TalkItems.TabIndex = 11;
            this.lbl_TalkItems.Text = "Talk Items:";
            // 
            // tlp_UnitTalkMoneyMin
            // 
            this.tlp_UnitTalkMoneyMin.ColumnCount = 1;
            this.tlp_UnitTalkMoneyMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitTalkMoneyMin.Controls.Add(this.num_UnitTalkMoneyMin, 0, 1);
            this.tlp_UnitTalkMoneyMin.Controls.Add(this.lbl_UnitTalkMoneyMin, 0, 0);
            this.tlp_UnitTalkMoneyMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitTalkMoneyMin.Location = new System.Drawing.Point(423, 3);
            this.tlp_UnitTalkMoneyMin.Name = "tlp_UnitTalkMoneyMin";
            this.tlp_UnitTalkMoneyMin.RowCount = 2;
            this.tlp_UnitTalkMoneyMin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitTalkMoneyMin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitTalkMoneyMin.Size = new System.Drawing.Size(164, 45);
            this.tlp_UnitTalkMoneyMin.TabIndex = 9;
            // 
            // num_UnitTalkMoneyMin
            // 
            this.num_UnitTalkMoneyMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitTalkMoneyMin.AutoSize = true;
            this.num_UnitTalkMoneyMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitTalkMoneyMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitTalkMoneyMin.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitTalkMoneyMin.Location = new System.Drawing.Point(3, 25);
            this.num_UnitTalkMoneyMin.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_UnitTalkMoneyMin.Name = "num_UnitTalkMoneyMin";
            this.num_UnitTalkMoneyMin.Size = new System.Drawing.Size(158, 23);
            this.num_UnitTalkMoneyMin.TabIndex = 5;
            this.num_UnitTalkMoneyMin.ValueChanged += new System.EventHandler(this.TalkMoneyMin_Changed);
            // 
            // lbl_UnitTalkMoneyMin
            // 
            this.lbl_UnitTalkMoneyMin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_UnitTalkMoneyMin.AutoSize = true;
            this.lbl_UnitTalkMoneyMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_UnitTalkMoneyMin.Location = new System.Drawing.Point(21, 5);
            this.lbl_UnitTalkMoneyMin.Name = "lbl_UnitTalkMoneyMin";
            this.lbl_UnitTalkMoneyMin.Size = new System.Drawing.Size(121, 17);
            this.lbl_UnitTalkMoneyMin.TabIndex = 4;
            this.lbl_UnitTalkMoneyMin.Text = "Talk Money (Min):";
            // 
            // tlp_UnitACBValue
            // 
            this.tlp_UnitACBValue.ColumnCount = 1;
            this.tlp_UnitACBValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitACBValue.Controls.Add(this.num_UnitACBValue, 0, 1);
            this.tlp_UnitACBValue.Controls.Add(this.lbl_UnitACBValue, 0, 0);
            this.tlp_UnitACBValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitACBValue.Location = new System.Drawing.Point(253, 3);
            this.tlp_UnitACBValue.Name = "tlp_UnitACBValue";
            this.tlp_UnitACBValue.RowCount = 2;
            this.tlp_UnitACBValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitACBValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitACBValue.Size = new System.Drawing.Size(164, 45);
            this.tlp_UnitACBValue.TabIndex = 8;
            // 
            // num_UnitACBValue
            // 
            this.num_UnitACBValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitACBValue.AutoSize = true;
            this.num_UnitACBValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitACBValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitACBValue.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitACBValue.Location = new System.Drawing.Point(3, 25);
            this.num_UnitACBValue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_UnitACBValue.Name = "num_UnitACBValue";
            this.num_UnitACBValue.Size = new System.Drawing.Size(158, 23);
            this.num_UnitACBValue.TabIndex = 5;
            this.num_UnitACBValue.ValueChanged += new System.EventHandler(this.ACBValue_Changed);
            // 
            // lbl_UnitACBValue
            // 
            this.lbl_UnitACBValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_UnitACBValue.AutoSize = true;
            this.lbl_UnitACBValue.Location = new System.Drawing.Point(42, 5);
            this.lbl_UnitACBValue.Name = "lbl_UnitACBValue";
            this.lbl_UnitACBValue.Size = new System.Drawing.Size(79, 17);
            this.lbl_UnitACBValue.TabIndex = 4;
            this.lbl_UnitACBValue.Text = "ACB Value:";
            // 
            // tlp_UnitTalkPerson
            // 
            this.tlp_UnitTalkPerson.ColumnCount = 1;
            this.tlp_UnitTalkPerson.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitTalkPerson.Controls.Add(this.num_UnitTalkPerson, 0, 1);
            this.tlp_UnitTalkPerson.Controls.Add(this.lbl_UnitTalkPerson, 0, 0);
            this.tlp_UnitTalkPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitTalkPerson.Location = new System.Drawing.Point(83, 3);
            this.tlp_UnitTalkPerson.Name = "tlp_UnitTalkPerson";
            this.tlp_UnitTalkPerson.RowCount = 2;
            this.tlp_UnitTalkPerson.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitTalkPerson.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitTalkPerson.Size = new System.Drawing.Size(164, 45);
            this.tlp_UnitTalkPerson.TabIndex = 7;
            // 
            // num_UnitTalkPerson
            // 
            this.num_UnitTalkPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitTalkPerson.AutoSize = true;
            this.num_UnitTalkPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitTalkPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitTalkPerson.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitTalkPerson.Location = new System.Drawing.Point(3, 25);
            this.num_UnitTalkPerson.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_UnitTalkPerson.Name = "num_UnitTalkPerson";
            this.num_UnitTalkPerson.Size = new System.Drawing.Size(158, 23);
            this.num_UnitTalkPerson.TabIndex = 5;
            this.num_UnitTalkPerson.ValueChanged += new System.EventHandler(this.TALKPERSON_Changed);
            // 
            // lbl_UnitTalkPerson
            // 
            this.lbl_UnitTalkPerson.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_UnitTalkPerson.AutoSize = true;
            this.lbl_UnitTalkPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_UnitTalkPerson.Location = new System.Drawing.Point(33, 7);
            this.lbl_UnitTalkPerson.Name = "lbl_UnitTalkPerson";
            this.lbl_UnitTalkPerson.Size = new System.Drawing.Size(97, 15);
            this.lbl_UnitTalkPerson.TabIndex = 4;
            this.lbl_UnitTalkPerson.Text = "TALK_PERSON:";
            // 
            // tlp_UnitVoiceID
            // 
            this.tlp_UnitVoiceID.ColumnCount = 1;
            this.tlp_UnitVoiceID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitVoiceID.Controls.Add(this.num_UnitVoiceID, 0, 1);
            this.tlp_UnitVoiceID.Controls.Add(this.lbl_UnitVoiceID, 0, 0);
            this.tlp_UnitVoiceID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitVoiceID.Location = new System.Drawing.Point(3, 3);
            this.tlp_UnitVoiceID.Name = "tlp_UnitVoiceID";
            this.tlp_UnitVoiceID.RowCount = 2;
            this.tlp_UnitVoiceID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitVoiceID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitVoiceID.Size = new System.Drawing.Size(74, 45);
            this.tlp_UnitVoiceID.TabIndex = 6;
            // 
            // num_UnitVoiceID
            // 
            this.num_UnitVoiceID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitVoiceID.AutoSize = true;
            this.num_UnitVoiceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitVoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitVoiceID.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitVoiceID.Location = new System.Drawing.Point(3, 25);
            this.num_UnitVoiceID.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_UnitVoiceID.Name = "num_UnitVoiceID";
            this.num_UnitVoiceID.Size = new System.Drawing.Size(68, 23);
            this.num_UnitVoiceID.TabIndex = 5;
            this.num_UnitVoiceID.ValueChanged += new System.EventHandler(this.VoiceID_Changed);
            // 
            // lbl_UnitVoiceID
            // 
            this.lbl_UnitVoiceID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_UnitVoiceID.AutoSize = true;
            this.lbl_UnitVoiceID.Location = new System.Drawing.Point(5, 5);
            this.lbl_UnitVoiceID.Name = "lbl_UnitVoiceID";
            this.lbl_UnitVoiceID.Size = new System.Drawing.Size(64, 17);
            this.lbl_UnitVoiceID.TabIndex = 4;
            this.lbl_UnitVoiceID.Text = "Voice ID:";
            // 
            // tlp_TalkMoneyMax
            // 
            this.tlp_TalkMoneyMax.ColumnCount = 1;
            this.tlp_TalkMoneyMax.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkMoneyMax.Controls.Add(this.num_UnitTalkMoneyMax, 0, 1);
            this.tlp_TalkMoneyMax.Controls.Add(this.lbl_TalkMoneyMax, 0, 0);
            this.tlp_TalkMoneyMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkMoneyMax.Location = new System.Drawing.Point(593, 3);
            this.tlp_TalkMoneyMax.Name = "tlp_TalkMoneyMax";
            this.tlp_TalkMoneyMax.RowCount = 2;
            this.tlp_TalkMoneyMax.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkMoneyMax.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkMoneyMax.Size = new System.Drawing.Size(166, 45);
            this.tlp_TalkMoneyMax.TabIndex = 10;
            // 
            // num_UnitTalkMoneyMax
            // 
            this.num_UnitTalkMoneyMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitTalkMoneyMax.AutoSize = true;
            this.num_UnitTalkMoneyMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitTalkMoneyMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitTalkMoneyMax.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitTalkMoneyMax.Location = new System.Drawing.Point(3, 25);
            this.num_UnitTalkMoneyMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_UnitTalkMoneyMax.Name = "num_UnitTalkMoneyMax";
            this.num_UnitTalkMoneyMax.Size = new System.Drawing.Size(160, 23);
            this.num_UnitTalkMoneyMax.TabIndex = 5;
            this.num_UnitTalkMoneyMax.ValueChanged += new System.EventHandler(this.TalkMoneyMax_Changed);
            // 
            // lbl_TalkMoneyMax
            // 
            this.lbl_TalkMoneyMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_TalkMoneyMax.AutoSize = true;
            this.lbl_TalkMoneyMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_TalkMoneyMax.Location = new System.Drawing.Point(21, 5);
            this.lbl_TalkMoneyMax.Name = "lbl_TalkMoneyMax";
            this.lbl_TalkMoneyMax.Size = new System.Drawing.Size(124, 17);
            this.lbl_TalkMoneyMax.TabIndex = 4;
            this.lbl_TalkMoneyMax.Text = "Talk Money (Max):";
            // 
            // lbl_TalkItemsRare
            // 
            this.lbl_TalkItemsRare.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_TalkItemsRare.AutoSize = true;
            this.lbl_TalkItemsRare.Location = new System.Drawing.Point(5, 124);
            this.lbl_TalkItemsRare.Name = "lbl_TalkItemsRare";
            this.lbl_TalkItemsRare.Size = new System.Drawing.Size(72, 34);
            this.lbl_TalkItemsRare.TabIndex = 12;
            this.lbl_TalkItemsRare.Text = "Talk Items (Rare):";
            // 
            // tlp_TalkItem0
            // 
            this.tlp_TalkItem0.ColumnCount = 1;
            this.tlp_TalkItem0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem0.Controls.Add(this.comboBox_TalkItem0, 0, 1);
            this.tlp_TalkItem0.Controls.Add(this.comboBox_TalkItemType0, 0, 0);
            this.tlp_TalkItem0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_TalkItem0.Location = new System.Drawing.Point(83, 54);
            this.tlp_TalkItem0.Name = "tlp_TalkItem0";
            this.tlp_TalkItem0.RowCount = 2;
            this.tlp_TalkItem0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_TalkItem0.Size = new System.Drawing.Size(164, 54);
            this.tlp_TalkItem0.TabIndex = 13;
            // 
            // comboBox_TalkItem0
            // 
            this.comboBox_TalkItem0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItem0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItem0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItem0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItem0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItem0.FormattingEnabled = true;
            this.comboBox_TalkItem0.Location = new System.Drawing.Point(3, 30);
            this.comboBox_TalkItem0.Name = "comboBox_TalkItem0";
            this.comboBox_TalkItem0.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItem0.TabIndex = 12;
            this.comboBox_TalkItem0.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_TalkItemType0
            // 
            this.comboBox_TalkItemType0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TalkItemType0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_TalkItemType0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TalkItemType0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_TalkItemType0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_TalkItemType0.FormattingEnabled = true;
            this.comboBox_TalkItemType0.Location = new System.Drawing.Point(3, 3);
            this.comboBox_TalkItemType0.Name = "comboBox_TalkItemType0";
            this.comboBox_TalkItemType0.Size = new System.Drawing.Size(158, 24);
            this.comboBox_TalkItemType0.TabIndex = 11;
            this.comboBox_TalkItemType0.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // groupBox_UnitName
            // 
            this.groupBox_UnitName.Controls.Add(this.tlp_UnitName);
            this.groupBox_UnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_UnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_UnitName.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_UnitName.Location = new System.Drawing.Point(3, 78);
            this.groupBox_UnitName.Name = "groupBox_UnitName";
            this.groupBox_UnitName.Size = new System.Drawing.Size(252, 194);
            this.groupBox_UnitName.TabIndex = 6;
            this.groupBox_UnitName.TabStop = false;
            this.groupBox_UnitName.Text = "Identity";
            // 
            // tlp_UnitName
            // 
            this.tlp_UnitName.ColumnCount = 2;
            this.tlp_UnitName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlp_UnitName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tlp_UnitName.Controls.Add(this.txt_UnitNotes, 1, 3);
            this.tlp_UnitName.Controls.Add(this.lbl_UnitNotes, 0, 3);
            this.tlp_UnitName.Controls.Add(this.lbl_PersonaName, 0, 0);
            this.tlp_UnitName.Controls.Add(this.txt_PersonaName, 1, 0);
            this.tlp_UnitName.Controls.Add(this.lbl_ShadowName, 0, 1);
            this.tlp_UnitName.Controls.Add(this.txt_ShadowName, 1, 1);
            this.tlp_UnitName.Controls.Add(this.lbl_UnitArcana, 0, 2);
            this.tlp_UnitName.Controls.Add(this.comboBox_UnitArcana, 1, 2);
            this.tlp_UnitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitName.Location = new System.Drawing.Point(3, 19);
            this.tlp_UnitName.Name = "tlp_UnitName";
            this.tlp_UnitName.RowCount = 4;
            this.tlp_UnitName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitName.Size = new System.Drawing.Size(246, 172);
            this.tlp_UnitName.TabIndex = 10;
            // 
            // txt_UnitNotes
            // 
            this.txt_UnitNotes.AcceptsReturn = true;
            this.txt_UnitNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UnitNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_UnitNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UnitNotes.ForeColor = System.Drawing.Color.Silver;
            this.txt_UnitNotes.Location = new System.Drawing.Point(84, 139);
            this.txt_UnitNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txt_UnitNotes.MaxLength = 256;
            this.txt_UnitNotes.Name = "txt_UnitNotes";
            this.txt_UnitNotes.Size = new System.Drawing.Size(156, 23);
            this.txt_UnitNotes.TabIndex = 9;
            // 
            // lbl_UnitNotes
            // 
            this.lbl_UnitNotes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_UnitNotes.AutoSize = true;
            this.lbl_UnitNotes.Location = new System.Drawing.Point(26, 142);
            this.lbl_UnitNotes.Name = "lbl_UnitNotes";
            this.lbl_UnitNotes.Size = new System.Drawing.Size(49, 17);
            this.lbl_UnitNotes.TabIndex = 8;
            this.lbl_UnitNotes.Text = "Notes:";
            // 
            // lbl_PersonaName
            // 
            this.lbl_PersonaName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_PersonaName.AutoSize = true;
            this.lbl_PersonaName.Location = new System.Drawing.Point(10, 13);
            this.lbl_PersonaName.Name = "lbl_PersonaName";
            this.lbl_PersonaName.Size = new System.Drawing.Size(65, 17);
            this.lbl_PersonaName.TabIndex = 4;
            this.lbl_PersonaName.Text = "Persona:";
            // 
            // txt_PersonaName
            // 
            this.txt_PersonaName.AcceptsReturn = true;
            this.txt_PersonaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PersonaName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_PersonaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PersonaName.ForeColor = System.Drawing.Color.Silver;
            this.txt_PersonaName.Location = new System.Drawing.Point(84, 10);
            this.txt_PersonaName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_PersonaName.MaxLength = 256;
            this.txt_PersonaName.Name = "txt_PersonaName";
            this.txt_PersonaName.Size = new System.Drawing.Size(156, 23);
            this.txt_PersonaName.TabIndex = 5;
            this.txt_PersonaName.TextChanged += new System.EventHandler(this.PersonaName_Changed);
            // 
            // lbl_ShadowName
            // 
            this.lbl_ShadowName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_ShadowName.AutoSize = true;
            this.lbl_ShadowName.Location = new System.Drawing.Point(13, 56);
            this.lbl_ShadowName.Name = "lbl_ShadowName";
            this.lbl_ShadowName.Size = new System.Drawing.Size(62, 17);
            this.lbl_ShadowName.TabIndex = 6;
            this.lbl_ShadowName.Text = "Shadow:";
            // 
            // txt_ShadowName
            // 
            this.txt_ShadowName.AcceptsReturn = true;
            this.txt_ShadowName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ShadowName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_ShadowName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ShadowName.ForeColor = System.Drawing.Color.Silver;
            this.txt_ShadowName.Location = new System.Drawing.Point(84, 53);
            this.txt_ShadowName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_ShadowName.MaxLength = 256;
            this.txt_ShadowName.Name = "txt_ShadowName";
            this.txt_ShadowName.Size = new System.Drawing.Size(156, 23);
            this.txt_ShadowName.TabIndex = 7;
            this.txt_ShadowName.TextChanged += new System.EventHandler(this.ShadowName_Changed);
            // 
            // lbl_UnitArcana
            // 
            this.lbl_UnitArcana.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_UnitArcana.AutoSize = true;
            this.lbl_UnitArcana.Location = new System.Drawing.Point(18, 99);
            this.lbl_UnitArcana.Name = "lbl_UnitArcana";
            this.lbl_UnitArcana.Size = new System.Drawing.Size(57, 17);
            this.lbl_UnitArcana.TabIndex = 4;
            this.lbl_UnitArcana.Text = "Arcana:";
            // 
            // comboBox_UnitArcana
            // 
            this.comboBox_UnitArcana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitArcana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitArcana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitArcana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitArcana.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitArcana.FormattingEnabled = true;
            this.comboBox_UnitArcana.Location = new System.Drawing.Point(81, 95);
            this.comboBox_UnitArcana.Name = "comboBox_UnitArcana";
            this.comboBox_UnitArcana.Size = new System.Drawing.Size(162, 24);
            this.comboBox_UnitArcana.TabIndex = 3;
            this.comboBox_UnitArcana.SelectedIndexChanged += new System.EventHandler(this.UnitArcana_Changed);
            // 
            // chkListBox_UnitFlags
            // 
            this.chkListBox_UnitFlags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkListBox_UnitFlags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListBox_UnitFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListBox_UnitFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkListBox_UnitFlags.ForeColor = System.Drawing.Color.Silver;
            this.chkListBox_UnitFlags.FormattingEnabled = true;
            this.chkListBox_UnitFlags.Location = new System.Drawing.Point(519, 278);
            this.chkListBox_UnitFlags.Name = "chkListBox_UnitFlags";
            this.chkListBox_UnitFlags.Size = new System.Drawing.Size(252, 194);
            this.chkListBox_UnitFlags.TabIndex = 3;
            // 
            // groupBox_UnitBasicStats
            // 
            this.tlp_Units.SetColumnSpan(this.groupBox_UnitBasicStats, 2);
            this.groupBox_UnitBasicStats.Controls.Add(this.tlp_UnitBasicStats);
            this.groupBox_UnitBasicStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_UnitBasicStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_UnitBasicStats.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_UnitBasicStats.Location = new System.Drawing.Point(261, 78);
            this.groupBox_UnitBasicStats.Name = "groupBox_UnitBasicStats";
            this.groupBox_UnitBasicStats.Size = new System.Drawing.Size(510, 194);
            this.groupBox_UnitBasicStats.TabIndex = 5;
            this.groupBox_UnitBasicStats.TabStop = false;
            this.groupBox_UnitBasicStats.Text = "Stats";
            // 
            // tlp_UnitBasicStats
            // 
            this.tlp_UnitBasicStats.ColumnCount = 5;
            this.tlp_UnitBasicStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_UnitBasicStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_UnitBasicStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_UnitBasicStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_UnitBasicStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_Luck, 4, 1);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_UnitID, 0, 0);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_Agility, 3, 1);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_UnitSP, 4, 0);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_Endurance, 2, 1);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_UnitHP, 3, 0);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_Magic, 1, 1);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_UnitLevel, 2, 0);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_Strength, 0, 1);
            this.tlp_UnitBasicStats.Controls.Add(this.tlp_UnitArcana, 1, 0);
            this.tlp_UnitBasicStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitBasicStats.Location = new System.Drawing.Point(3, 19);
            this.tlp_UnitBasicStats.Name = "tlp_UnitBasicStats";
            this.tlp_UnitBasicStats.RowCount = 2;
            this.tlp_UnitBasicStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitBasicStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitBasicStats.Size = new System.Drawing.Size(504, 172);
            this.tlp_UnitBasicStats.TabIndex = 0;
            // 
            // tlp_Luck
            // 
            this.tlp_Luck.ColumnCount = 1;
            this.tlp_Luck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Luck.Controls.Add(this.num_Luck, 0, 1);
            this.tlp_Luck.Controls.Add(this.lbl_Luck, 0, 0);
            this.tlp_Luck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Luck.Location = new System.Drawing.Point(403, 89);
            this.tlp_Luck.Name = "tlp_Luck";
            this.tlp_Luck.RowCount = 2;
            this.tlp_Luck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Luck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Luck.Size = new System.Drawing.Size(98, 80);
            this.tlp_Luck.TabIndex = 11;
            // 
            // num_Luck
            // 
            this.num_Luck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Luck.AutoSize = true;
            this.num_Luck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_Luck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Luck.ForeColor = System.Drawing.Color.Silver;
            this.num_Luck.Location = new System.Drawing.Point(3, 48);
            this.num_Luck.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Luck.Name = "num_Luck";
            this.num_Luck.Size = new System.Drawing.Size(92, 23);
            this.num_Luck.TabIndex = 5;
            this.num_Luck.ValueChanged += new System.EventHandler(this.UnitLuck_Changed);
            // 
            // lbl_Luck
            // 
            this.lbl_Luck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Luck.AutoSize = true;
            this.lbl_Luck.Location = new System.Drawing.Point(28, 23);
            this.lbl_Luck.Name = "lbl_Luck";
            this.lbl_Luck.Size = new System.Drawing.Size(42, 17);
            this.lbl_Luck.TabIndex = 4;
            this.lbl_Luck.Text = "Luck:";
            // 
            // tlp_UnitID
            // 
            this.tlp_UnitID.ColumnCount = 1;
            this.tlp_UnitID.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitID.Controls.Add(this.num_UnitEXP, 0, 1);
            this.tlp_UnitID.Controls.Add(this.lbl_UnitEXP, 0, 0);
            this.tlp_UnitID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitID.Location = new System.Drawing.Point(3, 3);
            this.tlp_UnitID.Name = "tlp_UnitID";
            this.tlp_UnitID.RowCount = 2;
            this.tlp_UnitID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitID.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitID.Size = new System.Drawing.Size(94, 80);
            this.tlp_UnitID.TabIndex = 9;
            // 
            // num_UnitEXP
            // 
            this.num_UnitEXP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitEXP.AutoSize = true;
            this.num_UnitEXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitEXP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitEXP.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitEXP.Location = new System.Drawing.Point(3, 48);
            this.num_UnitEXP.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_UnitEXP.Name = "num_UnitEXP";
            this.num_UnitEXP.Size = new System.Drawing.Size(88, 23);
            this.num_UnitEXP.TabIndex = 5;
            this.num_UnitEXP.ValueChanged += new System.EventHandler(this.UnitEXP_Changed);
            // 
            // lbl_UnitEXP
            // 
            this.lbl_UnitEXP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_UnitEXP.AutoSize = true;
            this.lbl_UnitEXP.Location = new System.Drawing.Point(27, 23);
            this.lbl_UnitEXP.Name = "lbl_UnitEXP";
            this.lbl_UnitEXP.Size = new System.Drawing.Size(39, 17);
            this.lbl_UnitEXP.TabIndex = 4;
            this.lbl_UnitEXP.Text = "EXP:";
            // 
            // tlp_Agility
            // 
            this.tlp_Agility.ColumnCount = 1;
            this.tlp_Agility.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Agility.Controls.Add(this.num_Agility, 0, 1);
            this.tlp_Agility.Controls.Add(this.lbl_Agility, 0, 0);
            this.tlp_Agility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Agility.Location = new System.Drawing.Point(303, 89);
            this.tlp_Agility.Name = "tlp_Agility";
            this.tlp_Agility.RowCount = 2;
            this.tlp_Agility.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Agility.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Agility.Size = new System.Drawing.Size(94, 80);
            this.tlp_Agility.TabIndex = 10;
            // 
            // num_Agility
            // 
            this.num_Agility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Agility.AutoSize = true;
            this.num_Agility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_Agility.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Agility.ForeColor = System.Drawing.Color.Silver;
            this.num_Agility.Location = new System.Drawing.Point(3, 48);
            this.num_Agility.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Agility.Name = "num_Agility";
            this.num_Agility.Size = new System.Drawing.Size(88, 23);
            this.num_Agility.TabIndex = 5;
            this.num_Agility.ValueChanged += new System.EventHandler(this.UnitAgility_Changed);
            // 
            // lbl_Agility
            // 
            this.lbl_Agility.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Agility.AutoSize = true;
            this.lbl_Agility.Location = new System.Drawing.Point(22, 23);
            this.lbl_Agility.Name = "lbl_Agility";
            this.lbl_Agility.Size = new System.Drawing.Size(49, 17);
            this.lbl_Agility.TabIndex = 4;
            this.lbl_Agility.Text = "Agility:";
            // 
            // tlp_UnitSP
            // 
            this.tlp_UnitSP.ColumnCount = 1;
            this.tlp_UnitSP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitSP.Controls.Add(this.numUpDwn_UnitSP, 0, 1);
            this.tlp_UnitSP.Controls.Add(this.label2, 0, 0);
            this.tlp_UnitSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitSP.Location = new System.Drawing.Point(403, 3);
            this.tlp_UnitSP.Name = "tlp_UnitSP";
            this.tlp_UnitSP.RowCount = 2;
            this.tlp_UnitSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitSP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitSP.Size = new System.Drawing.Size(98, 80);
            this.tlp_UnitSP.TabIndex = 8;
            // 
            // numUpDwn_UnitSP
            // 
            this.numUpDwn_UnitSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDwn_UnitSP.AutoSize = true;
            this.numUpDwn_UnitSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDwn_UnitSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDwn_UnitSP.ForeColor = System.Drawing.Color.Silver;
            this.numUpDwn_UnitSP.Location = new System.Drawing.Point(3, 48);
            this.numUpDwn_UnitSP.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDwn_UnitSP.Name = "numUpDwn_UnitSP";
            this.numUpDwn_UnitSP.Size = new System.Drawing.Size(92, 23);
            this.numUpDwn_UnitSP.TabIndex = 5;
            this.numUpDwn_UnitSP.ValueChanged += new System.EventHandler(this.UnitSP_Changed);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "SP:";
            // 
            // tlp_Endurance
            // 
            this.tlp_Endurance.ColumnCount = 1;
            this.tlp_Endurance.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Endurance.Controls.Add(this.num_Endurance, 0, 1);
            this.tlp_Endurance.Controls.Add(this.lbl_Endurance, 0, 0);
            this.tlp_Endurance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Endurance.Location = new System.Drawing.Point(203, 89);
            this.tlp_Endurance.Name = "tlp_Endurance";
            this.tlp_Endurance.RowCount = 2;
            this.tlp_Endurance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Endurance.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Endurance.Size = new System.Drawing.Size(94, 80);
            this.tlp_Endurance.TabIndex = 9;
            // 
            // num_Endurance
            // 
            this.num_Endurance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Endurance.AutoSize = true;
            this.num_Endurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_Endurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Endurance.ForeColor = System.Drawing.Color.Silver;
            this.num_Endurance.Location = new System.Drawing.Point(3, 48);
            this.num_Endurance.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Endurance.Name = "num_Endurance";
            this.num_Endurance.Size = new System.Drawing.Size(88, 23);
            this.num_Endurance.TabIndex = 5;
            this.num_Endurance.ValueChanged += new System.EventHandler(this.UnitEndurance_Changed);
            // 
            // lbl_Endurance
            // 
            this.lbl_Endurance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Endurance.AutoSize = true;
            this.lbl_Endurance.Location = new System.Drawing.Point(6, 23);
            this.lbl_Endurance.Name = "lbl_Endurance";
            this.lbl_Endurance.Size = new System.Drawing.Size(81, 17);
            this.lbl_Endurance.TabIndex = 4;
            this.lbl_Endurance.Text = "Endurance:";
            // 
            // tlp_UnitHP
            // 
            this.tlp_UnitHP.ColumnCount = 1;
            this.tlp_UnitHP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitHP.Controls.Add(this.numUpDwn_UnitHP, 0, 1);
            this.tlp_UnitHP.Controls.Add(this.label1, 0, 0);
            this.tlp_UnitHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitHP.Location = new System.Drawing.Point(303, 3);
            this.tlp_UnitHP.Name = "tlp_UnitHP";
            this.tlp_UnitHP.RowCount = 2;
            this.tlp_UnitHP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitHP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitHP.Size = new System.Drawing.Size(94, 80);
            this.tlp_UnitHP.TabIndex = 7;
            // 
            // numUpDwn_UnitHP
            // 
            this.numUpDwn_UnitHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDwn_UnitHP.AutoSize = true;
            this.numUpDwn_UnitHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDwn_UnitHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDwn_UnitHP.ForeColor = System.Drawing.Color.Silver;
            this.numUpDwn_UnitHP.Location = new System.Drawing.Point(3, 48);
            this.numUpDwn_UnitHP.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numUpDwn_UnitHP.Name = "numUpDwn_UnitHP";
            this.numUpDwn_UnitHP.Size = new System.Drawing.Size(88, 23);
            this.numUpDwn_UnitHP.TabIndex = 5;
            this.numUpDwn_UnitHP.ValueChanged += new System.EventHandler(this.UnitHP_Changed);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "HP:";
            // 
            // tlp_Magic
            // 
            this.tlp_Magic.ColumnCount = 1;
            this.tlp_Magic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Magic.Controls.Add(this.num_Magic, 0, 1);
            this.tlp_Magic.Controls.Add(this.lbl_Magic, 0, 0);
            this.tlp_Magic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Magic.Location = new System.Drawing.Point(103, 89);
            this.tlp_Magic.Name = "tlp_Magic";
            this.tlp_Magic.RowCount = 2;
            this.tlp_Magic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Magic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Magic.Size = new System.Drawing.Size(94, 80);
            this.tlp_Magic.TabIndex = 8;
            // 
            // num_Magic
            // 
            this.num_Magic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Magic.AutoSize = true;
            this.num_Magic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_Magic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Magic.ForeColor = System.Drawing.Color.Silver;
            this.num_Magic.Location = new System.Drawing.Point(3, 48);
            this.num_Magic.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Magic.Name = "num_Magic";
            this.num_Magic.Size = new System.Drawing.Size(88, 23);
            this.num_Magic.TabIndex = 5;
            this.num_Magic.ValueChanged += new System.EventHandler(this.UnitMagic_Changed);
            // 
            // lbl_Magic
            // 
            this.lbl_Magic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Magic.AutoSize = true;
            this.lbl_Magic.Location = new System.Drawing.Point(22, 23);
            this.lbl_Magic.Name = "lbl_Magic";
            this.lbl_Magic.Size = new System.Drawing.Size(49, 17);
            this.lbl_Magic.TabIndex = 4;
            this.lbl_Magic.Text = "Magic:";
            // 
            // tlp_UnitLevel
            // 
            this.tlp_UnitLevel.ColumnCount = 1;
            this.tlp_UnitLevel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitLevel.Controls.Add(this.numUpDwn_UnitLevel, 0, 1);
            this.tlp_UnitLevel.Controls.Add(this.lbl_UnitLevel, 0, 0);
            this.tlp_UnitLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitLevel.Location = new System.Drawing.Point(203, 3);
            this.tlp_UnitLevel.Name = "tlp_UnitLevel";
            this.tlp_UnitLevel.RowCount = 2;
            this.tlp_UnitLevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitLevel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitLevel.Size = new System.Drawing.Size(94, 80);
            this.tlp_UnitLevel.TabIndex = 6;
            // 
            // numUpDwn_UnitLevel
            // 
            this.numUpDwn_UnitLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDwn_UnitLevel.AutoSize = true;
            this.numUpDwn_UnitLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDwn_UnitLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDwn_UnitLevel.ForeColor = System.Drawing.Color.Silver;
            this.numUpDwn_UnitLevel.Location = new System.Drawing.Point(3, 48);
            this.numUpDwn_UnitLevel.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpDwn_UnitLevel.Name = "numUpDwn_UnitLevel";
            this.numUpDwn_UnitLevel.Size = new System.Drawing.Size(88, 23);
            this.numUpDwn_UnitLevel.TabIndex = 5;
            this.numUpDwn_UnitLevel.ValueChanged += new System.EventHandler(this.UnitLevel_Changed);
            // 
            // lbl_UnitLevel
            // 
            this.lbl_UnitLevel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_UnitLevel.AutoSize = true;
            this.lbl_UnitLevel.Location = new System.Drawing.Point(24, 23);
            this.lbl_UnitLevel.Name = "lbl_UnitLevel";
            this.lbl_UnitLevel.Size = new System.Drawing.Size(46, 17);
            this.lbl_UnitLevel.TabIndex = 4;
            this.lbl_UnitLevel.Text = "Level:";
            // 
            // tlp_Strength
            // 
            this.tlp_Strength.ColumnCount = 1;
            this.tlp_Strength.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Strength.Controls.Add(this.num_Strength, 0, 1);
            this.tlp_Strength.Controls.Add(this.lbl_Strength, 0, 0);
            this.tlp_Strength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Strength.Location = new System.Drawing.Point(3, 89);
            this.tlp_Strength.Name = "tlp_Strength";
            this.tlp_Strength.RowCount = 2;
            this.tlp_Strength.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Strength.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Strength.Size = new System.Drawing.Size(94, 80);
            this.tlp_Strength.TabIndex = 7;
            // 
            // num_Strength
            // 
            this.num_Strength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Strength.AutoSize = true;
            this.num_Strength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_Strength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_Strength.ForeColor = System.Drawing.Color.Silver;
            this.num_Strength.Location = new System.Drawing.Point(3, 48);
            this.num_Strength.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_Strength.Name = "num_Strength";
            this.num_Strength.Size = new System.Drawing.Size(88, 23);
            this.num_Strength.TabIndex = 5;
            this.num_Strength.ValueChanged += new System.EventHandler(this.UnitStrength_Changed);
            // 
            // lbl_Strength
            // 
            this.lbl_Strength.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Strength.AutoSize = true;
            this.lbl_Strength.Location = new System.Drawing.Point(14, 23);
            this.lbl_Strength.Name = "lbl_Strength";
            this.lbl_Strength.Size = new System.Drawing.Size(66, 17);
            this.lbl_Strength.TabIndex = 4;
            this.lbl_Strength.Text = "Strength:";
            // 
            // tlp_UnitArcana
            // 
            this.tlp_UnitArcana.ColumnCount = 1;
            this.tlp_UnitArcana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitArcana.Controls.Add(this.num_UnitMoney, 0, 1);
            this.tlp_UnitArcana.Controls.Add(this.lbl_UnitMoney, 0, 0);
            this.tlp_UnitArcana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitArcana.Location = new System.Drawing.Point(103, 3);
            this.tlp_UnitArcana.Name = "tlp_UnitArcana";
            this.tlp_UnitArcana.RowCount = 2;
            this.tlp_UnitArcana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitArcana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitArcana.Size = new System.Drawing.Size(94, 80);
            this.tlp_UnitArcana.TabIndex = 5;
            // 
            // num_UnitMoney
            // 
            this.num_UnitMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitMoney.AutoSize = true;
            this.num_UnitMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitMoney.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitMoney.Location = new System.Drawing.Point(3, 48);
            this.num_UnitMoney.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_UnitMoney.Name = "num_UnitMoney";
            this.num_UnitMoney.Size = new System.Drawing.Size(88, 23);
            this.num_UnitMoney.TabIndex = 5;
            this.num_UnitMoney.ValueChanged += new System.EventHandler(this.UnitMoney_Changed);
            // 
            // lbl_UnitMoney
            // 
            this.lbl_UnitMoney.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_UnitMoney.AutoSize = true;
            this.lbl_UnitMoney.Location = new System.Drawing.Point(20, 23);
            this.lbl_UnitMoney.Name = "lbl_UnitMoney";
            this.lbl_UnitMoney.Size = new System.Drawing.Size(54, 17);
            this.lbl_UnitMoney.TabIndex = 4;
            this.lbl_UnitMoney.Text = "Money:";
            // 
            // groupBox_ItemDrops
            // 
            this.tlp_Units.SetColumnSpan(this.groupBox_ItemDrops, 3);
            this.groupBox_ItemDrops.Controls.Add(this.tlp_ItemDrops);
            this.groupBox_ItemDrops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ItemDrops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_ItemDrops.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_ItemDrops.Location = new System.Drawing.Point(3, 678);
            this.groupBox_ItemDrops.Name = "groupBox_ItemDrops";
            this.groupBox_ItemDrops.Size = new System.Drawing.Size(768, 194);
            this.groupBox_ItemDrops.TabIndex = 3;
            this.groupBox_ItemDrops.TabStop = false;
            this.groupBox_ItemDrops.Text = "Item Drops";
            // 
            // tlp_ItemDrops
            // 
            this.tlp_ItemDrops.ColumnCount = 5;
            this.tlp_ItemDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.20408F));
            this.tlp_ItemDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.44898F));
            this.tlp_ItemDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.44898F));
            this.tlp_ItemDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.44898F));
            this.tlp_ItemDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.44898F));
            this.tlp_ItemDrops.Controls.Add(this.lbl_Chances, 0, 2);
            this.tlp_ItemDrops.Controls.Add(this.lbl_Items, 0, 1);
            this.tlp_ItemDrops.Controls.Add(this.lbl_ItemTypes, 0, 0);
            this.tlp_ItemDrops.Controls.Add(this.comboBox_ItemDropType3, 4, 0);
            this.tlp_ItemDrops.Controls.Add(this.comboBox_ItemDrop3, 4, 1);
            this.tlp_ItemDrops.Controls.Add(this.num_ItemDrop3, 4, 2);
            this.tlp_ItemDrops.Controls.Add(this.num_ItemDrop2, 3, 2);
            this.tlp_ItemDrops.Controls.Add(this.comboBox_ItemDrop2, 3, 1);
            this.tlp_ItemDrops.Controls.Add(this.comboBox_ItemDropType2, 3, 0);
            this.tlp_ItemDrops.Controls.Add(this.comboBox_ItemDropType1, 2, 0);
            this.tlp_ItemDrops.Controls.Add(this.comboBox_ItemDrop1, 2, 1);
            this.tlp_ItemDrops.Controls.Add(this.num_ItemDrop1, 2, 2);
            this.tlp_ItemDrops.Controls.Add(this.num_ItemDrop0, 1, 2);
            this.tlp_ItemDrops.Controls.Add(this.comboBox_ItemDrop0, 1, 1);
            this.tlp_ItemDrops.Controls.Add(this.comboBox_ItemDropType0, 1, 0);
            this.tlp_ItemDrops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ItemDrops.Location = new System.Drawing.Point(3, 19);
            this.tlp_ItemDrops.Name = "tlp_ItemDrops";
            this.tlp_ItemDrops.RowCount = 3;
            this.tlp_ItemDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_ItemDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_ItemDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_ItemDrops.Size = new System.Drawing.Size(762, 172);
            this.tlp_ItemDrops.TabIndex = 1;
            // 
            // lbl_Chances
            // 
            this.lbl_Chances.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Chances.AutoSize = true;
            this.lbl_Chances.Location = new System.Drawing.Point(14, 134);
            this.lbl_Chances.Name = "lbl_Chances";
            this.lbl_Chances.Size = new System.Drawing.Size(60, 17);
            this.lbl_Chances.TabIndex = 18;
            this.lbl_Chances.Text = "Chance:";
            // 
            // lbl_Items
            // 
            this.lbl_Items.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Items.AutoSize = true;
            this.lbl_Items.Location = new System.Drawing.Point(25, 68);
            this.lbl_Items.Name = "lbl_Items";
            this.lbl_Items.Size = new System.Drawing.Size(49, 34);
            this.lbl_Items.TabIndex = 17;
            this.lbl_Items.Text = "Item Name:";
            // 
            // lbl_ItemTypes
            // 
            this.lbl_ItemTypes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_ItemTypes.AutoSize = true;
            this.lbl_ItemTypes.Location = new System.Drawing.Point(30, 11);
            this.lbl_ItemTypes.Name = "lbl_ItemTypes";
            this.lbl_ItemTypes.Size = new System.Drawing.Size(44, 34);
            this.lbl_ItemTypes.TabIndex = 16;
            this.lbl_ItemTypes.Text = "Item Type:";
            // 
            // comboBox_ItemDropType3
            // 
            this.comboBox_ItemDropType3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ItemDropType3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_ItemDropType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemDropType3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_ItemDropType3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_ItemDropType3.FormattingEnabled = true;
            this.comboBox_ItemDropType3.Location = new System.Drawing.Point(593, 16);
            this.comboBox_ItemDropType3.Name = "comboBox_ItemDropType3";
            this.comboBox_ItemDropType3.Size = new System.Drawing.Size(166, 24);
            this.comboBox_ItemDropType3.TabIndex = 13;
            this.comboBox_ItemDropType3.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // comboBox_ItemDrop3
            // 
            this.comboBox_ItemDrop3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ItemDrop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_ItemDrop3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemDrop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_ItemDrop3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_ItemDrop3.FormattingEnabled = true;
            this.comboBox_ItemDrop3.Location = new System.Drawing.Point(593, 73);
            this.comboBox_ItemDrop3.Name = "comboBox_ItemDrop3";
            this.comboBox_ItemDrop3.Size = new System.Drawing.Size(166, 24);
            this.comboBox_ItemDrop3.TabIndex = 5;
            this.comboBox_ItemDrop3.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // num_ItemDrop3
            // 
            this.num_ItemDrop3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_ItemDrop3.AutoSize = true;
            this.num_ItemDrop3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_ItemDrop3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_ItemDrop3.ForeColor = System.Drawing.Color.Silver;
            this.num_ItemDrop3.Location = new System.Drawing.Point(593, 131);
            this.num_ItemDrop3.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_ItemDrop3.Name = "num_ItemDrop3";
            this.num_ItemDrop3.Size = new System.Drawing.Size(166, 23);
            this.num_ItemDrop3.TabIndex = 9;
            this.num_ItemDrop3.ValueChanged += new System.EventHandler(this.ItemDropChance_Changed);
            // 
            // num_ItemDrop2
            // 
            this.num_ItemDrop2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_ItemDrop2.AutoSize = true;
            this.num_ItemDrop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_ItemDrop2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_ItemDrop2.ForeColor = System.Drawing.Color.Silver;
            this.num_ItemDrop2.Location = new System.Drawing.Point(422, 131);
            this.num_ItemDrop2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_ItemDrop2.Name = "num_ItemDrop2";
            this.num_ItemDrop2.Size = new System.Drawing.Size(165, 23);
            this.num_ItemDrop2.TabIndex = 8;
            this.num_ItemDrop2.ValueChanged += new System.EventHandler(this.ItemDropChance_Changed);
            // 
            // comboBox_ItemDrop2
            // 
            this.comboBox_ItemDrop2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ItemDrop2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_ItemDrop2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemDrop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_ItemDrop2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_ItemDrop2.FormattingEnabled = true;
            this.comboBox_ItemDrop2.Location = new System.Drawing.Point(422, 73);
            this.comboBox_ItemDrop2.Name = "comboBox_ItemDrop2";
            this.comboBox_ItemDrop2.Size = new System.Drawing.Size(165, 24);
            this.comboBox_ItemDrop2.TabIndex = 4;
            this.comboBox_ItemDrop2.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_ItemDropType2
            // 
            this.comboBox_ItemDropType2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ItemDropType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_ItemDropType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemDropType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_ItemDropType2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_ItemDropType2.FormattingEnabled = true;
            this.comboBox_ItemDropType2.Location = new System.Drawing.Point(422, 16);
            this.comboBox_ItemDropType2.Name = "comboBox_ItemDropType2";
            this.comboBox_ItemDropType2.Size = new System.Drawing.Size(165, 24);
            this.comboBox_ItemDropType2.TabIndex = 12;
            this.comboBox_ItemDropType2.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // comboBox_ItemDropType1
            // 
            this.comboBox_ItemDropType1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ItemDropType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_ItemDropType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemDropType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_ItemDropType1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_ItemDropType1.FormattingEnabled = true;
            this.comboBox_ItemDropType1.Location = new System.Drawing.Point(251, 16);
            this.comboBox_ItemDropType1.Name = "comboBox_ItemDropType1";
            this.comboBox_ItemDropType1.Size = new System.Drawing.Size(165, 24);
            this.comboBox_ItemDropType1.TabIndex = 11;
            this.comboBox_ItemDropType1.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // comboBox_ItemDrop1
            // 
            this.comboBox_ItemDrop1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ItemDrop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_ItemDrop1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemDrop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_ItemDrop1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_ItemDrop1.FormattingEnabled = true;
            this.comboBox_ItemDrop1.Location = new System.Drawing.Point(251, 73);
            this.comboBox_ItemDrop1.Name = "comboBox_ItemDrop1";
            this.comboBox_ItemDrop1.Size = new System.Drawing.Size(165, 24);
            this.comboBox_ItemDrop1.TabIndex = 3;
            this.comboBox_ItemDrop1.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // num_ItemDrop1
            // 
            this.num_ItemDrop1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_ItemDrop1.AutoSize = true;
            this.num_ItemDrop1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_ItemDrop1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_ItemDrop1.ForeColor = System.Drawing.Color.Silver;
            this.num_ItemDrop1.Location = new System.Drawing.Point(251, 131);
            this.num_ItemDrop1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_ItemDrop1.Name = "num_ItemDrop1";
            this.num_ItemDrop1.Size = new System.Drawing.Size(165, 23);
            this.num_ItemDrop1.TabIndex = 7;
            this.num_ItemDrop1.ValueChanged += new System.EventHandler(this.ItemDropChance_Changed);
            // 
            // num_ItemDrop0
            // 
            this.num_ItemDrop0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_ItemDrop0.AutoSize = true;
            this.num_ItemDrop0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_ItemDrop0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_ItemDrop0.ForeColor = System.Drawing.Color.Silver;
            this.num_ItemDrop0.Location = new System.Drawing.Point(80, 131);
            this.num_ItemDrop0.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_ItemDrop0.Name = "num_ItemDrop0";
            this.num_ItemDrop0.Size = new System.Drawing.Size(165, 23);
            this.num_ItemDrop0.TabIndex = 6;
            this.num_ItemDrop0.ValueChanged += new System.EventHandler(this.ItemDropChance_Changed);
            // 
            // comboBox_ItemDrop0
            // 
            this.comboBox_ItemDrop0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ItemDrop0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_ItemDrop0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemDrop0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_ItemDrop0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_ItemDrop0.FormattingEnabled = true;
            this.comboBox_ItemDrop0.Location = new System.Drawing.Point(80, 73);
            this.comboBox_ItemDrop0.Name = "comboBox_ItemDrop0";
            this.comboBox_ItemDrop0.Size = new System.Drawing.Size(165, 24);
            this.comboBox_ItemDrop0.TabIndex = 2;
            this.comboBox_ItemDrop0.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_ItemDropType0
            // 
            this.comboBox_ItemDropType0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_ItemDropType0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_ItemDropType0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ItemDropType0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_ItemDropType0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_ItemDropType0.FormattingEnabled = true;
            this.comboBox_ItemDropType0.Location = new System.Drawing.Point(80, 16);
            this.comboBox_ItemDropType0.Name = "comboBox_ItemDropType0";
            this.comboBox_ItemDropType0.Size = new System.Drawing.Size(165, 24);
            this.comboBox_ItemDropType0.TabIndex = 10;
            this.comboBox_ItemDropType0.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // groupBox_UnitSkills
            // 
            this.tlp_Units.SetColumnSpan(this.groupBox_UnitSkills, 2);
            this.groupBox_UnitSkills.Controls.Add(this.tlp_UnitSkills);
            this.groupBox_UnitSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_UnitSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_UnitSkills.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_UnitSkills.Location = new System.Drawing.Point(3, 478);
            this.groupBox_UnitSkills.Name = "groupBox_UnitSkills";
            this.groupBox_UnitSkills.Size = new System.Drawing.Size(510, 194);
            this.groupBox_UnitSkills.TabIndex = 4;
            this.groupBox_UnitSkills.TabStop = false;
            this.groupBox_UnitSkills.Text = "Skills";
            // 
            // tlp_UnitSkills
            // 
            this.tlp_UnitSkills.ColumnCount = 2;
            this.tlp_UnitSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitSkills.Controls.Add(this.comboBox_UnitSkill1, 1, 0);
            this.tlp_UnitSkills.Controls.Add(this.comboBox_UnitSkill0, 0, 0);
            this.tlp_UnitSkills.Controls.Add(this.comboBox_UnitSkill6, 0, 3);
            this.tlp_UnitSkills.Controls.Add(this.comboBox_UnitSkill7, 1, 3);
            this.tlp_UnitSkills.Controls.Add(this.comboBox_UnitSkill5, 1, 2);
            this.tlp_UnitSkills.Controls.Add(this.comboBox_UnitSkill4, 0, 2);
            this.tlp_UnitSkills.Controls.Add(this.comboBox_UnitSkill2, 0, 1);
            this.tlp_UnitSkills.Controls.Add(this.comboBox_UnitSkill3, 1, 1);
            this.tlp_UnitSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitSkills.Location = new System.Drawing.Point(3, 19);
            this.tlp_UnitSkills.Name = "tlp_UnitSkills";
            this.tlp_UnitSkills.RowCount = 4;
            this.tlp_UnitSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitSkills.Size = new System.Drawing.Size(504, 172);
            this.tlp_UnitSkills.TabIndex = 0;
            // 
            // comboBox_UnitSkill1
            // 
            this.comboBox_UnitSkill1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitSkill1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitSkill1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitSkill1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitSkill1.FormattingEnabled = true;
            this.comboBox_UnitSkill1.Location = new System.Drawing.Point(255, 9);
            this.comboBox_UnitSkill1.Name = "comboBox_UnitSkill1";
            this.comboBox_UnitSkill1.Size = new System.Drawing.Size(246, 24);
            this.comboBox_UnitSkill1.TabIndex = 3;
            // 
            // comboBox_UnitSkill0
            // 
            this.comboBox_UnitSkill0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitSkill0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitSkill0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitSkill0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitSkill0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitSkill0.FormattingEnabled = true;
            this.comboBox_UnitSkill0.Location = new System.Drawing.Point(3, 9);
            this.comboBox_UnitSkill0.Name = "comboBox_UnitSkill0";
            this.comboBox_UnitSkill0.Size = new System.Drawing.Size(246, 24);
            this.comboBox_UnitSkill0.TabIndex = 2;
            this.comboBox_UnitSkill0.SelectedIndexChanged += new System.EventHandler(this.SelectedSkill_Changed);
            // 
            // comboBox_UnitSkill6
            // 
            this.comboBox_UnitSkill6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitSkill6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitSkill6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitSkill6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitSkill6.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitSkill6.FormattingEnabled = true;
            this.comboBox_UnitSkill6.Location = new System.Drawing.Point(3, 138);
            this.comboBox_UnitSkill6.Name = "comboBox_UnitSkill6";
            this.comboBox_UnitSkill6.Size = new System.Drawing.Size(246, 24);
            this.comboBox_UnitSkill6.TabIndex = 8;
            this.comboBox_UnitSkill6.SelectedIndexChanged += new System.EventHandler(this.SelectedSkill_Changed);
            // 
            // comboBox_UnitSkill7
            // 
            this.comboBox_UnitSkill7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitSkill7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitSkill7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitSkill7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitSkill7.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitSkill7.FormattingEnabled = true;
            this.comboBox_UnitSkill7.Location = new System.Drawing.Point(255, 138);
            this.comboBox_UnitSkill7.Name = "comboBox_UnitSkill7";
            this.comboBox_UnitSkill7.Size = new System.Drawing.Size(246, 24);
            this.comboBox_UnitSkill7.TabIndex = 9;
            this.comboBox_UnitSkill7.SelectedIndexChanged += new System.EventHandler(this.SelectedSkill_Changed);
            // 
            // comboBox_UnitSkill5
            // 
            this.comboBox_UnitSkill5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitSkill5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitSkill5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitSkill5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitSkill5.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitSkill5.FormattingEnabled = true;
            this.comboBox_UnitSkill5.Location = new System.Drawing.Point(255, 95);
            this.comboBox_UnitSkill5.Name = "comboBox_UnitSkill5";
            this.comboBox_UnitSkill5.Size = new System.Drawing.Size(246, 24);
            this.comboBox_UnitSkill5.TabIndex = 7;
            this.comboBox_UnitSkill5.SelectedIndexChanged += new System.EventHandler(this.SelectedSkill_Changed);
            // 
            // comboBox_UnitSkill4
            // 
            this.comboBox_UnitSkill4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitSkill4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitSkill4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitSkill4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitSkill4.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitSkill4.FormattingEnabled = true;
            this.comboBox_UnitSkill4.Location = new System.Drawing.Point(3, 95);
            this.comboBox_UnitSkill4.Name = "comboBox_UnitSkill4";
            this.comboBox_UnitSkill4.Size = new System.Drawing.Size(246, 24);
            this.comboBox_UnitSkill4.TabIndex = 6;
            this.comboBox_UnitSkill4.SelectedIndexChanged += new System.EventHandler(this.SelectedSkill_Changed);
            // 
            // comboBox_UnitSkill2
            // 
            this.comboBox_UnitSkill2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitSkill2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitSkill2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitSkill2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitSkill2.FormattingEnabled = true;
            this.comboBox_UnitSkill2.Location = new System.Drawing.Point(3, 52);
            this.comboBox_UnitSkill2.Name = "comboBox_UnitSkill2";
            this.comboBox_UnitSkill2.Size = new System.Drawing.Size(246, 24);
            this.comboBox_UnitSkill2.TabIndex = 4;
            this.comboBox_UnitSkill2.SelectedIndexChanged += new System.EventHandler(this.SelectedSkill_Changed);
            // 
            // comboBox_UnitSkill3
            // 
            this.comboBox_UnitSkill3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitSkill3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitSkill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitSkill3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitSkill3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitSkill3.FormattingEnabled = true;
            this.comboBox_UnitSkill3.Location = new System.Drawing.Point(255, 52);
            this.comboBox_UnitSkill3.Name = "comboBox_UnitSkill3";
            this.comboBox_UnitSkill3.Size = new System.Drawing.Size(246, 24);
            this.comboBox_UnitSkill3.TabIndex = 5;
            this.comboBox_UnitSkill3.SelectedIndexChanged += new System.EventHandler(this.SelectedSkill_Changed);
            // 
            // groupBox_UnitAttackStats
            // 
            this.groupBox_UnitAttackStats.Controls.Add(this.tlp_UnitAttackStats);
            this.groupBox_UnitAttackStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_UnitAttackStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_UnitAttackStats.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_UnitAttackStats.Location = new System.Drawing.Point(261, 278);
            this.groupBox_UnitAttackStats.Name = "groupBox_UnitAttackStats";
            this.groupBox_UnitAttackStats.Size = new System.Drawing.Size(252, 194);
            this.groupBox_UnitAttackStats.TabIndex = 8;
            this.groupBox_UnitAttackStats.TabStop = false;
            this.groupBox_UnitAttackStats.Text = "Attack Stats";
            // 
            // tlp_UnitAttackStats
            // 
            this.tlp_UnitAttackStats.ColumnCount = 2;
            this.tlp_UnitAttackStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_UnitAttackStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_UnitAttackStats.Controls.Add(this.num_UnitAttackAccuracy, 1, 1);
            this.tlp_UnitAttackStats.Controls.Add(this.lbl_UnitAttackDamage, 0, 2);
            this.tlp_UnitAttackStats.Controls.Add(this.lbl_Accuracy, 0, 1);
            this.tlp_UnitAttackStats.Controls.Add(this.num_UnitAttackDamage, 1, 2);
            this.tlp_UnitAttackStats.Controls.Add(this.lbl_UnitAttackType, 0, 0);
            this.tlp_UnitAttackStats.Controls.Add(this.comboBox_UnitAttackType, 1, 0);
            this.tlp_UnitAttackStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitAttackStats.Location = new System.Drawing.Point(3, 19);
            this.tlp_UnitAttackStats.Name = "tlp_UnitAttackStats";
            this.tlp_UnitAttackStats.RowCount = 4;
            this.tlp_UnitAttackStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitAttackStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitAttackStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitAttackStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitAttackStats.Size = new System.Drawing.Size(246, 172);
            this.tlp_UnitAttackStats.TabIndex = 0;
            // 
            // num_UnitAttackAccuracy
            // 
            this.num_UnitAttackAccuracy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitAttackAccuracy.AutoSize = true;
            this.num_UnitAttackAccuracy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitAttackAccuracy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitAttackAccuracy.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitAttackAccuracy.Location = new System.Drawing.Point(76, 53);
            this.num_UnitAttackAccuracy.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_UnitAttackAccuracy.Name = "num_UnitAttackAccuracy";
            this.num_UnitAttackAccuracy.Size = new System.Drawing.Size(167, 23);
            this.num_UnitAttackAccuracy.TabIndex = 7;
            this.num_UnitAttackAccuracy.ValueChanged += new System.EventHandler(this.UnitAccuracy_Changed);
            // 
            // lbl_UnitAttackDamage
            // 
            this.lbl_UnitAttackDamage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_UnitAttackDamage.AutoSize = true;
            this.lbl_UnitAttackDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.lbl_UnitAttackDamage.Location = new System.Drawing.Point(12, 100);
            this.lbl_UnitAttackDamage.Name = "lbl_UnitAttackDamage";
            this.lbl_UnitAttackDamage.Size = new System.Drawing.Size(58, 15);
            this.lbl_UnitAttackDamage.TabIndex = 4;
            this.lbl_UnitAttackDamage.Text = "Damage:";
            // 
            // lbl_Accuracy
            // 
            this.lbl_Accuracy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Accuracy.AutoSize = true;
            this.lbl_Accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.lbl_Accuracy.Location = new System.Drawing.Point(12, 57);
            this.lbl_Accuracy.Name = "lbl_Accuracy";
            this.lbl_Accuracy.Size = new System.Drawing.Size(58, 15);
            this.lbl_Accuracy.TabIndex = 4;
            this.lbl_Accuracy.Text = "Accuracy:";
            // 
            // num_UnitAttackDamage
            // 
            this.num_UnitAttackDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitAttackDamage.AutoSize = true;
            this.num_UnitAttackDamage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitAttackDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitAttackDamage.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitAttackDamage.Location = new System.Drawing.Point(76, 96);
            this.num_UnitAttackDamage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_UnitAttackDamage.Name = "num_UnitAttackDamage";
            this.num_UnitAttackDamage.Size = new System.Drawing.Size(167, 23);
            this.num_UnitAttackDamage.TabIndex = 5;
            this.num_UnitAttackDamage.ValueChanged += new System.EventHandler(this.UnitDamage_Changed);
            // 
            // lbl_UnitAttackType
            // 
            this.lbl_UnitAttackType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_UnitAttackType.AutoSize = true;
            this.lbl_UnitAttackType.Location = new System.Drawing.Point(26, 13);
            this.lbl_UnitAttackType.Name = "lbl_UnitAttackType";
            this.lbl_UnitAttackType.Size = new System.Drawing.Size(44, 17);
            this.lbl_UnitAttackType.TabIndex = 4;
            this.lbl_UnitAttackType.Text = "Type:";
            // 
            // comboBox_UnitAttackType
            // 
            this.comboBox_UnitAttackType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_UnitAttackType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_UnitAttackType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_UnitAttackType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_UnitAttackType.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_UnitAttackType.FormattingEnabled = true;
            this.comboBox_UnitAttackType.Location = new System.Drawing.Point(76, 9);
            this.comboBox_UnitAttackType.Name = "comboBox_UnitAttackType";
            this.comboBox_UnitAttackType.Size = new System.Drawing.Size(167, 24);
            this.comboBox_UnitAttackType.TabIndex = 3;
            this.comboBox_UnitAttackType.SelectedIndexChanged += new System.EventHandler(this.UnitAttackType_Changed);
            // 
            // groupBox_UnitVisualData
            // 
            this.groupBox_UnitVisualData.Controls.Add(this.tlp_UnitVisualData);
            this.groupBox_UnitVisualData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_UnitVisualData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_UnitVisualData.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_UnitVisualData.Location = new System.Drawing.Point(3, 278);
            this.groupBox_UnitVisualData.Name = "groupBox_UnitVisualData";
            this.groupBox_UnitVisualData.Size = new System.Drawing.Size(252, 194);
            this.groupBox_UnitVisualData.TabIndex = 10;
            this.groupBox_UnitVisualData.TabStop = false;
            this.groupBox_UnitVisualData.Text = "Visual Data";
            // 
            // tlp_UnitVisualData
            // 
            this.tlp_UnitVisualData.ColumnCount = 2;
            this.tlp_UnitVisualData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitVisualData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_UnitVisualData.Controls.Add(this.num_UnitPersonaID, 1, 0);
            this.tlp_UnitVisualData.Controls.Add(this.lbl_UnitPersonaID, 0, 0);
            this.tlp_UnitVisualData.Controls.Add(this.num_UnitModelID, 1, 1);
            this.tlp_UnitVisualData.Controls.Add(this.lbl_UnitVisualUnknownR, 0, 2);
            this.tlp_UnitVisualData.Controls.Add(this.lbl_UnitModelID, 0, 1);
            this.tlp_UnitVisualData.Controls.Add(this.num_UnitVisualUnknownR, 1, 2);
            this.tlp_UnitVisualData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UnitVisualData.Location = new System.Drawing.Point(3, 19);
            this.tlp_UnitVisualData.Name = "tlp_UnitVisualData";
            this.tlp_UnitVisualData.RowCount = 3;
            this.tlp_UnitVisualData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitVisualData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitVisualData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitVisualData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_UnitVisualData.Size = new System.Drawing.Size(246, 172);
            this.tlp_UnitVisualData.TabIndex = 0;
            // 
            // num_UnitPersonaID
            // 
            this.num_UnitPersonaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitPersonaID.AutoSize = true;
            this.num_UnitPersonaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitPersonaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitPersonaID.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitPersonaID.Location = new System.Drawing.Point(126, 17);
            this.num_UnitPersonaID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_UnitPersonaID.Name = "num_UnitPersonaID";
            this.num_UnitPersonaID.Size = new System.Drawing.Size(117, 23);
            this.num_UnitPersonaID.TabIndex = 10;
            this.num_UnitPersonaID.ValueChanged += new System.EventHandler(this.PersonaID_Changed);
            // 
            // lbl_UnitPersonaID
            // 
            this.lbl_UnitPersonaID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_UnitPersonaID.AutoSize = true;
            this.lbl_UnitPersonaID.Location = new System.Drawing.Point(38, 20);
            this.lbl_UnitPersonaID.Name = "lbl_UnitPersonaID";
            this.lbl_UnitPersonaID.Size = new System.Drawing.Size(82, 17);
            this.lbl_UnitPersonaID.TabIndex = 9;
            this.lbl_UnitPersonaID.Text = "Persona ID:";
            // 
            // num_UnitModelID
            // 
            this.num_UnitModelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitModelID.AutoSize = true;
            this.num_UnitModelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitModelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitModelID.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitModelID.Location = new System.Drawing.Point(126, 74);
            this.num_UnitModelID.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_UnitModelID.Name = "num_UnitModelID";
            this.num_UnitModelID.Size = new System.Drawing.Size(117, 23);
            this.num_UnitModelID.TabIndex = 8;
            this.num_UnitModelID.ValueChanged += new System.EventHandler(this.ModelID_Changed);
            // 
            // lbl_UnitVisualUnknownR
            // 
            this.lbl_UnitVisualUnknownR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_UnitVisualUnknownR.AutoSize = true;
            this.lbl_UnitVisualUnknownR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.lbl_UnitVisualUnknownR.Location = new System.Drawing.Point(16, 135);
            this.lbl_UnitVisualUnknownR.Name = "lbl_UnitVisualUnknownR";
            this.lbl_UnitVisualUnknownR.Size = new System.Drawing.Size(104, 15);
            this.lbl_UnitVisualUnknownR.TabIndex = 4;
            this.lbl_UnitVisualUnknownR.Text = "Unknown (Royal):";
            // 
            // lbl_UnitModelID
            // 
            this.lbl_UnitModelID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_UnitModelID.AutoSize = true;
            this.lbl_UnitModelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_UnitModelID.Location = new System.Drawing.Point(53, 77);
            this.lbl_UnitModelID.Name = "lbl_UnitModelID";
            this.lbl_UnitModelID.Size = new System.Drawing.Size(67, 17);
            this.lbl_UnitModelID.TabIndex = 4;
            this.lbl_UnitModelID.Text = "Model ID:";
            // 
            // num_UnitVisualUnknownR
            // 
            this.num_UnitVisualUnknownR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_UnitVisualUnknownR.AutoSize = true;
            this.num_UnitVisualUnknownR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_UnitVisualUnknownR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_UnitVisualUnknownR.ForeColor = System.Drawing.Color.Silver;
            this.num_UnitVisualUnknownR.Location = new System.Drawing.Point(126, 131);
            this.num_UnitVisualUnknownR.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.num_UnitVisualUnknownR.Name = "num_UnitVisualUnknownR";
            this.num_UnitVisualUnknownR.Size = new System.Drawing.Size(117, 23);
            this.num_UnitVisualUnknownR.TabIndex = 5;
            this.num_UnitVisualUnknownR.ValueChanged += new System.EventHandler(this.UnknownR_Changed);
            // 
            // groupBox_EventItemDrops
            // 
            this.groupBox_EventItemDrops.Controls.Add(this.tlp_EventItemDrops);
            this.groupBox_EventItemDrops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_EventItemDrops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_EventItemDrops.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_EventItemDrops.Location = new System.Drawing.Point(519, 478);
            this.groupBox_EventItemDrops.Name = "groupBox_EventItemDrops";
            this.groupBox_EventItemDrops.Size = new System.Drawing.Size(252, 194);
            this.groupBox_EventItemDrops.TabIndex = 7;
            this.groupBox_EventItemDrops.TabStop = false;
            this.groupBox_EventItemDrops.Text = "Event Item Drop";
            // 
            // tlp_EventItemDrops
            // 
            this.tlp_EventItemDrops.ColumnCount = 2;
            this.tlp_EventItemDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_EventItemDrops.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_EventItemDrops.Controls.Add(this.label3, 0, 0);
            this.tlp_EventItemDrops.Controls.Add(this.num_EventItemFlag0, 1, 3);
            this.tlp_EventItemDrops.Controls.Add(this.lbl_EventID, 0, 3);
            this.tlp_EventItemDrops.Controls.Add(this.lbl_Chance, 0, 2);
            this.tlp_EventItemDrops.Controls.Add(this.num_EventItemDrop0, 1, 2);
            this.tlp_EventItemDrops.Controls.Add(this.lbl_EventItem, 0, 1);
            this.tlp_EventItemDrops.Controls.Add(this.comboBox_EventItemDrop0, 1, 1);
            this.tlp_EventItemDrops.Controls.Add(this.comboBox_EventItemDropType0, 1, 0);
            this.tlp_EventItemDrops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_EventItemDrops.Location = new System.Drawing.Point(3, 19);
            this.tlp_EventItemDrops.Name = "tlp_EventItemDrops";
            this.tlp_EventItemDrops.RowCount = 4;
            this.tlp_EventItemDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_EventItemDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_EventItemDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_EventItemDrops.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_EventItemDrops.Size = new System.Drawing.Size(246, 172);
            this.tlp_EventItemDrops.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Item Type:";
            // 
            // num_EventItemFlag0
            // 
            this.num_EventItemFlag0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_EventItemFlag0.AutoSize = true;
            this.num_EventItemFlag0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_EventItemFlag0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_EventItemFlag0.ForeColor = System.Drawing.Color.Silver;
            this.num_EventItemFlag0.Location = new System.Drawing.Point(76, 139);
            this.num_EventItemFlag0.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_EventItemFlag0.Name = "num_EventItemFlag0";
            this.num_EventItemFlag0.Size = new System.Drawing.Size(167, 23);
            this.num_EventItemFlag0.TabIndex = 10;
            this.num_EventItemFlag0.ValueChanged += new System.EventHandler(this.EventItemID_Changed);
            // 
            // lbl_EventID
            // 
            this.lbl_EventID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_EventID.AutoSize = true;
            this.lbl_EventID.Location = new System.Drawing.Point(5, 142);
            this.lbl_EventID.Name = "lbl_EventID";
            this.lbl_EventID.Size = new System.Drawing.Size(65, 17);
            this.lbl_EventID.TabIndex = 13;
            this.lbl_EventID.Text = "Event ID:";
            // 
            // lbl_Chance
            // 
            this.lbl_Chance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Chance.AutoSize = true;
            this.lbl_Chance.Location = new System.Drawing.Point(10, 99);
            this.lbl_Chance.Name = "lbl_Chance";
            this.lbl_Chance.Size = new System.Drawing.Size(60, 17);
            this.lbl_Chance.TabIndex = 12;
            this.lbl_Chance.Text = "Chance:";
            // 
            // num_EventItemDrop0
            // 
            this.num_EventItemDrop0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.num_EventItemDrop0.AutoSize = true;
            this.num_EventItemDrop0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.num_EventItemDrop0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_EventItemDrop0.ForeColor = System.Drawing.Color.Silver;
            this.num_EventItemDrop0.Location = new System.Drawing.Point(76, 96);
            this.num_EventItemDrop0.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_EventItemDrop0.Name = "num_EventItemDrop0";
            this.num_EventItemDrop0.Size = new System.Drawing.Size(167, 23);
            this.num_EventItemDrop0.TabIndex = 6;
            this.num_EventItemDrop0.Tag = "";
            this.num_EventItemDrop0.ValueChanged += new System.EventHandler(this.ItemDropChance_Changed);
            // 
            // lbl_EventItem
            // 
            this.lbl_EventItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_EventItem.AutoSize = true;
            this.lbl_EventItem.Location = new System.Drawing.Point(21, 47);
            this.lbl_EventItem.Name = "lbl_EventItem";
            this.lbl_EventItem.Size = new System.Drawing.Size(49, 34);
            this.lbl_EventItem.TabIndex = 11;
            this.lbl_EventItem.Text = "Item Name:";
            // 
            // comboBox_EventItemDrop0
            // 
            this.comboBox_EventItemDrop0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_EventItemDrop0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_EventItemDrop0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EventItemDrop0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_EventItemDrop0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_EventItemDrop0.FormattingEnabled = true;
            this.comboBox_EventItemDrop0.Location = new System.Drawing.Point(76, 52);
            this.comboBox_EventItemDrop0.Name = "comboBox_EventItemDrop0";
            this.comboBox_EventItemDrop0.Size = new System.Drawing.Size(167, 24);
            this.comboBox_EventItemDrop0.TabIndex = 2;
            this.comboBox_EventItemDrop0.SelectedIndexChanged += new System.EventHandler(this.SelectedItem_Changed);
            // 
            // comboBox_EventItemDropType0
            // 
            this.comboBox_EventItemDropType0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_EventItemDropType0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_EventItemDropType0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EventItemDropType0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_EventItemDropType0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_EventItemDropType0.FormattingEnabled = true;
            this.comboBox_EventItemDropType0.Location = new System.Drawing.Point(76, 9);
            this.comboBox_EventItemDropType0.Name = "comboBox_EventItemDropType0";
            this.comboBox_EventItemDropType0.Size = new System.Drawing.Size(167, 24);
            this.comboBox_EventItemDropType0.TabIndex = 14;
            this.comboBox_EventItemDropType0.SelectedIndexChanged += new System.EventHandler(this.ItemType_Changed);
            // 
            // groupBox_UnitElementalAffinities
            // 
            this.groupBox_UnitElementalAffinities.AutoSize = true;
            this.groupBox_UnitElementalAffinities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Units.SetColumnSpan(this.groupBox_UnitElementalAffinities, 3);
            this.groupBox_UnitElementalAffinities.Controls.Add(this.pnl_ElementalAffinities);
            this.groupBox_UnitElementalAffinities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_UnitElementalAffinities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_UnitElementalAffinities.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_UnitElementalAffinities.Location = new System.Drawing.Point(3, 1078);
            this.groupBox_UnitElementalAffinities.Name = "groupBox_UnitElementalAffinities";
            this.groupBox_UnitElementalAffinities.Size = new System.Drawing.Size(768, 394);
            this.groupBox_UnitElementalAffinities.TabIndex = 14;
            this.groupBox_UnitElementalAffinities.TabStop = false;
            this.groupBox_UnitElementalAffinities.Text = "Elemental Affinities";
            // 
            // pnl_ElementalAffinities
            // 
            this.pnl_ElementalAffinities.AutoScroll = true;
            this.pnl_ElementalAffinities.Controls.Add(this.tlp_ElementalAffinities);
            this.pnl_ElementalAffinities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ElementalAffinities.Location = new System.Drawing.Point(3, 19);
            this.pnl_ElementalAffinities.Name = "pnl_ElementalAffinities";
            this.pnl_ElementalAffinities.Size = new System.Drawing.Size(762, 372);
            this.pnl_ElementalAffinities.TabIndex = 16;
            // 
            // tlp_ElementalAffinities
            // 
            this.tlp_ElementalAffinities.AutoSize = true;
            this.tlp_ElementalAffinities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_ElementalAffinities.ColumnCount = 10;
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_Multiplier, 9, 0);
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_Block, 8, 0);
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_Repel, 7, 0);
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_Drain, 6, 0);
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_Weak, 5, 0);
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_x2Ailment, 1, 0);
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_GuaranteeAilment, 2, 0);
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_AilmentImmune, 3, 0);
            this.tlp_ElementalAffinities.Controls.Add(this.lbl_Resist, 4, 0);
            this.tlp_ElementalAffinities.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_ElementalAffinities.Location = new System.Drawing.Point(0, 0);
            this.tlp_ElementalAffinities.Name = "tlp_ElementalAffinities";
            this.tlp_ElementalAffinities.RowCount = 1;
            this.tlp_ElementalAffinities.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_ElementalAffinities.Size = new System.Drawing.Size(762, 20);
            this.tlp_ElementalAffinities.TabIndex = 0;
            // 
            // lbl_Multiplier
            // 
            this.lbl_Multiplier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Multiplier.AutoSize = true;
            this.lbl_Multiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Multiplier.Location = new System.Drawing.Point(691, 3);
            this.lbl_Multiplier.Name = "lbl_Multiplier";
            this.lbl_Multiplier.Size = new System.Drawing.Size(64, 17);
            this.lbl_Multiplier.TabIndex = 9;
            this.lbl_Multiplier.Text = "Multiplier";
            // 
            // lbl_Block
            // 
            this.lbl_Block.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Block.AutoSize = true;
            this.lbl_Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Block.Location = new System.Drawing.Point(625, 3);
            this.lbl_Block.Name = "lbl_Block";
            this.lbl_Block.Size = new System.Drawing.Size(42, 17);
            this.lbl_Block.TabIndex = 8;
            this.lbl_Block.Text = "Block";
            // 
            // lbl_Repel
            // 
            this.lbl_Repel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Repel.AutoSize = true;
            this.lbl_Repel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Repel.Location = new System.Drawing.Point(547, 3);
            this.lbl_Repel.Name = "lbl_Repel";
            this.lbl_Repel.Size = new System.Drawing.Size(45, 17);
            this.lbl_Repel.TabIndex = 7;
            this.lbl_Repel.Text = "Repel";
            // 
            // lbl_Drain
            // 
            this.lbl_Drain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Drain.AutoSize = true;
            this.lbl_Drain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Drain.Location = new System.Drawing.Point(473, 3);
            this.lbl_Drain.Name = "lbl_Drain";
            this.lbl_Drain.Size = new System.Drawing.Size(42, 17);
            this.lbl_Drain.TabIndex = 6;
            this.lbl_Drain.Text = "Drain";
            // 
            // lbl_Weak
            // 
            this.lbl_Weak.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Weak.AutoSize = true;
            this.lbl_Weak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Weak.Location = new System.Drawing.Point(396, 3);
            this.lbl_Weak.Name = "lbl_Weak";
            this.lbl_Weak.Size = new System.Drawing.Size(44, 17);
            this.lbl_Weak.TabIndex = 5;
            this.lbl_Weak.Text = "Weak";
            // 
            // lbl_x2Ailment
            // 
            this.lbl_x2Ailment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_x2Ailment.AutoSize = true;
            this.lbl_x2Ailment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_x2Ailment.Location = new System.Drawing.Point(80, 0);
            this.lbl_x2Ailment.Name = "lbl_x2Ailment";
            this.lbl_x2Ailment.Size = new System.Drawing.Size(67, 20);
            this.lbl_x2Ailment.TabIndex = 4;
            this.lbl_x2Ailment.Text = "x2 Ailment Chance";
            // 
            // lbl_GuaranteeAilment
            // 
            this.lbl_GuaranteeAilment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_GuaranteeAilment.AutoSize = true;
            this.lbl_GuaranteeAilment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lbl_GuaranteeAilment.Location = new System.Drawing.Point(156, 0);
            this.lbl_GuaranteeAilment.Name = "lbl_GuaranteeAilment";
            this.lbl_GuaranteeAilment.Size = new System.Drawing.Size(68, 20);
            this.lbl_GuaranteeAilment.TabIndex = 4;
            this.lbl_GuaranteeAilment.Text = "Guarantee Ailment";
            // 
            // lbl_AilmentImmune
            // 
            this.lbl_AilmentImmune.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_AilmentImmune.AutoSize = true;
            this.lbl_AilmentImmune.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_AilmentImmune.Location = new System.Drawing.Point(237, 0);
            this.lbl_AilmentImmune.Name = "lbl_AilmentImmune";
            this.lbl_AilmentImmune.Size = new System.Drawing.Size(58, 20);
            this.lbl_AilmentImmune.TabIndex = 4;
            this.lbl_AilmentImmune.Text = "Ailment Immune";
            // 
            // lbl_Resist
            // 
            this.lbl_Resist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Resist.AutoSize = true;
            this.lbl_Resist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_Resist.Location = new System.Drawing.Point(318, 3);
            this.lbl_Resist.Name = "lbl_Resist";
            this.lbl_Resist.Size = new System.Drawing.Size(47, 17);
            this.lbl_Resist.TabIndex = 4;
            this.lbl_Resist.Text = "Resist";
            // 
            // tabPage_Encounters
            // 
            this.tabPage_Encounters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_Encounters.Controls.Add(this.tlp_Encounters);
            this.tabPage_Encounters.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Encounters.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Encounters.Name = "tabPage_Encounters";
            this.tabPage_Encounters.Size = new System.Drawing.Size(795, 475);
            this.tabPage_Encounters.TabIndex = 0;
            this.tabPage_Encounters.Text = "Encounters";
            // 
            // tlp_Encounters
            // 
            this.tlp_Encounters.ColumnCount = 2;
            this.tlp_Encounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Encounters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Encounters.Controls.Add(this.comboBox_Encounters, 0, 0);
            this.tlp_Encounters.Controls.Add(this.txt_EncounterSearch, 1, 0);
            this.tlp_Encounters.Controls.Add(this.chkListBox_EncounterFlags, 1, 1);
            this.tlp_Encounters.Controls.Add(this.tlp_EncounterProperties, 0, 1);
            this.tlp_Encounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encounters.Location = new System.Drawing.Point(0, 0);
            this.tlp_Encounters.Name = "tlp_Encounters";
            this.tlp_Encounters.RowCount = 2;
            this.tlp_Encounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_Encounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_Encounters.Size = new System.Drawing.Size(795, 475);
            this.tlp_Encounters.TabIndex = 0;
            // 
            // comboBox_Encounters
            // 
            this.comboBox_Encounters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Encounters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_Encounters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Encounters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_Encounters.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_Encounters.FormattingEnabled = true;
            this.comboBox_Encounters.Location = new System.Drawing.Point(3, 23);
            this.comboBox_Encounters.Name = "comboBox_Encounters";
            this.comboBox_Encounters.Size = new System.Drawing.Size(550, 24);
            this.comboBox_Encounters.TabIndex = 1;
            this.comboBox_Encounters.SelectedIndexChanged += new System.EventHandler(this.EncounterList_SelectedIndexChanged);
            // 
            // txt_EncounterSearch
            // 
            this.txt_EncounterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EncounterSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_EncounterSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EncounterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txt_EncounterSearch.ForeColor = System.Drawing.Color.Silver;
            this.txt_EncounterSearch.Location = new System.Drawing.Point(556, 24);
            this.txt_EncounterSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txt_EncounterSearch.Name = "txt_EncounterSearch";
            this.txt_EncounterSearch.Size = new System.Drawing.Size(239, 23);
            this.txt_EncounterSearch.TabIndex = 2;
            this.txt_EncounterSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EncounterSearch_KeyDown);
            // 
            // chkListBox_EncounterFlags
            // 
            this.chkListBox_EncounterFlags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkListBox_EncounterFlags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListBox_EncounterFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListBox_EncounterFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chkListBox_EncounterFlags.ForeColor = System.Drawing.Color.Silver;
            this.chkListBox_EncounterFlags.FormattingEnabled = true;
            this.chkListBox_EncounterFlags.Location = new System.Drawing.Point(559, 74);
            this.chkListBox_EncounterFlags.Name = "chkListBox_EncounterFlags";
            this.chkListBox_EncounterFlags.Size = new System.Drawing.Size(233, 398);
            this.chkListBox_EncounterFlags.TabIndex = 3;
            this.chkListBox_EncounterFlags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.EncounterFlags_ItemCheck);
            // 
            // tlp_EncounterProperties
            // 
            this.tlp_EncounterProperties.ColumnCount = 2;
            this.tlp_EncounterProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_EncounterProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_EncounterProperties.Controls.Add(this.groupBox_EncounterEtc, 1, 2);
            this.tlp_EncounterProperties.Controls.Add(this.groupBox_EncounterNotes, 0, 2);
            this.tlp_EncounterProperties.Controls.Add(this.groupBox_FieldData, 0, 1);
            this.tlp_EncounterProperties.Controls.Add(this.groupBox_BattleUnits, 0, 0);
            this.tlp_EncounterProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_EncounterProperties.Location = new System.Drawing.Point(3, 74);
            this.tlp_EncounterProperties.Name = "tlp_EncounterProperties";
            this.tlp_EncounterProperties.RowCount = 3;
            this.tlp_EncounterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_EncounterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_EncounterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_EncounterProperties.Size = new System.Drawing.Size(550, 398);
            this.tlp_EncounterProperties.TabIndex = 4;
            // 
            // groupBox_EncounterEtc
            // 
            this.groupBox_EncounterEtc.Controls.Add(this.panel1);
            this.groupBox_EncounterEtc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_EncounterEtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_EncounterEtc.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_EncounterEtc.Location = new System.Drawing.Point(278, 281);
            this.groupBox_EncounterEtc.Name = "groupBox_EncounterEtc";
            this.groupBox_EncounterEtc.Size = new System.Drawing.Size(269, 114);
            this.groupBox_EncounterEtc.TabIndex = 3;
            this.groupBox_EncounterEtc.TabStop = false;
            this.groupBox_EncounterEtc.Text = "Misc.";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(20, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBox_EncounterNotes
            // 
            this.groupBox_EncounterNotes.Controls.Add(this.txt_EncounterNotes);
            this.groupBox_EncounterNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_EncounterNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_EncounterNotes.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_EncounterNotes.Location = new System.Drawing.Point(3, 281);
            this.groupBox_EncounterNotes.Name = "groupBox_EncounterNotes";
            this.groupBox_EncounterNotes.Size = new System.Drawing.Size(269, 114);
            this.groupBox_EncounterNotes.TabIndex = 2;
            this.groupBox_EncounterNotes.TabStop = false;
            this.groupBox_EncounterNotes.Text = "Notes";
            // 
            // txt_EncounterNotes
            // 
            this.txt_EncounterNotes.AcceptsReturn = true;
            this.txt_EncounterNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txt_EncounterNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_EncounterNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_EncounterNotes.ForeColor = System.Drawing.Color.Silver;
            this.txt_EncounterNotes.Location = new System.Drawing.Point(3, 19);
            this.txt_EncounterNotes.Margin = new System.Windows.Forms.Padding(6);
            this.txt_EncounterNotes.Multiline = true;
            this.txt_EncounterNotes.Name = "txt_EncounterNotes";
            this.txt_EncounterNotes.Size = new System.Drawing.Size(263, 92);
            this.txt_EncounterNotes.TabIndex = 0;
            this.txt_EncounterNotes.TextChanged += new System.EventHandler(this.EncounterNotes_Changed);
            // 
            // groupBox_FieldData
            // 
            this.tlp_EncounterProperties.SetColumnSpan(this.groupBox_FieldData, 2);
            this.groupBox_FieldData.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_FieldData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_FieldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_FieldData.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_FieldData.Location = new System.Drawing.Point(3, 162);
            this.groupBox_FieldData.Name = "groupBox_FieldData";
            this.groupBox_FieldData.Size = new System.Drawing.Size(544, 113);
            this.groupBox_FieldData.TabIndex = 1;
            this.groupBox_FieldData.TabStop = false;
            this.groupBox_FieldData.Text = "Field Data";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox_EncounterMusic, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_FieldIDMajor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_FieldIDMinor, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 91);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox_EncounterMusic
            // 
            this.groupBox_EncounterMusic.Controls.Add(this.comboBox_EncounterMusic);
            this.groupBox_EncounterMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_EncounterMusic.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_EncounterMusic.Location = new System.Drawing.Point(361, 3);
            this.groupBox_EncounterMusic.Name = "groupBox_EncounterMusic";
            this.groupBox_EncounterMusic.Size = new System.Drawing.Size(174, 85);
            this.groupBox_EncounterMusic.TabIndex = 7;
            this.groupBox_EncounterMusic.TabStop = false;
            this.groupBox_EncounterMusic.Text = "Music";
            // 
            // comboBox_EncounterMusic
            // 
            this.comboBox_EncounterMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_EncounterMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_EncounterMusic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_EncounterMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_EncounterMusic.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_EncounterMusic.FormattingEnabled = true;
            this.comboBox_EncounterMusic.Location = new System.Drawing.Point(3, 31);
            this.comboBox_EncounterMusic.Name = "comboBox_EncounterMusic";
            this.comboBox_EncounterMusic.Size = new System.Drawing.Size(166, 24);
            this.comboBox_EncounterMusic.TabIndex = 7;
            this.comboBox_EncounterMusic.SelectedIndexChanged += new System.EventHandler(this.EncounterMusic_Changed);
            // 
            // groupBox_FieldIDMajor
            // 
            this.groupBox_FieldIDMajor.Controls.Add(this.numUpDwn_FieldIDMinor);
            this.groupBox_FieldIDMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_FieldIDMajor.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_FieldIDMajor.Location = new System.Drawing.Point(182, 3);
            this.groupBox_FieldIDMajor.Name = "groupBox_FieldIDMajor";
            this.groupBox_FieldIDMajor.Size = new System.Drawing.Size(173, 85);
            this.groupBox_FieldIDMajor.TabIndex = 6;
            this.groupBox_FieldIDMajor.TabStop = false;
            this.groupBox_FieldIDMajor.Text = "Field ID Minor";
            // 
            // numUpDwn_FieldIDMinor
            // 
            this.numUpDwn_FieldIDMinor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDwn_FieldIDMinor.AutoSize = true;
            this.numUpDwn_FieldIDMinor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDwn_FieldIDMinor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDwn_FieldIDMinor.ForeColor = System.Drawing.Color.Silver;
            this.numUpDwn_FieldIDMinor.Location = new System.Drawing.Point(6, 34);
            this.numUpDwn_FieldIDMinor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDwn_FieldIDMinor.Name = "numUpDwn_FieldIDMinor";
            this.numUpDwn_FieldIDMinor.Size = new System.Drawing.Size(122, 23);
            this.numUpDwn_FieldIDMinor.TabIndex = 1;
            this.numUpDwn_FieldIDMinor.ValueChanged += new System.EventHandler(this.FieldID_Changed);
            // 
            // groupBox_FieldIDMinor
            // 
            this.groupBox_FieldIDMinor.Controls.Add(this.numUpDwn_FieldIDMajor);
            this.groupBox_FieldIDMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_FieldIDMinor.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_FieldIDMinor.Location = new System.Drawing.Point(3, 3);
            this.groupBox_FieldIDMinor.Name = "groupBox_FieldIDMinor";
            this.groupBox_FieldIDMinor.Size = new System.Drawing.Size(173, 85);
            this.groupBox_FieldIDMinor.TabIndex = 5;
            this.groupBox_FieldIDMinor.TabStop = false;
            this.groupBox_FieldIDMinor.Text = "Field ID Major";
            // 
            // numUpDwn_FieldIDMajor
            // 
            this.numUpDwn_FieldIDMajor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numUpDwn_FieldIDMajor.AutoSize = true;
            this.numUpDwn_FieldIDMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numUpDwn_FieldIDMajor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDwn_FieldIDMajor.ForeColor = System.Drawing.Color.Silver;
            this.numUpDwn_FieldIDMajor.Location = new System.Drawing.Point(6, 34);
            this.numUpDwn_FieldIDMajor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDwn_FieldIDMajor.Name = "numUpDwn_FieldIDMajor";
            this.numUpDwn_FieldIDMajor.Size = new System.Drawing.Size(122, 23);
            this.numUpDwn_FieldIDMajor.TabIndex = 0;
            this.numUpDwn_FieldIDMajor.ValueChanged += new System.EventHandler(this.FieldID_Changed);
            // 
            // groupBox_BattleUnits
            // 
            this.tlp_EncounterProperties.SetColumnSpan(this.groupBox_BattleUnits, 2);
            this.groupBox_BattleUnits.Controls.Add(this.tlp_EncounterBattleUnits);
            this.groupBox_BattleUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_BattleUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_BattleUnits.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_BattleUnits.Location = new System.Drawing.Point(3, 3);
            this.groupBox_BattleUnits.Name = "groupBox_BattleUnits";
            this.groupBox_BattleUnits.Size = new System.Drawing.Size(544, 153);
            this.groupBox_BattleUnits.TabIndex = 0;
            this.groupBox_BattleUnits.TabStop = false;
            this.groupBox_BattleUnits.Text = "Battle Units";
            // 
            // tlp_EncounterBattleUnits
            // 
            this.tlp_EncounterBattleUnits.ColumnCount = 5;
            this.tlp_EncounterBattleUnits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_EncounterBattleUnits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_EncounterBattleUnits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_EncounterBattleUnits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_EncounterBattleUnits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_EncounterBattleUnits.Controls.Add(this.comboBox_BattleUnit4, 4, 0);
            this.tlp_EncounterBattleUnits.Controls.Add(this.comboBox_BattleUnit3, 3, 0);
            this.tlp_EncounterBattleUnits.Controls.Add(this.comboBox_BattleUnit2, 2, 0);
            this.tlp_EncounterBattleUnits.Controls.Add(this.comboBox_BattleUnit1, 1, 0);
            this.tlp_EncounterBattleUnits.Controls.Add(this.comboBox_BattleUnit0, 0, 0);
            this.tlp_EncounterBattleUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_EncounterBattleUnits.Location = new System.Drawing.Point(3, 19);
            this.tlp_EncounterBattleUnits.Name = "tlp_EncounterBattleUnits";
            this.tlp_EncounterBattleUnits.RowCount = 1;
            this.tlp_EncounterBattleUnits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_EncounterBattleUnits.Size = new System.Drawing.Size(538, 131);
            this.tlp_EncounterBattleUnits.TabIndex = 0;
            // 
            // comboBox_BattleUnit4
            // 
            this.comboBox_BattleUnit4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit4.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit4.FormattingEnabled = true;
            this.comboBox_BattleUnit4.Location = new System.Drawing.Point(431, 53);
            this.comboBox_BattleUnit4.Name = "comboBox_BattleUnit4";
            this.comboBox_BattleUnit4.Size = new System.Drawing.Size(104, 24);
            this.comboBox_BattleUnit4.TabIndex = 6;
            this.comboBox_BattleUnit4.SelectedIndexChanged += new System.EventHandler(this.BattleUnit_Changed);
            // 
            // comboBox_BattleUnit3
            // 
            this.comboBox_BattleUnit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit3.FormattingEnabled = true;
            this.comboBox_BattleUnit3.Location = new System.Drawing.Point(324, 53);
            this.comboBox_BattleUnit3.Name = "comboBox_BattleUnit3";
            this.comboBox_BattleUnit3.Size = new System.Drawing.Size(101, 24);
            this.comboBox_BattleUnit3.TabIndex = 5;
            this.comboBox_BattleUnit3.SelectedIndexChanged += new System.EventHandler(this.BattleUnit_Changed);
            // 
            // comboBox_BattleUnit2
            // 
            this.comboBox_BattleUnit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit2.FormattingEnabled = true;
            this.comboBox_BattleUnit2.Location = new System.Drawing.Point(217, 53);
            this.comboBox_BattleUnit2.Name = "comboBox_BattleUnit2";
            this.comboBox_BattleUnit2.Size = new System.Drawing.Size(101, 24);
            this.comboBox_BattleUnit2.TabIndex = 4;
            this.comboBox_BattleUnit2.SelectedIndexChanged += new System.EventHandler(this.BattleUnit_Changed);
            // 
            // comboBox_BattleUnit1
            // 
            this.comboBox_BattleUnit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit1.FormattingEnabled = true;
            this.comboBox_BattleUnit1.Location = new System.Drawing.Point(110, 53);
            this.comboBox_BattleUnit1.Name = "comboBox_BattleUnit1";
            this.comboBox_BattleUnit1.Size = new System.Drawing.Size(101, 24);
            this.comboBox_BattleUnit1.TabIndex = 3;
            this.comboBox_BattleUnit1.SelectedIndexChanged += new System.EventHandler(this.BattleUnit_Changed);
            // 
            // comboBox_BattleUnit0
            // 
            this.comboBox_BattleUnit0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit0.FormattingEnabled = true;
            this.comboBox_BattleUnit0.Location = new System.Drawing.Point(3, 53);
            this.comboBox_BattleUnit0.Name = "comboBox_BattleUnit0";
            this.comboBox_BattleUnit0.Size = new System.Drawing.Size(101, 24);
            this.comboBox_BattleUnit0.TabIndex = 2;
            this.comboBox_BattleUnit0.SelectedIndexChanged += new System.EventHandler(this.BattleUnit_Changed);
            // 
            // tabPage_Skills
            // 
            this.tabPage_Skills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_Skills.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Skills.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Skills.Name = "tabPage_Skills";
            this.tabPage_Skills.Size = new System.Drawing.Size(795, 475);
            this.tabPage_Skills.TabIndex = 2;
            this.tabPage_Skills.Text = "Skills";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(807, 553);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainForm";
            this.Opacity = 0.99D;
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowBorder = true;
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "P5RBattleEditor";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Units.ResumeLayout(false);
            this.panel_Units.ResumeLayout(false);
            this.panel_Units.PerformLayout();
            this.tlp_Units.ResumeLayout(false);
            this.tlp_Units.PerformLayout();
            this.groupBox_UnitVoiceData.ResumeLayout(false);
            this.tlp_UnitVoiceData.ResumeLayout(false);
            this.tlp_UnitVoiceData.PerformLayout();
            this.tlp_TalkItemRare3.ResumeLayout(false);
            this.tlp_TalkItemRare2.ResumeLayout(false);
            this.tlp_TalkItemRare1.ResumeLayout(false);
            this.tlp_TalkItemRare0.ResumeLayout(false);
            this.tlp_TalkItem3.ResumeLayout(false);
            this.tlp_TalkItem2.ResumeLayout(false);
            this.tlp_TalkItem1.ResumeLayout(false);
            this.tlp_UnitTalkMoneyMin.ResumeLayout(false);
            this.tlp_UnitTalkMoneyMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitTalkMoneyMin)).EndInit();
            this.tlp_UnitACBValue.ResumeLayout(false);
            this.tlp_UnitACBValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitACBValue)).EndInit();
            this.tlp_UnitTalkPerson.ResumeLayout(false);
            this.tlp_UnitTalkPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitTalkPerson)).EndInit();
            this.tlp_UnitVoiceID.ResumeLayout(false);
            this.tlp_UnitVoiceID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitVoiceID)).EndInit();
            this.tlp_TalkMoneyMax.ResumeLayout(false);
            this.tlp_TalkMoneyMax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitTalkMoneyMax)).EndInit();
            this.tlp_TalkItem0.ResumeLayout(false);
            this.groupBox_UnitName.ResumeLayout(false);
            this.tlp_UnitName.ResumeLayout(false);
            this.tlp_UnitName.PerformLayout();
            this.groupBox_UnitBasicStats.ResumeLayout(false);
            this.tlp_UnitBasicStats.ResumeLayout(false);
            this.tlp_Luck.ResumeLayout(false);
            this.tlp_Luck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Luck)).EndInit();
            this.tlp_UnitID.ResumeLayout(false);
            this.tlp_UnitID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitEXP)).EndInit();
            this.tlp_Agility.ResumeLayout(false);
            this.tlp_Agility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Agility)).EndInit();
            this.tlp_UnitSP.ResumeLayout(false);
            this.tlp_UnitSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_UnitSP)).EndInit();
            this.tlp_Endurance.ResumeLayout(false);
            this.tlp_Endurance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Endurance)).EndInit();
            this.tlp_UnitHP.ResumeLayout(false);
            this.tlp_UnitHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_UnitHP)).EndInit();
            this.tlp_Magic.ResumeLayout(false);
            this.tlp_Magic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Magic)).EndInit();
            this.tlp_UnitLevel.ResumeLayout(false);
            this.tlp_UnitLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_UnitLevel)).EndInit();
            this.tlp_Strength.ResumeLayout(false);
            this.tlp_Strength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Strength)).EndInit();
            this.tlp_UnitArcana.ResumeLayout(false);
            this.tlp_UnitArcana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitMoney)).EndInit();
            this.groupBox_ItemDrops.ResumeLayout(false);
            this.tlp_ItemDrops.ResumeLayout(false);
            this.tlp_ItemDrops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemDrop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemDrop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemDrop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_ItemDrop0)).EndInit();
            this.groupBox_UnitSkills.ResumeLayout(false);
            this.tlp_UnitSkills.ResumeLayout(false);
            this.groupBox_UnitAttackStats.ResumeLayout(false);
            this.tlp_UnitAttackStats.ResumeLayout(false);
            this.tlp_UnitAttackStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitAttackAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitAttackDamage)).EndInit();
            this.groupBox_UnitVisualData.ResumeLayout(false);
            this.tlp_UnitVisualData.ResumeLayout(false);
            this.tlp_UnitVisualData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitPersonaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitModelID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_UnitVisualUnknownR)).EndInit();
            this.groupBox_EventItemDrops.ResumeLayout(false);
            this.tlp_EventItemDrops.ResumeLayout(false);
            this.tlp_EventItemDrops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_EventItemFlag0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_EventItemDrop0)).EndInit();
            this.groupBox_UnitElementalAffinities.ResumeLayout(false);
            this.pnl_ElementalAffinities.ResumeLayout(false);
            this.pnl_ElementalAffinities.PerformLayout();
            this.tlp_ElementalAffinities.ResumeLayout(false);
            this.tlp_ElementalAffinities.PerformLayout();
            this.tabPage_Encounters.ResumeLayout(false);
            this.tlp_Encounters.ResumeLayout(false);
            this.tlp_Encounters.PerformLayout();
            this.tlp_EncounterProperties.ResumeLayout(false);
            this.groupBox_EncounterEtc.ResumeLayout(false);
            this.groupBox_EncounterNotes.ResumeLayout(false);
            this.groupBox_EncounterNotes.PerformLayout();
            this.groupBox_FieldData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox_EncounterMusic.ResumeLayout(false);
            this.groupBox_FieldIDMajor.ResumeLayout(false);
            this.groupBox_FieldIDMajor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_FieldIDMinor)).EndInit();
            this.groupBox_FieldIDMinor.ResumeLayout(false);
            this.groupBox_FieldIDMinor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_FieldIDMajor)).EndInit();
            this.groupBox_BattleUnits.ResumeLayout(false);
            this.tlp_EncounterBattleUnits.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private MetroSet_UI.Controls.MetroSetTabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Encounters;
        private System.Windows.Forms.TabPage tabPage_Units;
        private System.Windows.Forms.TabPage tabPage_Skills;
        private System.Windows.Forms.TableLayoutPanel tlp_Encounters;
        private System.Windows.Forms.ComboBox comboBox_Encounters;
        private System.Windows.Forms.TextBox txt_EncounterSearch;
        private System.Windows.Forms.CheckedListBox chkListBox_EncounterFlags;
        private System.Windows.Forms.TableLayoutPanel tlp_EncounterProperties;
        private System.Windows.Forms.GroupBox groupBox_BattleUnits;
        private System.Windows.Forms.GroupBox groupBox_FieldData;
        private System.Windows.Forms.GroupBox groupBox_EncounterNotes;
        private System.Windows.Forms.GroupBox groupBox_EncounterEtc;
        private System.Windows.Forms.TextBox txt_EncounterNotes;
        private System.Windows.Forms.TableLayoutPanel tlp_EncounterBattleUnits;
        private System.Windows.Forms.ComboBox comboBox_BattleUnit4;
        private System.Windows.Forms.ComboBox comboBox_BattleUnit3;
        private System.Windows.Forms.ComboBox comboBox_BattleUnit2;
        private System.Windows.Forms.ComboBox comboBox_BattleUnit1;
        private System.Windows.Forms.ComboBox comboBox_BattleUnit0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_FieldIDMinor;
        private System.Windows.Forms.GroupBox groupBox_EncounterMusic;
        private System.Windows.Forms.GroupBox groupBox_FieldIDMajor;
        private System.Windows.Forms.ComboBox comboBox_EncounterMusic;
        private System.Windows.Forms.NumericUpDown numUpDwn_FieldIDMinor;
        private System.Windows.Forms.NumericUpDown numUpDwn_FieldIDMajor;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTBLDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTBLsAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tBLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tlp_Units;
        private System.Windows.Forms.CheckedListBox chkListBox_UnitFlags;
        private System.Windows.Forms.GroupBox groupBox_ItemDrops;
        private System.Windows.Forms.GroupBox groupBox_UnitBasicStats;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitBasicStats;
        private System.Windows.Forms.GroupBox groupBox_UnitName;
        private System.Windows.Forms.ComboBox comboBox_UnitArcana;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitArcana;
        private System.Windows.Forms.Label lbl_UnitArcana;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitLevel;
        private System.Windows.Forms.Label lbl_UnitLevel;
        private System.Windows.Forms.NumericUpDown numUpDwn_UnitLevel;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitSP;
        private System.Windows.Forms.NumericUpDown numUpDwn_UnitSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitHP;
        private System.Windows.Forms.NumericUpDown numUpDwn_UnitHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitID;
        private System.Windows.Forms.TableLayoutPanel tlp_Luck;
        private System.Windows.Forms.NumericUpDown num_Luck;
        private System.Windows.Forms.Label lbl_Luck;
        private System.Windows.Forms.TableLayoutPanel tlp_Agility;
        private System.Windows.Forms.NumericUpDown num_Agility;
        private System.Windows.Forms.Label lbl_Agility;
        private System.Windows.Forms.TableLayoutPanel tlp_Endurance;
        private System.Windows.Forms.NumericUpDown num_Endurance;
        private System.Windows.Forms.Label lbl_Endurance;
        private System.Windows.Forms.TableLayoutPanel tlp_Magic;
        private System.Windows.Forms.NumericUpDown num_Magic;
        private System.Windows.Forms.Label lbl_Magic;
        private System.Windows.Forms.TableLayoutPanel tlp_Strength;
        private System.Windows.Forms.NumericUpDown num_Strength;
        private System.Windows.Forms.Label lbl_Strength;
        private System.Windows.Forms.GroupBox groupBox_UnitSkills;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitSkills;
        private System.Windows.Forms.ComboBox comboBox_UnitSkill3;
        private System.Windows.Forms.ComboBox comboBox_UnitSkill2;
        private System.Windows.Forms.ComboBox comboBox_UnitSkill1;
        private System.Windows.Forms.ComboBox comboBox_UnitSkill0;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitName;
        private System.Windows.Forms.TextBox txt_ShadowName;
        private System.Windows.Forms.Label lbl_ShadowName;
        private System.Windows.Forms.Label lbl_PersonaName;
        private System.Windows.Forms.TextBox txt_PersonaName;
        private System.Windows.Forms.ComboBox comboBox_UnitSkill7;
        private System.Windows.Forms.ComboBox comboBox_UnitSkill6;
        private System.Windows.Forms.ComboBox comboBox_UnitSkill5;
        private System.Windows.Forms.ComboBox comboBox_UnitSkill4;
        private System.Windows.Forms.NumericUpDown num_UnitMoney;
        private System.Windows.Forms.Label lbl_UnitMoney;
        private System.Windows.Forms.NumericUpDown num_UnitEXP;
        private System.Windows.Forms.Label lbl_UnitEXP;
        private System.Windows.Forms.TableLayoutPanel tlp_ItemDrops;
        private System.Windows.Forms.ComboBox comboBox_ItemDrop3;
        private System.Windows.Forms.ComboBox comboBox_ItemDrop2;
        private System.Windows.Forms.ComboBox comboBox_ItemDrop1;
        private System.Windows.Forms.ComboBox comboBox_ItemDrop0;
        private System.Windows.Forms.NumericUpDown num_ItemDrop3;
        private System.Windows.Forms.NumericUpDown num_ItemDrop2;
        private System.Windows.Forms.NumericUpDown num_ItemDrop1;
        private System.Windows.Forms.NumericUpDown num_ItemDrop0;
        private System.Windows.Forms.GroupBox groupBox_EventItemDrops;
        private System.Windows.Forms.TableLayoutPanel tlp_EventItemDrops;
        private System.Windows.Forms.NumericUpDown num_EventItemDrop0;
        private System.Windows.Forms.ComboBox comboBox_EventItemDrop0;
        private System.Windows.Forms.NumericUpDown num_EventItemFlag0;
        private System.Windows.Forms.GroupBox groupBox_UnitAttackStats;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitAttackStats;
        private System.Windows.Forms.NumericUpDown num_UnitAttackDamage;
        private System.Windows.Forms.Label lbl_UnitAttackDamage;
        private System.Windows.Forms.Label lbl_Accuracy;
        private System.Windows.Forms.ComboBox comboBox_UnitAttackType;
        private System.Windows.Forms.Label lbl_UnitAttackType;
        private System.Windows.Forms.GroupBox groupBox_UnitVoiceData;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitVoiceData;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitVoiceID;
        private System.Windows.Forms.NumericUpDown num_UnitVoiceID;
        private System.Windows.Forms.Label lbl_UnitVoiceID;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitTalkPerson;
        private System.Windows.Forms.NumericUpDown num_UnitTalkPerson;
        private System.Windows.Forms.Label lbl_UnitTalkPerson;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitACBValue;
        private System.Windows.Forms.NumericUpDown num_UnitACBValue;
        private System.Windows.Forms.Label lbl_UnitACBValue;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitTalkMoneyMin;
        private System.Windows.Forms.NumericUpDown num_UnitTalkMoneyMin;
        private System.Windows.Forms.Label lbl_UnitTalkMoneyMin;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkMoneyMax;
        private System.Windows.Forms.NumericUpDown num_UnitTalkMoneyMax;
        private System.Windows.Forms.Label lbl_TalkMoneyMax;
        private System.Windows.Forms.GroupBox groupBox_UnitVisualData;
        private System.Windows.Forms.TableLayoutPanel tlp_UnitVisualData;
        private System.Windows.Forms.Label lbl_UnitVisualUnknownR;
        private System.Windows.Forms.Label lbl_UnitModelID;
        private System.Windows.Forms.NumericUpDown num_UnitVisualUnknownR;
        private System.Windows.Forms.NumericUpDown num_UnitModelID;
        private System.Windows.Forms.Panel panel_Units;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Units;
        private System.Windows.Forms.TextBox txt_UnitSearch;
        private System.Windows.Forms.Label lbl_EventItem;
        private System.Windows.Forms.Label lbl_EventID;
        private System.Windows.Forms.Label lbl_Chance;
        private System.Windows.Forms.ComboBox comboBox_ItemDropType3;
        private System.Windows.Forms.ComboBox comboBox_ItemDropType2;
        private System.Windows.Forms.ComboBox comboBox_ItemDropType1;
        private System.Windows.Forms.ComboBox comboBox_ItemDropType0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_EventItemDropType0;
        private System.Windows.Forms.NumericUpDown num_UnitPersonaID;
        private System.Windows.Forms.Label lbl_UnitPersonaID;
        private System.Windows.Forms.Label lbl_Chances;
        private System.Windows.Forms.Label lbl_Items;
        private System.Windows.Forms.Label lbl_ItemTypes;
        private System.Windows.Forms.TextBox txt_UnitNotes;
        private System.Windows.Forms.Label lbl_UnitNotes;
        private System.Windows.Forms.NumericUpDown num_UnitAttackAccuracy;
        private System.Windows.Forms.Label lbl_TalkItems;
        private System.Windows.Forms.Label lbl_TalkItemsRare;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkItem0;
        private System.Windows.Forms.ComboBox comboBox_TalkItem0;
        private System.Windows.Forms.ComboBox comboBox_TalkItemType0;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkItemRare3;
        private System.Windows.Forms.ComboBox comboBox_TalkItemRare3;
        private System.Windows.Forms.ComboBox comboBox_TalkItemRareType3;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkItemRare2;
        private System.Windows.Forms.ComboBox comboBox_TalkItemRare2;
        private System.Windows.Forms.ComboBox comboBox_TalkItemRareType2;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkItemRare1;
        private System.Windows.Forms.ComboBox comboBox_TalkItemRare1;
        private System.Windows.Forms.ComboBox comboBox_TalkItemRareType1;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkItemRare0;
        private System.Windows.Forms.ComboBox comboBox_TalkItemRare0;
        private System.Windows.Forms.ComboBox comboBox_TalkItemRareType0;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkItem3;
        private System.Windows.Forms.ComboBox comboBox_TalkItem3;
        private System.Windows.Forms.ComboBox comboBox_TalkItemType3;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkItem2;
        private System.Windows.Forms.ComboBox comboBox_TalkItem2;
        private System.Windows.Forms.ComboBox comboBox_TalkItemType2;
        private System.Windows.Forms.TableLayoutPanel tlp_TalkItem1;
        private System.Windows.Forms.ComboBox comboBox_TalkItem1;
        private System.Windows.Forms.ComboBox comboBox_TalkItemType1;
        private System.Windows.Forms.GroupBox groupBox_UnitElementalAffinities;
        private System.Windows.Forms.TableLayoutPanel tlp_ElementalAffinities;
        private System.Windows.Forms.Label lbl_AilmentImmune;
        private System.Windows.Forms.Label lbl_GuaranteeAilment;
        private System.Windows.Forms.Label lbl_x2Ailment;
        private System.Windows.Forms.Label lbl_Resist;
        private System.Windows.Forms.Label lbl_Multiplier;
        private System.Windows.Forms.Label lbl_Block;
        private System.Windows.Forms.Label lbl_Repel;
        private System.Windows.Forms.Label lbl_Drain;
        private System.Windows.Forms.Label lbl_Weak;
        private System.Windows.Forms.Panel pnl_ElementalAffinities;
    }
}

