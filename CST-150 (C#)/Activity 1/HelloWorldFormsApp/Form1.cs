/*
 * Kohl Johnson
 * CST-150
 * Activity 1
 * 10-27-2023
 * Citations: 
 */

namespace HelloWorldFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create an event handler for the click here button
        /// Method name must be PascalCasing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOnClick(object sender, EventArgs e)
        {
            lblHelloWorldLabel.Text = "Hello World!!"; // set text of label to Hello World
        }
    }
}