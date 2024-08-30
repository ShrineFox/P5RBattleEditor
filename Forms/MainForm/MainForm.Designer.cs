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
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStringEditorJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStringEditorJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Encounters = new System.Windows.Forms.TabPage();
            this.tlp_Encounters = new System.Windows.Forms.TableLayoutPanel();
            this.propertyGrid_Encounters = new System.Windows.Forms.PropertyGrid();
            this.comboBox_Encounters = new System.Windows.Forms.ComboBox();
            this.tabPage_Units = new System.Windows.Forms.TabPage();
            this.tabPage_Skills = new System.Windows.Forms.TabPage();
            this.txt_EncounterSearch = new System.Windows.Forms.TextBox();
            this.menuStrip_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Encounters.SuspendLayout();
            this.tlp_Encounters.SuspendLayout();
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
            this.loadProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.importStringEditorJSONToolStripMenuItem,
            this.exportStringEditorJSONToolStripMenuItem,
            this.setPathsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            // 
            // importStringEditorJSONToolStripMenuItem
            // 
            this.importStringEditorJSONToolStripMenuItem.Name = "importStringEditorJSONToolStripMenuItem";
            this.importStringEditorJSONToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.importStringEditorJSONToolStripMenuItem.Text = "Import StringEditor JSON";
            // 
            // exportStringEditorJSONToolStripMenuItem
            // 
            this.exportStringEditorJSONToolStripMenuItem.Name = "exportStringEditorJSONToolStripMenuItem";
            this.exportStringEditorJSONToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.exportStringEditorJSONToolStripMenuItem.Text = "Export StringEditor JSON";
            // 
            // setPathsToolStripMenuItem
            // 
            this.setPathsToolStripMenuItem.Name = "setPathsToolStripMenuItem";
            this.setPathsToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.setPathsToolStripMenuItem.Text = "Set Paths";
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
            this.tlp_Encounters.Controls.Add(this.propertyGrid_Encounters, 1, 0);
            this.tlp_Encounters.Controls.Add(this.comboBox_Encounters, 0, 0);
            this.tlp_Encounters.Controls.Add(this.txt_EncounterSearch, 1, 0);
            this.tlp_Encounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Encounters.Location = new System.Drawing.Point(0, 0);
            this.tlp_Encounters.Name = "tlp_Encounters";
            this.tlp_Encounters.RowCount = 2;
            this.tlp_Encounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_Encounters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_Encounters.Size = new System.Drawing.Size(788, 378);
            this.tlp_Encounters.TabIndex = 0;
            // 
            // propertyGrid_Encounters
            // 
            this.tlp_Encounters.SetColumnSpan(this.propertyGrid_Encounters, 2);
            this.propertyGrid_Encounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid_Encounters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.propertyGrid_Encounters.Location = new System.Drawing.Point(3, 59);
            this.propertyGrid_Encounters.Name = "propertyGrid_Encounters";
            this.propertyGrid_Encounters.Size = new System.Drawing.Size(782, 316);
            this.propertyGrid_Encounters.TabIndex = 0;
            // 
            // comboBox_Encounters
            // 
            this.comboBox_Encounters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Encounters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Encounters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.comboBox_Encounters.FormattingEnabled = true;
            this.comboBox_Encounters.Location = new System.Drawing.Point(3, 15);
            this.comboBox_Encounters.Name = "comboBox_Encounters";
            this.comboBox_Encounters.Size = new System.Drawing.Size(545, 24);
            this.comboBox_Encounters.TabIndex = 1;
            this.comboBox_Encounters.SelectedIndexChanged += new System.EventHandler(this.EncounterList_SelectedIndexChanged);
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
            // txt_EncounterSearch
            // 
            this.txt_EncounterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_EncounterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txt_EncounterSearch.Location = new System.Drawing.Point(554, 16);
            this.txt_EncounterSearch.Name = "txt_EncounterSearch";
            this.txt_EncounterSearch.Size = new System.Drawing.Size(231, 23);
            this.txt_EncounterSearch.TabIndex = 2;
            this.txt_EncounterSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EncounterSearch_KeyDown);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStringEditorJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportStringEditorJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPathsToolStripMenuItem;
        private MetroSet_UI.Controls.MetroSetTabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Encounters;
        private System.Windows.Forms.TabPage tabPage_Units;
        private System.Windows.Forms.TabPage tabPage_Skills;
        private System.Windows.Forms.TableLayoutPanel tlp_Encounters;
        private System.Windows.Forms.PropertyGrid propertyGrid_Encounters;
        private System.Windows.Forms.ComboBox comboBox_Encounters;
        private System.Windows.Forms.TextBox txt_EncounterSearch;
    }
}

