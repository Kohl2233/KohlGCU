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
    public partial class FrmLeaderboard : Form
    {
        Leaderboard HighScores;
        public FrmLeaderboard(Leaderboard highScores)
        {
            InitializeComponent();
            HighScores = highScores;
            PopulateLabelGrid();
            lblFilePath.Text = HighScores.FilePath;
        }



        /// <summary>
        /// Method to Create 'Grid' of Labels to Display Game Stats
        /// </summary>
        private void PopulateLabelGrid()
        {
            int lblSizeWidth = panelScores.Width / 2; // two labels wide
            int lblSizeHeight = panelScores.Height / 5; // five labels tall (for max 5 scores)

            Label[,] labelGrid = new Label[2, 5];

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (c < HighScores.HighScores.Count)
                    {
                        if (r == 0)
                        {
                            // Create Name Labels (left side)
                            labelGrid[r, c] = new Label();
                            labelGrid[r, c].AutoSize = false;
                            labelGrid[r, c].Width = lblSizeWidth;
                            labelGrid[r, c].Height = lblSizeHeight;
                            labelGrid[r, c].Text = HighScores.HighScores[c].Name;
                            labelGrid[r, c].TextAlign = ContentAlignment.MiddleLeft;
                            panelScores.Controls.Add(labelGrid[r, c]);
                            labelGrid[r, c].Location = new Point(r * lblSizeWidth, c * lblSizeHeight);
                            labelGrid[r, c].ForeColor = Color.Green;
                            if (c == 0) { labelGrid[r, c].ForeColor = Color.Gold; } // if top score

                        }
                        else
                        {
                            // Create Score Labels (right side)
                            labelGrid[r, c] = new Label();
                            labelGrid[r, c].AutoSize = false;
                            labelGrid[r, c].Width = lblSizeWidth;
                            labelGrid[r, c].Height = lblSizeHeight;
                            labelGrid[r, c].Text = FormatTimeScore(HighScores.HighScores[c]);
                            labelGrid[r, c].TextAlign = ContentAlignment.MiddleRight;
                            panelScores.Controls.Add(labelGrid[r, c]);
                            labelGrid[r, c].Location = new Point(r * lblSizeWidth, c * lblSizeHeight);
                            labelGrid[r, c].ForeColor = Color.Green;
                            if (c == 0) { labelGrid[r, c].ForeColor = Color.Gold; } // if top score
                        }
                    }
                }
            }
        }



        /// <summary>
        /// Utility Function to Format Time and Score (Right Side Label)
        /// </summary>
        /// <param name="stats"></param>
        /// <returns></returns>
        private string FormatTimeScore(PlayerStats stats)
        {
            // Add Difficulty String
            string diff = "";
            switch (stats.Difficulty)
            {
                case 1: diff = "+"; break;
                case 2: diff = "++"; break;
                case 3: diff = "+++"; break;
                case 4: diff = "++++"; break;
                default: diff = "N/A"; break;
            }

            // Combine and Return
            return String.Format("{0}, {1}s, {2}", diff, stats.TotalSeconds, Math.Ceiling(stats.Score));
        }
    }
}
