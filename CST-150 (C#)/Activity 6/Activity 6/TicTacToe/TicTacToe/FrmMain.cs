using System.Drawing.Text;
/* Kohl Johnson
 * CST-150
 * Activity 6
 * 12-03-2023
 * Citation(s):
 */
namespace TicTacToe
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblResults.Visible = false; // set results label to hidden
        }

        private void BtnNewGame_ClickEventHandler(object sender, EventArgs e)
        {
            // Variable Declaration/Initilization
            int[,] values = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0, } }; // will hold int values
            string[,] symbols = { { "X", "X", "X" }, { "X", "X", "X"}, { "X", "X", "X"}, }; // will hold string values

            // Populate Both Arrays
            Random randy = new Random();
            for (int col = 0; col < 3; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    values[col, row] = randy.Next(2); // Populate 'Cell' With Random Int (0-1)
                    if (values[col, row] == 0) { symbols[col, row] = "X";} else { symbols[col, row] = "O";} // Set Symbol
                }
            }

            // Find Who Won (Horizontal)
            int playerXScore = 0;
            int playerOScore = 0;
            
            for (int col = 0; col < 3; col++)
            {
                int xCount = 0;
                int oCount = 0;
                for (int row = 0; row < 3; row++)
                {
                    if (values[col, row] == 0) { xCount++; } else { oCount++; }
                }
                if (xCount == 3) { playerXScore++; }
                if (oCount == 3) { playerOScore++; }
            }

            // Find Who Won (Vertical)
            for (int row = 0; row < 3; row++)
            {
                int xCount = 0;
                int oCount = 0;
                for (int col = 0; col < 3; col++)
                {
                    if (values[row, col] == 0) { xCount++; } else { oCount++; }
                }
                if (xCount == 3) { playerXScore++; }
                if (oCount == 3) { playerOScore++; }
            }

            // Find Who Won (Diagnol)
            if ((values[0,0] == 0) && (values[1, 1] == 0) && values[2, 2] == 0)
            {
                playerXScore++;
            } else if ((values[0, 0] == 1) && (values[1, 1] == 1) && values[2, 2] == 1)
            {
                playerOScore++;
            }

            if ((values[2, 0] == 0) && (values[1, 1] == 0) && values[0, 2] == 0)
            {
                playerXScore++;
            } else if ((values[2, 0] == 1) && (values[1, 1] == 1) && values[0, 2] == 1)
            {
                playerOScore++;
            }

            // Display Results
            lblResults.Visible = true;
            if (playerXScore > playerOScore)
            {
                lblResults.Text = "Player X Won!";
            } else if (playerOScore > playerXScore)
            {
                lblResults.Text = "Player O Won!";
            } else
            {
                lblResults.Text = "It's a Draw!!";
            }

            lblResults.Text += "Score X: " + playerXScore.ToString() + " Score O: " + playerOScore.ToString();

            // Set Display Labels
            lblTopLeft.Text = symbols[0, 0];
            lblTopCenter.Text = symbols[0, 1];
            lblTopRight.Text = symbols[0, 2];

            lblMiddleLeft.Text = symbols[1, 0];
            lblMiddleCenter.Text = symbols[1, 1];
            lblMiddleRight.Text = symbols[1, 2];

            lblBottomLeft.Text = symbols[2, 0];
            lblBottomCenter.Text = symbols[2, 1];
            lblBottomRight.Text = symbols[2, 2];
        }
    }
}