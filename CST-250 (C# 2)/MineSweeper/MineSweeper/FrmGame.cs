using MineSweeperClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class FrmGame : Form
    {
        public int Difficulty;
        static public Board board; // 'Logical' Game Board
        public Button[,] BtnGrid; // Button Grid

        public FrmGame(int difficulty)
        {
            InitializeComponent();
            this.Difficulty = difficulty;

            // Create Button Grid and Board
            board = new Board(10, this.Difficulty);
            BtnGrid = new Button[board.Size, board.Size];

            // Set up Board
            board.setupLiveNeighbors();
            board.calculateLiveNeighbors();

            // Set up Button Grid
            PopulateButtonGrid();

            // Setup Correct Colors and Starting Display
            UpdateButtonGrid();
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

                    BtnGrid[r, c].Click += GridButton_ClickEventHandler;
                    panelButtons.Controls.Add(BtnGrid[r, c]); // place btn on panel
                    BtnGrid[r, c].Location = new Point(btnSize * r, btnSize * c); // pos it in x, y

                    // Tag Attribute holds [r, c]
                    BtnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();
                }
            }
        }



        /// <summary>
        /// Click Event Handler for Grid Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridButton_ClickEventHandler(object? sender, EventArgs e)
        {
            // Get Row and Column
            string[] strArr = (sender as Button).Tag.ToString().Split("|");
            int row = int.Parse(strArr[0]);
            int col = int.Parse(strArr[1]);

            // Get Cell from Board
            Cell clickedCell = board.CellGrid[row, col];
            if (!clickedCell.IsLive)
            {
                // It is a Safe Cell, Mark as Discovered
                clickedCell.IsDiscovered = true;

                // Call Flood Fill Check
                board.floodFill(row, col);

                // Call UpdateButtonGrid
                UpdateButtonGrid();

            }
            else
            {
                // It is a Bomb Cell, Mark as Discovered (this will end the game in the future)
                clickedCell.IsDiscovered = true;
                (sender as Button).Text = "BOMB!";
                UpdateButtonGrid();
            }

        }



        /// <summary>
        /// Method to Update Button Grid GUI
        /// </summary>
        private void UpdateButtonGrid()
        {
            // Cycle Through Board Cell Grid
            for (int r = 0; r < board.Size; r++)
            {
                for (int c =  0; c < board.Size; c++)
                {
                    if (board.CellGrid[r, c].IsDiscovered)
                    {
                        if (!board.CellGrid[r, c].IsLive)
                        {
                            if (board.CellGrid[r, c].NumLiveNeighbors > 0)
                            {
                                BtnGrid[r, c].Text = board.CellGrid[r, c].NumLiveNeighbors.ToString();
                                BtnGrid[r, c].BackColor = Color.Yellow;
                            }
                            else
                            {
                                BtnGrid[r, c].Text = "";
                                BtnGrid[r, c].BackColor = Color.Green;
                            }
                        } else
                        {
                            BtnGrid[r, c].BackColor = Color.Red;
                        }
                    } else
                    {
                        BtnGrid[r, c].Text = "?";
                        BtnGrid[r, c].BackColor = Color.Gray;
                    }
                }
            }
        }
    }
}
