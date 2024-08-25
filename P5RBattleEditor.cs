using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5RBattleEditor
{
    public partial class P5RBattleEditor : MetroSetForm
    {
        List<Encounter> Encounters = new List<Encounter>();
        List<Unit> Units = new List<Unit>();

        public P5RBattleEditor()
        {
            InitializeComponent();
            Encounters = ReadP5REncountTbl("");
            Units = ReadP5RUnitTbl("");
        }

        
    }

    
}
