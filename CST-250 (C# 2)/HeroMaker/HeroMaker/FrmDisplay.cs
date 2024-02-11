using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class FrmDisplay : Form
    {
        TrooperList Troops;
        public FrmDisplay(TrooperList Troops)
        {
            InitializeComponent();
            this.Troops = Troops;
            UpdateListBox();
        }



        /// <summary>
        /// Utility Function to Update Initial List Box with Troopers
        /// </summary>
        private void UpdateListBox()
        {
            for (int i = 0; i < Troops.TroopList.Count; i++)
            {
                Trooper troop = (Trooper)Troops.TroopList[i];
                listBoxTroops.Items.Add(troop.Name);
            }
        }



        /// <summary>
        /// Click Event Handler for List Box Items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxTroops_ClickEventHandler(object sender, EventArgs e)
        {
            txtSummary.Text = Troops.TroopList[listBoxTroops.SelectedIndex].ToString();
        }
    }
}
