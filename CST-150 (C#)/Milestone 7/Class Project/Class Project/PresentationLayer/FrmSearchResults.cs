using Class_Project.BusinessLayer;
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
 * Class Project
 * 12-9-2023
 * Citation(s):
 */
namespace Class_Project.PresentationLayer
{
    public partial class FrmSearchResults : Form
    {
        // Frm Attributes
        List<Movie> Movies;
        public FrmSearchResults(List<Movie> movies)
        {
            Movies = movies;
            InitializeComponent();
        }


        /// <summary>
        /// Method to Dispay Search Results in Grid View
        /// </summary>
        private void DisplayMovies()
        {
            foreach (Movie movie in Movies)
            {
                gvSearchResults.Rows.Add(movie.Name, movie.Rating, movie.AudienceScore, movie.Qty, movie.Price);
            }
        }


        // ##########################################################
        //                  EVENT HANDLER METHODS
        // ##########################################################

        /// <summary>
        /// Event Handler for When the Form First Loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoad_EventHandler(object sender, EventArgs e)
        {
            // DataGrid Setup
            gvSearchResults.ColumnCount = 5;
            gvSearchResults.Columns[0].Name = "Name";
            gvSearchResults.Columns[0].Width = 250;
            gvSearchResults.Columns[1].Name = "Age Rating";
            gvSearchResults.Columns[2].Name = "Audience Score";
            gvSearchResults.Columns[3].Name = "Qty";
            gvSearchResults.Columns[4].Name = "Price ($)";
            gvSearchResults.Columns[3].DefaultCellStyle.Format = "#.0";
            gvSearchResults.Columns[4].DefaultCellStyle.Format = "$#.00";

            DisplayMovies();
        }
    }
}
