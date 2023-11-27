/* Kohl Johnson
 * CST-150
 * Class Project
 * 11-18-2023
 * Citation(s): 
 *      String Format Help: https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-7.0#Starting 
 */


using Class_Project.BusinessLayer;

namespace Class_Project
{
    public partial class FrmMain : Form
    {
        // Program Attributes
        Inventory inventory;


        public FrmMain()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = Application.StartupPath + @"Data";
            openFileDialog1.Title = "Browse Txt Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
        }


        /// <summary>
        /// Handles the Click Event for btnDisplayInventory ----- MAIN METHOD -----
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayInvBtnClickEvent(object sender, EventArgs e)
        {
            // Prompt the Open File Dialog
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Create Inventory Object With Said Inventory File
                inventory = new Inventory(openFileDialog1.FileName);

                // Show Inventory
                DisplayInventory();
            }
        }


        /// <summary>
        /// Function to Display Inventory Items
        /// </summary>
        private void DisplayInventory()
        {
            for (int i = 0; i < inventory.InventoryList.Count; i++)
            {
                Movie movie = (Movie)inventory.InventoryList[i];
                gvInventoryGrid.Rows.Add(movie.Name, movie.Rating, movie.AudienceScore, movie.Qty, movie.Price);
            }
        }


        /// <summary>
        /// Function to Handle Everything that Needs to Be Done When Form Loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoadEventHandler(object sender, EventArgs e)
        {
            gvInventoryGrid.ColumnCount = 5;
            gvInventoryGrid.Columns[0].Name = "Name";
            gvInventoryGrid.Columns[1].Name = "Age Rating";
            gvInventoryGrid.Columns[2].Name  = "Score";
            gvInventoryGrid.Columns[3].Name = "Qty";
            gvInventoryGrid.Columns[4].Name = "Price ($)";
            gvInventoryGrid.Columns[3].DefaultCellStyle.Format = "#.0";
            gvInventoryGrid.Columns[4].DefaultCellStyle.Format = "$#.00";
            
        }
    }
}