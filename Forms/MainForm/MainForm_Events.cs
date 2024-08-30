using MetroSet_UI.Forms;
using System;
using static System.ComponentModel.TypeConverter;
using System.Collections.Generic;
using System.ComponentModel;

namespace P5RBattleEditor
{
    public partial class MainForm : MetroSetForm
    {
        private void SetupFormControls()
        {
            GetEnemyUnitNames();
            UpdateEncounterListComboBox();
        }

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
    }
}
