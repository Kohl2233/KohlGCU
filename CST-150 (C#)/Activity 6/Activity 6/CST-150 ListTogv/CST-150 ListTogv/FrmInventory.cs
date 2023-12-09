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

        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            selectedGridIndex = gvInv.CurrentRow.Index;
            lblSelectedIndex.Text = "Selected Row Index: " + selectedGridIndex;
        }

        private void BtnIncQty_ClickEventHandler(object sender, EventArgs e)
        {
            Inventory incQty = new Inventory();
            invItems = incQty.IncQtyValue(invItems, selectedGridIndex);
            incQty.WriteInventory(invItems);
            gvInv.Refresh();
        }
    }
}