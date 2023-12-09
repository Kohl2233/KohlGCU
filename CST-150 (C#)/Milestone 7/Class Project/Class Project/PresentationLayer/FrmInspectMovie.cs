using Class_Project.BusinessLayer;
using Microsoft.VisualBasic.Devices;
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
    public partial class FrmInspectMovie : Form
    {
        // Form Attributes
        Movie InspectedMovie;
        public FrmInspectMovie(Movie movie)
        {
            InspectedMovie = movie;
            InitializeComponent();
        }


        /// <summary>
        /// Method to Display Movie Details
        /// </summary>
        private void DisplayMovieDetails()
        {
            lblName.Text = InspectedMovie.Name;
            lblDescription.Text = InspectedMovie.Description;
            lblPrice.Text = String.Format("{0:C2}", InspectedMovie.Price);
            lblQuantity.Text = String.Format("{0:N1}", InspectedMovie.Qty);
            lblRuntime.Text = String.Format("{0} min", InspectedMovie.Runtime);
            lblReleaseDate.Text = InspectedMovie.ReleaseDate;
            lblRating.Text = InspectedMovie.Rating;
            lblScore.Text = String.Format("{0:N1}/10", InspectedMovie.AudienceScore);
        }


        // ##########################################################
        //                  EVENT HANDLER METHODS
        // ##########################################################

        /// <summary>
        /// Event Handler for Form Loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFormLoadEventHandler(object sender, EventArgs e)
        {
            DisplayMovieDetails();
        }


        /// <summary>
        /// BtnBackToDisplay Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackDisplay_ClickEventHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
