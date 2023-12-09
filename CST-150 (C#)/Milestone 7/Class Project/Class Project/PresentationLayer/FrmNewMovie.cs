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
 * 12-3-2023
 * Citation(s):
 */
namespace Class_Project.PresentationLayer
{
    public partial class FrmNewMovie : Form
    {
        FrmMain MainForm;
        public FrmNewMovie(FrmMain mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;

            // Set Error Messages to Hidden
            lblErrorName.Visible = false;
            lblErrorPrice.Visible = false;
            lblErrorRuntime.Visible = false;
            lblErrorQuantity.Visible = false;
            lblErrorReleaseYear.Visible = false;
            lblErrorRating.Visible = false;
            lblErrorScore.Visible = false;
        }


        // ##########################################################
        //                  EVENT HANDLER METHODS
        // ##########################################################

        /// <summary>
        /// Method to Handle All Logic with Creating New Movie (will break apart into seperate methods later on)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_ClickEventHandler(object sender, EventArgs e)
        {
            // Variable Declration
            Movie newMovie;
            string name = "";
            string description = "";
            float price;
            int runtime;
            int quantity;
            string releaseYear = "";
            string rating = "";
            int audienceScore;

            int errorCount = 0;

            // Input Validation
            // Movie Name
            if (txtName.Text != "")
            {
                name = txtName.Text;
                lblErrorName.Visible = false;
            }
            else
            {
                lblErrorName.Text = "This can not be blank.";
                lblErrorName.Visible = true;
                errorCount += 1;
            }

            // Movie Descripion
            if (txtDescription.Text == "")
            {
                description = "No description given.";
            }
            else
            {
                description = txtDescription.Text;
            }

            // Movie Price
            if (!float.TryParse(txtPrice.Text, out price))
            {
                lblErrorPrice.Text = "Please enter a valid price.";
                lblErrorPrice.Visible = true;
                errorCount += 1;
            }
            else
            {
                lblErrorPrice.Visible = false;
            }

            // Movie Runtime
            if (!int.TryParse(txtRuntime.Text, out runtime))
            {
                lblErrorRuntime.Text = "Please enter a valid number.";
                lblErrorRuntime.Visible = true;
                errorCount += 1;
            }
            else
            {
                if (runtime < 1)
                {
                    lblErrorRuntime.Text = "Number must be greater than 0.";
                    lblErrorRuntime.Visible = true;
                    errorCount += 1;
                }
                else
                {
                    lblErrorRuntime.Visible = false;
                }
            }

            // Movie Quantity
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                lblErrorQuantity.Text = "Please enter a valid number.";
                lblErrorQuantity.Visible = true;
                errorCount += 1;
            }
            else
            {
                if (quantity < 1)
                {
                    lblErrorQuantity.Text = "Number must be greater than 0.";
                    lblErrorQuantity.Visible = true;
                    errorCount += 1;
                }
                else
                {
                    lblErrorQuantity.Visible = false;
                }
            }

            // Movie Release Year
            int testYear;
            if (!int.TryParse(txtReleaseYear.Text, out testYear))
            {
                lblErrorReleaseYear.Text = "Please enter a valid year.";
                lblErrorReleaseYear.Visible = true;
                errorCount += 1;
            }
            else
            {
                releaseYear = txtReleaseYear.Text;
                lblErrorReleaseYear.Visible = false;
            }

            // Movie Parental Guideance Rating
            if (cbRating.Text == "")
            {
                lblErrorRating.Text = "Please select a rating.";
                lblErrorRating.Visible = true;
            }
            else
            {
                rating = cbRating.Text;
                lblErrorRating.Visible = false;
            }


            // Movie Audience Score
            if (!int.TryParse(txtScore.Text, out audienceScore))
            {
                lblErrorScore.Text = "Please enter a valid number.";
                lblErrorScore.Visible = true;
                errorCount += 1;
            }
            else
            {
                if ((audienceScore < 1) || (audienceScore > 10))
                {
                    lblErrorScore.Text = "Number must be between 1 and 10.";
                    lblErrorScore.Visible = true;
                    errorCount += 1;
                }
                else
                {
                    lblErrorScore.Visible = false;
                }
            }

            // Movie Creation
            if (errorCount < 1)
            {
                // Use Default Constructor
                newMovie = new Movie();
                newMovie.Name = name;
                newMovie.Description = description;
                newMovie.Qty = quantity;
                newMovie.Price = price;
                newMovie.ReleaseDate = releaseYear;
                newMovie.Runtime = runtime;
                newMovie.Rating = rating;
                newMovie.AudienceScore = audienceScore;

                // Pass to Main Form
                MainForm.AddNewMovie(newMovie);
                this.Close();
            }
        }


        /// <summary>
        /// Event Handler for Clear Form Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearForm_ClickEventHandler(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
            txtRuntime.Text = "";
            txtQuantity.Text = "";
            txtReleaseYear.Text = "";
            cbRating.Text = "";
            lblAudienceScore.Text = "";
        }
    }
}
