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
            this.tabPage_Encounters = new System.Windows.Forms.TabPage();
            this.tlp_Encounters = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_Encounters = new System.Windows.Forms.ComboBox();
            this.txt_EncounterSearch = new System.Windows.Forms.TextBox();
            this.chkListBox_EncounterFlags = new System.Windows.Forms.CheckedListBox();
            this.tlp_EncounterProperties = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox_EncounterEtc = new System.Windows.Forms.GroupBox();
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
            this.tabPage_Units = new System.Windows.Forms.TabPage();
            this.tabPage_Skills = new System.Windows.Forms.TabPage();
            this.menuStrip_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Encounters.SuspendLayout();
            this.tlp_Encounters.SuspendLayout();
            this.tlp_EncounterProperties.SuspendLayout();
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
            this.menuStrip_Main.Size = new System.Drawing.Size(796, 24);
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
            this.tabControl_Main.Controls.Add(this.tabPage_Encounters);
            this.tabControl_Main.Controls.Add(this.tabPage_Units);
            this.tabControl_Main.Controls.Add(this.tabPage_Skills);
            this.tabControl_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.IsDerivedStyle = true;
            this.tabControl_Main.ItemSize = new System.Drawing.Size(100, 38);
            this.tabControl_Main.Location = new System.Drawing.Point(2, 24);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.SelectedTextColor = System.Drawing.Color.White;
            this.tabControl_Main.Size = new System.Drawing.Size(796, 424);
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
            // tabPage_Encounters
            // 
            this.tabPage_Encounters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_Encounters.Controls.Add(this.tlp_Encounters);
            this.tabPage_Encounters.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Encounters.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Encounters.Name = "tabPage_Encounters";
            this.tabPage_Encounters.Size = new System.Drawing.Size(788, 378);
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
            this.tlp_Encounters.Size = new System.Drawing.Size(788, 378);
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
            this.comboBox_Encounters.Location = new System.Drawing.Point(3, 16);
            this.comboBox_Encounters.Name = "comboBox_Encounters";
            this.comboBox_Encounters.Size = new System.Drawing.Size(545, 24);
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
            this.txt_EncounterSearch.Location = new System.Drawing.Point(551, 16);
            this.txt_EncounterSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txt_EncounterSearch.Name = "txt_EncounterSearch";
            this.txt_EncounterSearch.Size = new System.Drawing.Size(237, 23);
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
            this.chkListBox_EncounterFlags.Location = new System.Drawing.Point(554, 59);
            this.chkListBox_EncounterFlags.Name = "chkListBox_EncounterFlags";
            this.chkListBox_EncounterFlags.Size = new System.Drawing.Size(231, 316);
            this.chkListBox_EncounterFlags.TabIndex = 3;
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
            this.tlp_EncounterProperties.Location = new System.Drawing.Point(3, 59);
            this.tlp_EncounterProperties.Name = "tlp_EncounterProperties";
            this.tlp_EncounterProperties.RowCount = 3;
            this.tlp_EncounterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_EncounterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_EncounterProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_EncounterProperties.Size = new System.Drawing.Size(545, 316);
            this.tlp_EncounterProperties.TabIndex = 4;
            // 
            // groupBox_EncounterEtc
            // 
            this.groupBox_EncounterEtc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_EncounterEtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_EncounterEtc.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_EncounterEtc.Location = new System.Drawing.Point(275, 223);
            this.groupBox_EncounterEtc.Name = "groupBox_EncounterEtc";
            this.groupBox_EncounterEtc.Size = new System.Drawing.Size(267, 90);
            this.groupBox_EncounterEtc.TabIndex = 3;
            this.groupBox_EncounterEtc.TabStop = false;
            this.groupBox_EncounterEtc.Text = "Misc.";
            // 
            // groupBox_EncounterNotes
            // 
            this.groupBox_EncounterNotes.Controls.Add(this.txt_EncounterNotes);
            this.groupBox_EncounterNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_EncounterNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_EncounterNotes.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_EncounterNotes.Location = new System.Drawing.Point(3, 223);
            this.groupBox_EncounterNotes.Name = "groupBox_EncounterNotes";
            this.groupBox_EncounterNotes.Size = new System.Drawing.Size(266, 90);
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
            this.txt_EncounterNotes.Size = new System.Drawing.Size(260, 68);
            this.txt_EncounterNotes.TabIndex = 0;
            // 
            // groupBox_FieldData
            // 
            this.tlp_EncounterProperties.SetColumnSpan(this.groupBox_FieldData, 2);
            this.groupBox_FieldData.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_FieldData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_FieldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox_FieldData.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_FieldData.Location = new System.Drawing.Point(3, 129);
            this.groupBox_FieldData.Name = "groupBox_FieldData";
            this.groupBox_FieldData.Size = new System.Drawing.Size(539, 88);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 66);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox_EncounterMusic
            // 
            this.groupBox_EncounterMusic.Controls.Add(this.comboBox_EncounterMusic);
            this.groupBox_EncounterMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_EncounterMusic.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_EncounterMusic.Location = new System.Drawing.Point(357, 3);
            this.groupBox_EncounterMusic.Name = "groupBox_EncounterMusic";
            this.groupBox_EncounterMusic.Size = new System.Drawing.Size(173, 60);
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
            this.comboBox_EncounterMusic.Location = new System.Drawing.Point(3, 19);
            this.comboBox_EncounterMusic.Name = "comboBox_EncounterMusic";
            this.comboBox_EncounterMusic.Size = new System.Drawing.Size(165, 24);
            this.comboBox_EncounterMusic.TabIndex = 7;
            // 
            // groupBox_FieldIDMajor
            // 
            this.groupBox_FieldIDMajor.Controls.Add(this.numUpDwn_FieldIDMinor);
            this.groupBox_FieldIDMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_FieldIDMajor.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_FieldIDMajor.Location = new System.Drawing.Point(180, 3);
            this.groupBox_FieldIDMajor.Name = "groupBox_FieldIDMajor";
            this.groupBox_FieldIDMajor.Size = new System.Drawing.Size(171, 60);
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
            this.numUpDwn_FieldIDMinor.Location = new System.Drawing.Point(6, 22);
            this.numUpDwn_FieldIDMinor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDwn_FieldIDMinor.Name = "numUpDwn_FieldIDMinor";
            this.numUpDwn_FieldIDMinor.Size = new System.Drawing.Size(120, 23);
            this.numUpDwn_FieldIDMinor.TabIndex = 1;
            // 
            // groupBox_FieldIDMinor
            // 
            this.groupBox_FieldIDMinor.Controls.Add(this.numUpDwn_FieldIDMajor);
            this.groupBox_FieldIDMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_FieldIDMinor.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_FieldIDMinor.Location = new System.Drawing.Point(3, 3);
            this.groupBox_FieldIDMinor.Name = "groupBox_FieldIDMinor";
            this.groupBox_FieldIDMinor.Size = new System.Drawing.Size(171, 60);
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
            this.numUpDwn_FieldIDMajor.Location = new System.Drawing.Point(6, 22);
            this.numUpDwn_FieldIDMajor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numUpDwn_FieldIDMajor.Name = "numUpDwn_FieldIDMajor";
            this.numUpDwn_FieldIDMajor.Size = new System.Drawing.Size(120, 23);
            this.numUpDwn_FieldIDMajor.TabIndex = 0;
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
            this.groupBox_BattleUnits.Size = new System.Drawing.Size(539, 120);
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
            this.tlp_EncounterBattleUnits.Size = new System.Drawing.Size(533, 98);
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
            this.comboBox_BattleUnit4.Location = new System.Drawing.Point(427, 37);
            this.comboBox_BattleUnit4.Name = "comboBox_BattleUnit4";
            this.comboBox_BattleUnit4.Size = new System.Drawing.Size(103, 24);
            this.comboBox_BattleUnit4.TabIndex = 6;
            // 
            // comboBox_BattleUnit3
            // 
            this.comboBox_BattleUnit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit3.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit3.FormattingEnabled = true;
            this.comboBox_BattleUnit3.Location = new System.Drawing.Point(321, 37);
            this.comboBox_BattleUnit3.Name = "comboBox_BattleUnit3";
            this.comboBox_BattleUnit3.Size = new System.Drawing.Size(100, 24);
            this.comboBox_BattleUnit3.TabIndex = 5;
            // 
            // comboBox_BattleUnit2
            // 
            this.comboBox_BattleUnit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit2.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit2.FormattingEnabled = true;
            this.comboBox_BattleUnit2.Location = new System.Drawing.Point(215, 37);
            this.comboBox_BattleUnit2.Name = "comboBox_BattleUnit2";
            this.comboBox_BattleUnit2.Size = new System.Drawing.Size(100, 24);
            this.comboBox_BattleUnit2.TabIndex = 4;
            // 
            // comboBox_BattleUnit1
            // 
            this.comboBox_BattleUnit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit1.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit1.FormattingEnabled = true;
            this.comboBox_BattleUnit1.Location = new System.Drawing.Point(109, 37);
            this.comboBox_BattleUnit1.Name = "comboBox_BattleUnit1";
            this.comboBox_BattleUnit1.Size = new System.Drawing.Size(100, 24);
            this.comboBox_BattleUnit1.TabIndex = 3;
            // 
            // comboBox_BattleUnit0
            // 
            this.comboBox_BattleUnit0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_BattleUnit0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.comboBox_BattleUnit0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BattleUnit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_BattleUnit0.ForeColor = System.Drawing.Color.Silver;
            this.comboBox_BattleUnit0.FormattingEnabled = true;
            this.comboBox_BattleUnit0.Location = new System.Drawing.Point(3, 36);
            this.comboBox_BattleUnit0.Name = "comboBox_BattleUnit0";
            this.comboBox_BattleUnit0.Size = new System.Drawing.Size(100, 24);
            this.comboBox_BattleUnit0.TabIndex = 2;
            // 
            // tabPage_Units
            // 
            this.tabPage_Units.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_Units.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Units.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Units.Name = "tabPage_Units";
            this.tabPage_Units.Size = new System.Drawing.Size(788, 378);
            this.tabPage_Units.TabIndex = 1;
            this.tabPage_Units.Text = "Units";
            // 
            // tabPage_Skills
            // 
            this.tabPage_Skills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tabPage_Skills.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Skills.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Skills.Name = "tabPage_Skills";
            this.tabPage_Skills.Size = new System.Drawing.Size(788, 378);
            this.tabPage_Skills.TabIndex = 2;
            this.tabPage_Skills.Text = "Skills";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.tabPage_Encounters.ResumeLayout(false);
            this.tlp_Encounters.ResumeLayout(false);
            this.tlp_Encounters.PerformLayout();
            this.tlp_EncounterProperties.ResumeLayout(false);
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
    }
}

