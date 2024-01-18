using CST_150_ListTogv.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Kohl Johnson
 * CST-150
 * Activity 7
 * 12-10-2023
 * Citation(s):
 */
namespace CST_150_ListTogv
{
    public partial class FrmSecondary : Form
    {
        // Class Level List
        List<InvItem> mySearch = new List<InvItem>();


        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="invSearch"></param>
        public FrmSecondary(List<InvItem> invSearch)
        {
            InitializeComponent();
            this.mySearch = invSearch;
        }


        /// <summary>
        /// Load Event Handler for FrmSecondary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoad_EventHandler(object sender, EventArgs e)
        {
            gvSearchResults.DataSource = this.mySearch;
        }


        /// <summary>
        /// Click Event Handler for BtnExit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_ClickEventHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
