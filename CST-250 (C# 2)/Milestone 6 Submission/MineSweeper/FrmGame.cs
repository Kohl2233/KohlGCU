using MineSweeperClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* ----- Sources/References -----
 * Right Click: https://stackoverflow.com/questions/19448346/how-to-get-a-right-click-mouse-event-changing-eventargs-to-mouseeventargs-cause
 * Custom Msg Box: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-8.0
 * Change Font Programmatically: https://stackoverflow.com/questions/10173147/easiest-way-to-change-font-and-font-size
 * ------------------------------
 */
namespace MineSweeper
{
    public partial class FrmGame : Form
    {
        public string Name;
        public int Difficulty;
        public int GameSize; // Used for Frm Window Size
        static public Board board; // 'Logical' Game Board
        public Button[,] BtnGrid; // Button Grid
        bool GameLost = false; // controls what image is shown
        Stopwatch stopwatch;

        Leaderboard LeaderScores = new Leaderboard();

        public FrmGame(int size, int difficulty, string name)
        {
            InitializeComponent();
            this.Difficulty = difficulty;
            this.GameSize = size;
            this.Name = name;



            // Create Button Grid and Board
            board = new Board(this.GameSize, this.Difficulty);
            BtnGrid = new Button[board.Size, board.Size];

            // Set up Board
            board.setupLiveNeighbors();
            board.calculateLiveNeighbors();

            // Set up Button Grid
            PopulateButtonGrid();

            // Setup Correct Colors and Starting Display
            UpdateButtonGrid();

            // Start Timer
            stopwatch = new Stopwatch();
            stopwatch.Start();
        }



        /// <summary>
        /// Method for Setting up the Initial Grid of Buttons
        /// </summary>
        private void PopulateButtonGrid()
        {
            // Calc Size of Buttons
            int btnSize = panelButtons.Width / board.Size;
            panelButtons.Height = panelButtons.Width;

            // Populate Button Grid
            for (int r = 0; r < board.Size; r++)
            {
                for (int c = 0; c < board.Size; c++)
                {
                    // Create new Button at Current Cell
                    BtnGrid[r, c] = new Button();

                    // Customize Button
                    BtnGrid[r, c].Width = btnSize;
                    BtnGrid[r, c].Height = btnSize;
                    if (GameSize == 6) { BtnGrid[r, c].Font = new Font("Tiktok", 24F, FontStyle.Bold); }
                    if (GameSize == 10) { BtnGrid[r, c].Font = new Font("Tiktok", 20F, FontStyle.Bold); }
                    if (GameSize == 15) { BtnGrid[r, c].Font = new Font("Tiktok", 18F, FontStyle.Bold); }
                    if (GameSize == 20) { BtnGrid[r, c].Font = new Font("Tiktok", 16F, FontStyle.Bold); }
                    BtnGrid[r, c].BackgroundImageLayout = ImageLayout.Zoom;
                    BtnGrid[r, c].MouseUp += GridButton_ClickEventHandler; // add click event handler reference
                    panelButtons.Controls.Add(BtnGrid[r, c]); // place btn on panel
                    BtnGrid[r, c].Location = new Point(btnSize * r, btnSize * c); // pos it in x, y

                    // Tag Attribute holds [r, c]
                    BtnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();
                }
            }
        }



        /// <summary>
        /// Mouse Up Event Handler for Grid Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridButton_ClickEventHandler(object? sender, EventArgs e)
        {
            // Cast EventArg (e) as MouseEventArg, store in mouseEvent var
            MouseEventArgs mouseEvent = (MouseEventArgs)e;

            // Get Row and Column
            string[] strArr = (sender as Button).Tag.ToString().Split("|");
            int row = int.Parse(strArr[0]);
            int col = int.Parse(strArr[1]);

            // Get Cell from Board
            Cell clickedCell = board.CellGrid[row, col];

            // Check Type of Click Event
            if (mouseEvent.Button == MouseButtons.Left)
            {
                // Left Click
                // Make Sure it is 'New' Cell (hasn't been clicked)
                if (!clickedCell.IsDiscovered)
                {
                    if (!clickedCell.IsLive)
                    {
                        // It is a Safe Cell, Mark as Discovered
                        clickedCell.IsDiscovered = true;

                        // Call Flood Fill Check
                        board.floodFill(row, col);

                        // Check Game Condition
                        if (AllSafeCellsFound())
                        {
                            // Reveal Board
                            GameLost = false;
                            RevealAllCells();
                            UpdateButtonGrid();

                            // Display Win Msg Box
                            stopwatch.Stop();
                            timerHeader.Stop();
                            if (Difficulty != 5)
                            {
                                // Do Not add Score to Leaderboard if on Safe Mode
                                PlayerStats p = new PlayerStats(Name, Difficulty, stopwatch.Elapsed.TotalSeconds);
                                LeaderScores.AddNewPlayerStats(p);
                            }

                            string msg = String.Format("You Win!!\n\nTime Taken: {0:mm\\:ss}\n\nWould you like to check the Leaderboard?", stopwatch.Elapsed);
                            string caption = "End of Game";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;

                            result = MessageBox.Show(msg, caption, buttons);
                            if (result == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                                FrmLeaderboard frmLeaderboard = new FrmLeaderboard(LeaderScores);
                                frmLeaderboard.ShowDialog();
                            }
                        }

                        // Call UpdateButtonGrid
                        UpdateButtonGrid();

                    }
                    else
                    {
                        // It is a Bomb Cell, Mark as Discovered, End Game
                        clickedCell.IsDiscovered = true;
                        GameLost = true;
                        (sender as Button).BackgroundImage = Properties.Resources.sprBomb;
                        RevealAllCells();
                        UpdateButtonGrid();

                        // Display Fail Msg Box
                        stopwatch.Stop();
                        timerHeader.Stop();
                        string msg = "GAME OVER!\n\nBetter luck next time rookie.";
                        string caption = "End of Game";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(msg, caption, buttons);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                            FrmLeaderboard frmLeaderBoard = new FrmLeaderboard(LeaderScores);
                            frmLeaderBoard.ShowDialog();
                        }
                    }
                }
            }

            // Right Click
            if (mouseEvent.Button == MouseButtons.Right)
            {
                if ((sender as Button).BackgroundImage == Properties.Resources.sprFlag)
                {
                    // Remove Flag
                    (sender as Button).BackgroundImage = null;
                }
                else
                {
                    // Add Flag
                    (sender as Button).BackgroundImage = Properties.Resources.sprFlag;
                }
            }
        }



        /// <summary>
        /// Method to Reveal all Cells (used when user loses)
        /// </summary>
        private void RevealAllCells()
        {
            // Cycle through Board
            for (int r = 0; r < board.Size; r++)
            {
                for (int c = 0; c < board.Size; c++)
                {
                    board.CellGrid[r, c].IsDiscovered = true;
                }
            }
        }



        /// <summary>
        /// Function Used to Check if Game is Won
        /// </summary>
        /// <returns></returns>
        private bool AllSafeCellsFound()
        {
            bool allSafeFound = true;
            bool finishedScan = false;

            while (allSafeFound && !finishedScan)
            {
                for (int r = 0; r < board.Size; r++)
                {
                    for (int c = 0; c < board.Size; c++)
                    {
                        if (!board.CellGrid[r, c].IsDiscovered && !board.CellGrid[r, c].IsLive)
                        {
                            allSafeFound = false;
                        }
                    }
                }
                finishedScan = true;
            }

            return allSafeFound;
        }



        /// <summary>
        /// Method to Update Button Grid GUI
        /// </summary>
        private void UpdateButtonGrid()
        {
            // Cycle Through Board Cell Grid
            for (int r = 0; r < board.Size; r++)
            {
                for (int c = 0; c < board.Size; c++)
                {
                    if (board.CellGrid[r, c].IsDiscovered)
                    {
                        // Check if Live
                        if (!board.CellGrid[r, c].IsLive)
                        {
                            // Remove Background Image (if any)
                            BtnGrid[r, c].BackgroundImage = null;

                            // Check Cell Num Neighbors
                            if (board.CellGrid[r, c].NumLiveNeighbors > 0)
                            {
                                // Discovered Cell w/ Live Neighbors
                                BtnGrid[r, c].Text = board.CellGrid[r, c].NumLiveNeighbors.ToString();
                                //BtnGrid[r, c].BackColor = Color.Yellow;
                            }
                            else
                            {
                                // Discovered Cell w/ no Live Neighbors
                                //BtnGrid[r, c].Text = "0";
                                BtnGrid[r, c].BackColor = Color.LightBlue;
                            }
                        }
                        else
                        {
                            // Discovered Cell/Btn is a Bomb
                            if (GameLost)
                            {
                                // Display Bomb Picture
                                BtnGrid[r, c].BackgroundImage = Properties.Resources.sprBomb;
                            }
                            else
                            {
                                // Display Mark Flag
                                BtnGrid[r, c].BackgroundImage = Properties.Resources.sprFlag;
                            }
                        }
                    }
                    else
                    {
                        // Cell is Not Discovered
                        //BtnGrid[r, c].Text = "?";
                        //BtnGrid[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }

        private void TimerHeader_Tick(object sender, EventArgs e)
        {
            // Create Temp PlayerStats
            PlayerStats temp = new PlayerStats(Name, Difficulty, stopwatch.Elapsed.TotalSeconds);
            string header = String.Format("Time: {0:mm\\:ss}", stopwatch.Elapsed);
            lblHeader.Text = header;
        }
    }
}
