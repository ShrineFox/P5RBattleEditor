using MetroSet_UI.Forms;

namespace P5RBattleEditor
{
    partial class P5RBattleEditor : MetroSetForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStringEditorJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStringEditorJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabPage_Encounters = new System.Windows.Forms.TabPage();
            this.tabPage_Units = new System.Windows.Forms.TabPage();
            this.tabPage_Skills = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.metroSetTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 200;
            this.metroSetTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metroSetTabControl1.Controls.Add(this.tabPage_Encounters);
            this.metroSetTabControl1.Controls.Add(this.tabPage_Units);
            this.metroSetTabControl1.Controls.Add(this.tabPage_Skills);
            this.metroSetTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroSetTabControl1.IsDerivedStyle = true;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(2, 28);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.SelectedTextColor = System.Drawing.Color.White;
            this.metroSetTabControl1.Size = new System.Drawing.Size(796, 420);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 100;
            this.metroSetTabControl1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 1;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style2;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroDark";
            this.metroSetTabControl1.UnselectedTextColor = System.Drawing.Color.Gray;
            this.metroSetTabControl1.UseAnimation = false;
            // 
            // tabPage_Encounters
            // 
            this.tabPage_Encounters.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Encounters.Name = "tabPage_Encounters";
            this.tabPage_Encounters.Size = new System.Drawing.Size(788, 374);
            this.tabPage_Encounters.TabIndex = 0;
            this.tabPage_Encounters.Text = "Encounters";
            // 
            // tabPage_Units
            // 
            this.tabPage_Units.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Units.Name = "tabPage_Units";
            this.tabPage_Units.Size = new System.Drawing.Size(788, 372);
            this.tabPage_Units.TabIndex = 1;
            this.tabPage_Units.Text = "Units";
            // 
            // tabPage_Skills
            // 
            this.tabPage_Skills.Location = new System.Drawing.Point(4, 42);
            this.tabPage_Skills.Name = "tabPage_Skills";
            this.tabPage_Skills.Size = new System.Drawing.Size(788, 372);
            this.tabPage_Skills.TabIndex = 2;
            this.tabPage_Skills.Text = "Skills";
            // 
            // P5RBattleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroSetTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DropShadowEffect = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.HeaderHeight = -40;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "P5RBattleEditor";
            this.Opacity = 0.99D;
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowBorder = true;
            this.ShowHeader = true;
            this.ShowLeftRect = false;
            this.ShowTitle = false;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.Text = "P5RBATTLEEDITOR";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroSetTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStringEditorJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportStringEditorJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPathsToolStripMenuItem;
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private System.Windows.Forms.TabPage tabPage_Encounters;
        private System.Windows.Forms.TabPage tabPage_Units;
        private System.Windows.Forms.TabPage tabPage_Skills;
    }
}

