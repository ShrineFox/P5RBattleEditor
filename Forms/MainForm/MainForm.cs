using MetroSet_UI.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml;
using static P5RBattleEditor.MainForm;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        public class Project
        {
            public EncountTableData EncountTblData { get; set; } = new EncountTableData();
            public UnitTableData UnitTblData { get; set; } = new UnitTableData();
            public SkillTableData SkillTblData { get; set; } = new SkillTableData();
            public PersonaTableData PersonaTblData { get; set; } = new PersonaTableData();
            public List<TblSection> NameTblData { get; set; } = new List<TblSection>();
        }

        public static Project project = new Project();

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
