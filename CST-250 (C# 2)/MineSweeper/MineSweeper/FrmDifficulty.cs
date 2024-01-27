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
        /// Utility Function to Get String Value of Difficulty Int
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private String GetDifficultyString(int num)
        {
            switch (num)
            {
                case 1: return "Easy";
                case 2: return "Moderate";
                case 3: return "Hard";
                case 4: return "Nightmare";
                default: return "Not Valid Difficutly Int";
            }
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
                cboxEasy.Enabled = true;
                cboxModerate.Enabled = true;
                cboxHard.Enabled = true;

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
            // Load Game with Selected Difficulty
            FrmGame frmGame = new FrmGame(Difficulty);
            frmGame.ShowDialog();

        }
    }
}