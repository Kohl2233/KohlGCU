/* Kohl Johnson
 * CST-150
 * Activity 2
 * 11-3-2023
 * Citation(s): 
 */

using System.CodeDom;

namespace CST_150_Activity_2
{
    public partial class FrmSeconds : Form
    {
        public FrmSeconds()
        {
            InitializeComponent();
            lblResults.Visible = false; // set results label to not visible
        }

        /// <summary>
        /// Event Handler for Evauluating Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            // Declarations/Initialize
            int seconds = 0;
            const int SecondsInMinutes = 60;
            const int SecondsInHours = 3600;
            const int SecondsInDays = 86400;

            lblResults.Visible = false;
            lblResults.ForeColor = Color.Black;

            if (int.TryParse(txtUserEntry.Text, out seconds))
            {
                // Check Minutes
                if (seconds >= SecondsInMinutes)
                {
                    lblResults.Text = string.Format("There are {0:#,#} mintutes in {1:#,#} seconds.\n", seconds / SecondsInMinutes, seconds);
                    lblResults.Visible = true;
                    
                    // Check Hours
                    if (seconds >= SecondsInHours)
                    {
                        lblResults.Text += string.Format("There are {0:#,#} hours in {1:#,#} seconds.\n", seconds / SecondsInHours, seconds);

                        // Check Days
                        if (seconds >= SecondsInDays)
                        {
                            lblResults.Text += string.Format("There are {0:#,#} days in {1: #,#} seconds.\n", seconds / SecondsInDays, seconds);
                        }
                    }
                } else
                {
                    // Input Validation for value greater than 59
                    lblResults.Text = "Please enter an int greater than 59.";
                    lblResults.ForeColor = Color.Red;
                    lblResults.Visible = true;
                }
            } else
            {
                // Displayed if No Input/Incorrect Type (decimal, word, etc.)
                lblResults.Text = "Please enter an int to continue...";
                lblResults.ForeColor = Color.Red;
                lblResults.Visible = true;
            }
        }
    }
}