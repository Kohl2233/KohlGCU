/* Kohl Johnson
 * CST-150
 * Class Project
 * 12-3-2023
 * Citation(s): 
 *      String Format Help: https://learn.microsoft.com/en-us/dotnet/api/system.string.format?view=net-7.0#Starting 
 *      ToolTips: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.tooltip?view=windowsdesktop-8.0
 *      Mulitple Forms: https://www.youtube.com/watch?v=ooX_paV5Eoc
 *       
 */


using Class_Project.BusinessLayer;
using Class_Project.PresentationLayer;

namespace Class_Project
{
    public partial class FrmMain : Form
    {
        // Program Attributes
        Inventory inventory;
        int InventoryGridIndex = 0;


        public FrmMain()
        {
            InitializeComponent();

        }


        /// <summary>
        /// Function to Display Inventory Items
        /// </summary>
        private void DisplayInventory()
        {
            gvInventoryGrid.Rows.Clear();
            for (int i = 0; i < inventory.InventoryList.Count; i++)
            {
                Movie movie = (Movie)inventory.InventoryList[i];
                gvInventoryGrid.Rows.Add(movie.Name, movie.Rating, movie.AudienceScore, movie.Qty, movie.Price);
            }
        }

        /// <summary>
        /// Method to Add New Movie to Inventory
        /// </summary>
        /// <param name="newMovie"></param>
        public void AddNewMovie(Movie newMovie)
        {
            inventory.AddNewMovie(newMovie);
            DisplayInventory();
        }


        /// <summary>
        /// Method to Grab and Display the Movie Name From Data Grid
        /// </summary>
        private void DisplaySelectedMovieName()
        {
            if (gvInventoryGrid.Rows.Count > 1)
            {
                gvInventoryGrid.ClearSelection();
                lblSelectedMovie.Text = "Selected Movie:\n" + gvInventoryGrid.Rows[InventoryGridIndex].Cells[0].Value.ToString();
                gvInventoryGrid.Rows[InventoryGridIndex].Selected = true;
            }
            else
            {
                lblSelectedMovie.Text = "No Movies Available..";
            }

        }


        // ##########################################################
        //                  EVENT HANDLER METHODS
        // ##########################################################

        /// <summary>
        /// Function to Handle Everything that Needs to Be Done When Form Loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoadEventHandler(object sender, EventArgs e)
        {
            // DataGrid Setup
            gvInventoryGrid.ColumnCount = 5;
            gvInventoryGrid.Columns[0].Name = "Name";
            gvInventoryGrid.Columns[0].Width = 300;
            gvInventoryGrid.Columns[1].Name = "Age Rating";
            gvInventoryGrid.Columns[2].Name = "Audience Score";
            gvInventoryGrid.Columns[3].Name = "Qty";
            gvInventoryGrid.Columns[4].Name = "Price ($)";
            gvInventoryGrid.Columns[3].DefaultCellStyle.Format = "#.0";
            gvInventoryGrid.Columns[4].DefaultCellStyle.Format = "$#.00";
            gvInventoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Tooltip Creation
            ToolTip frmMainToolTips = new ToolTip();
            frmMainToolTips.AutoPopDelay = 5000;
            frmMainToolTips.InitialDelay = 500;
            frmMainToolTips.ReshowDelay = 1000;
            frmMainToolTips.ShowAlways = true;
            frmMainToolTips.SetToolTip(this.btnReloadInventory, "Use this to reset the inventory to default. (for accidents)");
            frmMainToolTips.SetToolTip(this.btnCreateMovie, "Create a new movie");
            frmMainToolTips.SetToolTip(this.lblSelectedMovie, "Displays the selected movie. (so you know which is selected)");
            frmMainToolTips.SetToolTip(this.btnInspectMovie, "Inspects a single movie with all details.");
            frmMainToolTips.SetToolTip(this.btnIncreaseQty, "Increases selected movie's quantity by 1.");
            frmMainToolTips.SetToolTip(this.btnDecreaseQty, "Decreases selected movie's quantity by 1.");
            frmMainToolTips.SetToolTip(this.btnRemoveMovie, "Wipes selected movie from inventory list.");


            // Initial Inventory Reading
            inventory = new Inventory(Application.StartupPath + "Data\\inventory.txt");
            DisplayInventory();
            DisplaySelectedMovieName();
        }


        /// <summary>
        /// Method to Handle Reloading the Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReloadInventory_ClickEventHandler(object sender, EventArgs e)
        {
            inventory.InventoryReset();
            DisplayInventory();
        }


        /// <summary>
        /// Method to Select a Row on Inventory Data Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryGrid_ClickEventHandler(object sender, EventArgs e)
        {
            InventoryGridIndex = gvInventoryGrid.CurrentRow.Index;
            DisplaySelectedMovieName();
        }


        /// <summary>
        /// Method to Increase Qty of Selected Movie by 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncreaseQty_ClickEventHandler(object sender, EventArgs e)
        {
            inventory.AdjustQtyValue(InventoryGridIndex, 1);
            DisplayInventory();
            DisplaySelectedMovieName();
        }


        /// <summary>
        /// Method to Decrease Qty of Selected Movie by 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDecreaseQty_ClickEventHandler(object sender, EventArgs e)
        {
            inventory.AdjustQtyValue(InventoryGridIndex, -1);
            DisplayInventory();
            DisplaySelectedMovieName();
        }


        /// <summary>
        /// Method to Remove Movie From List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemoveMovie_ClickEventHandler(object sender, EventArgs e)
        {
            inventory.DeleteMovie(InventoryGridIndex);
            InventoryGridIndex = 0;
            DisplaySelectedMovieName();
            DisplayInventory();
        }

        /// <summary>
        /// Method to Create New Movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateMovie_ClickEventHandler(object sender, EventArgs e)
        {
            FrmNewMovie NewMovieForm = new FrmNewMovie(this);
            NewMovieForm.ShowDialog();
        }
    }
}