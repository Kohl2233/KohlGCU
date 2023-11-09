/* Kohl Johnson
 * CST-150
 * Class Project
 * 11-5-2023
 * Citation(s): 
 *      String Format Help: https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-7.0#Starting 
 */


namespace Class_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblInventoryDisplay.Visible = false;
            lblInvDisplayHeader.Visible = false;
        }

        /// <summary>
        /// Handles the Click Event for btnDisplayInventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayInvBtnClickEvent(object sender, EventArgs e)
        {
            // Hard Coded Inventory
            string item1Name = "Avengers: Infinity War";
            int item1Qty = 1;
            float item1Price = 19.99f;

            string item2Name = "Star Wars Episode III: Revenge of the Sith";
            int item2Qty = 2;
            float item2Price = 29.99f;

            // Display Details
            var header = String.Format("{0,-60}{1,3}{2,12}\n", "Name", "Qty", "Price ($)");
            var item1Info = String.Format("{0,-60}{1,3:F1}{2,12:C2}\n", item1Name, item1Qty, item1Price);
            var item2Info = String.Format("{0,-60}{1,3:F1}{2,12:C2}\n", item2Name, item2Qty, item2Price);

            lblInvDisplayHeader.Text = header;
            lblInventoryDisplay.Text = item1Info + item2Info;
            lblInvDisplayHeader.Visible = true;
            lblInventoryDisplay.Visible = true;
        }
    }
}