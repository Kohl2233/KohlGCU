using CST_150_ListTogv.BusinessLayer;
using CST_150_ListTogv.Models;
/* Kohl Johnson
 * CST-150
 * Activity 6
 * 12-03-2023
 * Citation(s):
 */
namespace CST_150_ListTogv
{
    public partial class FrmInventory : Form
    {
        List<InvItem> invItems = new List<InvItem>();
        List<InvItem> invSearch = new List<InvItem>();
        private int selectedGridIndex { get; set; }

        public FrmInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populate Grid Upon Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PopulateGrid_LoadEventHandler(object sender, EventArgs e)
        {
            Inventory readInv = new Inventory();
            invItems = readInv.ReadInventory(invItems);
            gvInv.DataSource = null;
            gvInv.DataSource = invItems;

            foreach (DataGridViewColumn column in gvInv.Columns)
            {
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Bunny Type";
                        break;
                    case 1:
                        column.HeaderText = "Bunny Color";
                        break;
                    case 2:
                        column.HeaderText = "Quantity";
                        column.DefaultCellStyle.Format = "N0";
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;
                    default:
                        MessageBox.Show("Invalid column trying to be accessed!");
                        break;
                }
            }
        }


        /// <summary>
        /// Click Event Handler for Grid View
        /// Displays the Current Selected Row Index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            selectedGridIndex = gvInv.CurrentRow.Index;
            lblSelectedIndex.Text = "Selected Row Index: " + selectedGridIndex;
        }


        /// <summary>
        /// Click Event Handler for BtnIncQty
        /// Increases Qty of Selected Item in Data Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncQty_ClickEventHandler(object sender, EventArgs e)
        {
            Inventory incQty = new Inventory();
            invItems = incQty.IncQtyValue(invItems, selectedGridIndex);
            incQty.WriteInventory(invItems);
            gvInv.Refresh();
        }


        /// <summary>
        /// Click Event Handler for BtnDelete
        /// Removes Item From Data Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteItem_ClickEventHandler(object sender, EventArgs e)
        {
            invItems.RemoveAt(selectedGridIndex); // remove selected item from master inventory
            gvInv.DataSource = null; // reset data grid data source
            gvInv.DataSource = invItems; // reassin invItems to data grid data source

        }


        /// <summary>
        /// Click Event Handler for BtnSearch
        /// Searches for Entered Search Param, Displays Results
        /// In a New Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_ClickEventHandler(object sender, EventArgs e)
        {
            string searchFor = txtSearch.Text;
            Inventory businessLayer = new Inventory();
            invSearch = businessLayer.SearchItem(invItems, invSearch, searchFor);
            FrmSecondary frmSecondary = new FrmSecondary(invSearch);
            frmSecondary.ShowDialog();
        }
    }
}