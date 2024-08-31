using MetroSet_UI.Forms;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Reflection;
using System.Windows.Controls;
using Newtonsoft.Json;
using ShrineFox.IO;
using static P5RBattleEditor.MainForm;
using System.IO;
using System.Collections.Generic;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {

        public static string[] TblList = new string[] { "ENCOUNT.TBL", "UNIT.TBL", "NAME.TBL" };

        private void SaveProject_Click(object sender, EventArgs e)
        {
            // Get output path from file select prompt
            var outPaths = WinFormsDialogs.SelectFile("Save Project...", false, new string[] { "Project JSON (.json)" }, true);
            if (outPaths == null || outPaths.Count == 0 || string.IsNullOrEmpty(outPaths.First()))
                return;

            // Ensure output path ends with .json
            string outPath = outPaths.First();
            if (!outPath.ToLower().EndsWith(".json"))
                outPath += ".json";

            // Remove default values from serialized objects
            string jsonText = JsonConvert.SerializeObject(project, Newtonsoft.Json.Formatting.Indented);

            // Save to .json file
            File.WriteAllText(outPath, jsonText);
            MessageBox.Show($"Saved project file to:\n{outPath}", "Project Saved");
        }

        private void LoadProject_Click(object sender, EventArgs e)
        {
            var filePaths = WinFormsDialogs.SelectFile("Load Project...", false, new string[] { "Project JSON (.json)" });
            if (filePaths == null || filePaths.Count == 0 || string.IsNullOrEmpty(filePaths.First()))
                return;

            project = JsonConvert.DeserializeObject<Project>(File.ReadAllText(filePaths.First()));
            SetupFormControls();

            MessageBox.Show($"Loaded changes from:\n{filePaths.First()}", "Project Loaded");
        }

        private void NewProject_Click(object sender, EventArgs e)
        {
            ImportTBLDataFromFolder();
        }

        private void ImportTBLData_Click(object sender, EventArgs e)
        {
            ImportTBLDataFromFile();
        }

        private void ImportTBLDataFromFile()
        {
            var filePaths = WinFormsDialogs.SelectFile("Import TBL Data...", true, new string[] { "TBL File (.TBL)", "TBL JSON (.JSON)" });
            if (filePaths == null || filePaths.Count == 0 || string.IsNullOrEmpty(filePaths.First()))
                return;

            foreach(var file in filePaths)
            {
                ImportTBLData(file);
            }
        }

        private void ImportTBLDataFromFolder()
        {
            var folderPath = WinFormsDialogs.SelectFolder("Choose TBL Directory");
            if (!string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
                return;

            foreach (var file in Directory.GetFiles(folderPath)
                .Where(x => Path.GetExtension(x).Equals(".TBL") || Path.GetExtension(x).Equals(".JSON")))
            {
                ImportTBLData(file);
            }

            SetupFormControls();
        }

        private void ImportTBLData(string file)
        {
            for (int i = 0; i < TblList.Length; i++)
            {
                switch (TblList[i])
                {
                    case "ENCOUNT.TBL":
                        if (Path.GetFileName(file) == TblList[i])
                            project.EncountTblData = ReadP5REncountTbl(file);
                        else if (Path.GetFileName(file) == TblList[i].Replace(".TBL",".JSON"))
                            project.EncountTblData = LoadJson(typeof(EncountTableData), file);
                        break;
                    case "UNIT.TBL":
                        if (Path.GetFileName(file) == TblList[i])
                            project.UnitTblData = ReadP5RUnitTbl(file);
                        else if (Path.GetFileName(file) == TblList[i].Replace(".TBL", ".JSON"))
                            project.UnitTblData = LoadJson(typeof(UnitTableData), file);
                        break;
                    case "NAME.TBL":
                        if (Path.GetFileName(file) == TblList[i])
                            project.NameTblData = ReadNameTBL(file);
                        else if (Path.GetFileName(file) == TblList[i].Replace(".TBL", ".JSON"))
                            project.NameTblData = LoadJson(typeof(List<TblSection>), file);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ExportTBLs_Click(object sender, EventArgs e)
        {
            WriteP5REncountTbl("./Output/TBL/ENCOUNT.TBL");
            WriteP5RUnitTbl("./Output/TBL/UNIT.TBL");
            WriteP5RSkillTbl("./Output/TBL/SKILL.TBL");
            WriteP5RPersonaTbl("./Output/TBL/PERSONA.TBL");
            WriteNameTbl("./Output/TBL/NAME.TBL");

            MessageBox.Show("TBL files created at: ./Output/TBL");
        }

        private void ExportJSONs_Click(object sender, EventArgs e)
        {
            SaveJson(project.EncountTblData, "./JSON/ENCOUNT.JSON");
            SaveJson(project.UnitTblData, "./JSON/UNIT.JSON");
            SaveJson(project.SkillTblData, "./JSON/SKILL.JSON");
            SaveJson(project.PersonaTblData, "./JSON/PERSONA.JSON");
            SaveJson(project.NameTblData, "./JSON/NAME.JSON");

            MessageBox.Show("JSON files created at: ./Output/JSON");
        }
    }
}
