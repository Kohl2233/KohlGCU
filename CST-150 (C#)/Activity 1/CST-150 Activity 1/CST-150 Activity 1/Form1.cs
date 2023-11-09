/* Kohl Johnson
 * CST-150
 * Activity 1 Part 3
 * 10-27-2023
 * Citation(s):
 */

namespace CST_150_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblMars.Visible = false; // make lblMars hidden
            lblMarsWeight.Visible = false; // make lblMarsWeight hidden

        }

        /// <summary>
        /// Click Event for Convert Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButtonClickEvent(object sender, EventArgs e)
        {
            // Variable Declarations/Initilizing
            decimal earthWeight = 0.0M;
            decimal finalValue = 0.0M;
            decimal gravAccEarth = 9.81M;
            decimal gravAccMars = 3.711M;

            // Read User Input from txtEarthWeight
            earthWeight = Convert.ToDecimal(txtEarthWeight.Text);

            // Final Value Calculation
            finalValue = (earthWeight / gravAccEarth) * gravAccMars;

            // Display Results
            lblMarsWeight.Text = string.Format("{0:.##} lbs", finalValue);

            // Make lbl's Visible
            lblMars.Visible = true;
            lblMarsWeight.Visible = true;
        }
    }
}