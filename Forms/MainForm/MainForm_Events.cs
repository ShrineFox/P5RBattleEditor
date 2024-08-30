using MetroSet_UI.Forms;
using System;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        int selectedEncounterID = -1;
        private void EncounterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Encounters.Items != null && comboBox_Encounters.Items.Count > 0)
            {
                selectedEncounterID = comboBox_Encounters.SelectedIndex;
                UpdateEncounterPropertyGrid();
            }
        }

        private void UpdateEncounterPropertyGrid()
        {
            if (EncountTblData.Encounters != null && EncountTblData.Encounters.Count > 0)
            {
                propertyGrid_Encounters.SelectedObject = EncountTblData.Encounters[selectedEncounterID];
            }
        }

        // TODO: Bind combobox items to object
        private void SetupFormControls()
        {
            UpdateEncounterListComboBox();
        }

        private void UpdateEncounterListComboBox()
        {
            if (EncountTblData.Encounters != null && EncountTblData.Encounters.Count > 0)
            {
                for (int i = 0; i < EncountTblData.Encounters.Count; i++)
                    comboBox_Encounters.Items.Add(i); // TODO: Display as "[i] Unit1 - Unit2 - Unit3 - Unit4 - Unit5"
            }
        }
    }
}
