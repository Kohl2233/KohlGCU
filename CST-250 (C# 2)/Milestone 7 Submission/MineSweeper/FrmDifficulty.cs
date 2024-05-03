namespace MineSweeper
{
    public partial class FrmDifficulty : Form
    {
        int Difficulty = 0;
        public FrmDifficulty()
        {
            InitializeComponent();
            btnStart.Enabled = false;
        }



        /// <summary>
        /// Checked Value Changed Event Handler for Easy Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxEasy_CheckedChangedEventHandler(object sender, EventArgs e)
        {
            // Check 'Checked' Property
            if (cboxEasy.Checked)
            {
                // Disable all Other Difficulty Checkboxes
                cBoxSafe.Enabled = false;
                cboxModerate.Enabled = false;
                cboxHard.Enabled = false;
                cboxNightmare.Enabled = false;

                // Enable Start Button
                btnStart.Enabled = true;

                // Update Difficutly
                Difficulty = 1;
            }
            else
            {
                // Make sure all others are Enabled
                cBoxSafe.Enabled = true;
                cboxModerate.Enabled = true;
                cboxHard.Enabled = true;
                cboxNightmare.Enabled = true;

                // Disable Start Button
                btnStart.Enabled = false;
            }
        }



        /// <summary>
        /// Checked Value Changed Event Handler for Moderate Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxModerate_CheckedChangedEventHandler(object sender, EventArgs e)
        {
            // Check 'Checked' Property
            if (cboxModerate.Checked)
            {
                // Disable all Other Difficulty Checkboxes
                cBoxSafe.Enabled = false;
                cboxEasy.Enabled = false;
                cboxHard.Enabled = false;
                cboxNightmare.Enabled = false;

                // Enable Start Button
                btnStart.Enabled = true;

                // Update Difficutly
                Difficulty = 2;
            }
            else
            {
                // Make sure all others are Enabled
                cBoxSafe.Enabled = true;
                cboxEasy.Enabled = true;
                cboxHard.Enabled = true;
                cboxNightmare.Enabled = true;

                // Disable Start Button
                btnStart.Enabled = false;
            }
        }



        /// <summary>
        /// Checked Value Changed Event Handler for Hard Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxHard_CheckedChangedEventHandler(object sender, EventArgs e)
        {
            // Check 'Checked' Property
            if (cboxHard.Checked)
            {
                // Disable all other Difficulty Checkboxes
                cBoxSafe.Enabled = false;
                cboxEasy.Enabled = false;
                cboxModerate.Enabled = false;
                cboxNightmare.Enabled = false;

                // Enable Start Button
                btnStart.Enabled = true;

                // Update Difficutly
                Difficulty = 3;
            }
            else
            {
                // Make sure all others are Enabled
                // Disable all other Difficulty Checkboxes
                cBoxSafe.Enabled = true;
                cboxEasy.Enabled = true;
                cboxModerate.Enabled = true;
                cboxNightmare.Enabled = true;

                // Disable Start Button
                btnStart.Enabled = false;
            }
        }



        /// <summary>
        /// Checked Value Changed Event Handler for Nightmare Checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxNightmare_CheckedChangedEventHandler(object sender, EventArgs e)
        {
            // Check 'Checked' Property
            if (cboxNightmare.Checked)
            {
                // Disable all other Difficulty Checkboxes
                cBoxSafe.Enabled = false;
                cboxEasy.Enabled = false;
                cboxModerate.Enabled = false;
                cboxHard.Enabled = false;

                // Enable Start Button
                btnStart.Enabled = true;

                // Update Difficutly
                Difficulty = 4;
            }
            else
            {
                // Make sure all others are Enabled
                cBoxSafe.Enabled = true;
                cboxEasy.Enabled = true;
                cboxModerate.Enabled = true;
                cboxHard.Enabled = true;

                // Disable Start Button
                btnStart.Enabled = false;
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxSafe_CheckedChangedEventHandler(object sender, EventArgs e)
        {
            // Check 'Checked' Property
            if (cBoxSafe.Checked)
            {
                // Disable all other Difficulty Checkboxes
                cboxEasy.Enabled = false;
                cboxModerate.Enabled = false;
                cboxHard.Enabled = false;
                cboxNightmare.Enabled = false;

                // Enable Start Button
                btnStart.Enabled = true;

                // Update Difficutly
                Difficulty = 5;
            }
            else
            {
                // Make sure all others are Enabled
                cboxEasy.Enabled = true;
                cboxModerate.Enabled = true;
                cboxHard.Enabled = true;
                cboxNightmare.Enabled = true;

                // Disable Start Button
                btnStart.Enabled = false;
            }
        }



        /// <summary>
        /// Click Event Handler for btnStart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_ClickEventHandler(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                lblName.ForeColor = Color.Black;

                // Load Game with Selected Difficulty and Map Size
                int size = 0;
                switch (comBoxSize.Text)
                {
                    case "Small": size = 5; break; // 25 total
                    case "Large": size = 10; break; // 100 total
                    case "Huge": size = 15; break; // 225 total
                    case "Gigantic": size = 20; break; // 400 total
                    default: size = 10; break;
                }
                FrmGame frmGame = new FrmGame(size, Difficulty, txtName.Text);
                frmGame.ShowDialog();
            }
            else
            {
                lblName.ForeColor = Color.Red;
            }
        }
    }
}