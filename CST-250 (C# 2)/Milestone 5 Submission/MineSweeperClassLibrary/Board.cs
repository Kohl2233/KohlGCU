using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClassLibrary
{
    public class Board
    {
        // Attributes/Properties
        public int Size { get; set; } // size of board
        public Cell[,] CellGrid { get; set; } // holds Cells
        public int Difficulty { get; set; } // percent of CellGrid with live cells
        


        // Parameterized Constructor
        public Board(int size, int difficulty)
        {
            this.Size = size;
            this.CellGrid = populateCellGrid(this.Size);
            switch (difficulty)
            {
                case 1: this.Difficulty = 5; break;
                case 2: this.Difficulty = 10; break;
                case 3: this.Difficulty = 15; break;
                case 4: this.Difficulty = 20; break;
                case 5: this.Difficulty = 2; break;
            }
        }



        /// <summary>
        /// Private Utility Method to Populate CellGrid with Cell Objects
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        private static Cell[,] populateCellGrid(int size)
        {
            // Local Var(s)
            Cell[,] grid = new Cell[size, size];

            // Populate Grid
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    grid[x, y] = new Cell(new int[] { x, y }, false, false, 0);
                }
            }

            // Return Grid
            return grid;
        }



        /// <summary>
        /// Public Method to Populate Grid With Random Live Cells
        /// </summary>
        public void setupLiveNeighbors()
        {
            // Local Var(s)
            int totalCells;
            int numLiveCells;
            double numLiveCellsDouble;

            // Setup Difficulty
            totalCells = this.Size * this.Size;
            Console.WriteLine("\nTotal Cells: " + totalCells);
            Console.WriteLine("Difficulty: " + this.Difficulty + "%");
            numLiveCellsDouble = totalCells * ((double)Difficulty / 100);
            numLiveCells = Convert.ToInt32(numLiveCellsDouble);
            Console.WriteLine("Number of Bombs to Plant: " + numLiveCells.ToString());

            // Create Random Bombs
            for (int bombs = numLiveCells; bombs > 0; bombs--)
            {
                // Choose Valid Random Cell
                bool valid = false;
                int xCord = -1;
                int yCord = -1;
                int timesTried = 0;
                while (!valid && timesTried < 5000)
                {
                    Random randy = new Random();
                    xCord = randy.Next(0, this.Size - 1);
                    yCord = randy.Next(0, this.Size - 1);

                    // Check if Cell is NOT Live AND if adjacent cells are NOT bobms (if so we choose a different cell)
                    if (this.CellGrid[xCord, yCord].IsLive == false)
                    {
                        if (AdjacentSidesClear(xCord, yCord))
                        {
                            valid = true;
                        }
                    }
                    timesTried++;
                }
                
                // Set Selected Cell to Live
                this.CellGrid[xCord, yCord].IsLive = true;
            }
        }



        /// <summary>
        /// Utility Method to Check if Prospect Bomb Spawn is Not Touching other Bomb Cells
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns></returns>
        private bool AdjacentSidesClear(int row, int col)
        {
            bool isClear = true;
            int[,] positions = new int[8, 2];

            // Add row, col to positions
            positions[0, 0] = row; positions[0, 1] = col - 1; // top
            positions[1, 0] = row; positions[1, 1] = col + 1; // bottom
            positions[2, 0] = row - 1; positions[2, 1] = col; // left
            positions[3, 0] = row + 1; positions[3, 1] = col; // right

            positions[4, 0] = row - 1; positions[4, 1] = col - 1; // top left
            positions[5, 0] = row + 1; positions[5, 1] = col - 1; // top right
            positions[6, 0] = row - 1; positions[6, 1] = col + 1; // bottom left
            positions[7, 0] = row + 1; positions[7, 1] = col + 1; // bottom right
            
            // Check Positions
            for (int i = 0; i < 8; i++)
            {
                int xCord = positions[i, 0];
                int yCord = positions[i, 1];

                // Check if Valid
                if (isValidCell(xCord, yCord))
                {
                    // Check if Clear
                    if (CellGrid[xCord, yCord].IsLive)
                    {
                        isClear = false;
                    }
                }
            }

            return isClear;
        }



        /// <summary>
        /// Public Method to Calculate NumLiveNeighbors for All Cells
        /// </summary>
        /// <param name="cell"></param>
        public void calculateLiveNeighbors()
        {
            foreach (Cell cell in this.CellGrid)
            {
                // Local Var(s)
                int[,] positions = new int[8, 2];

                // Check if Current Cell is Live
                if (!cell.IsLive)
                {
                    // Get Adjacent Cell Positions
                    positions[0, 0] = cell.Position[0] - 1; positions[0, 1] = cell.Position[1] - 1; // top left cell
                    positions[1, 0] = cell.Position[0]; positions[1, 1] = cell.Position[1] - 1; // top center cell
                    positions[2, 0] = cell.Position[0] + 1; positions[2, 1] = cell.Position[1] - 1; // top right cell
                    positions[3, 0] = cell.Position[0] - 1; positions[3, 1] = cell.Position[1]; // center left cell
                    positions[4, 0] = cell.Position[0] + 1; positions[4, 1] = cell.Position[1]; // center right cell
                    positions[5, 0] = cell.Position[0] - 1; positions[5, 1] = cell.Position[1] + 1; // bottom left cell
                    positions[6, 0] = cell.Position[0]; positions[6, 1] = cell.Position[1] + 1; // bottom center cell
                    positions[7, 0] = cell.Position[0] + 1; positions[7, 1] = cell.Position[1] + 1; // bottom right cell

                    // Check if Valid
                    for (int i = 0; i < 8; i++)
                    {
                        int xCord = positions[i, 0];
                        int yCord = positions[i, 1];
                        
                        if (isValidCell(xCord, yCord))
                        {
                            // Check if Cell is Live
                            Cell c = this.CellGrid[xCord, yCord];
                            if (c.IsLive)
                            {
                                cell.NumLiveNeighbors++;
                            }
                        }
                    }
                } else
                {
                    cell.NumLiveNeighbors = 9;
                }
            }
        }



        /// <summary>
        /// Private Utility Method to Check if Cell Pos is Valid (used for checking live neighbors)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool isValidCell(int x, int y)
        {
            if ((x >= 0) && (x < this.Size) && (y >= 0) && (y < this.Size))
            {
                return true;
            } else
            {
                return false;
            }
        }



        /// <summary>
        /// Function to Recursivly 'Fill' Area of Cells with No Live Neighbors
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        public void floodFill(int row, int col)
        {
            ArrayList floodCells = new ArrayList();

            // Check if Selected Cell has Live Neighbors
            if (CellGrid[row, col].NumLiveNeighbors == 0) 
            {
                // Get all Surrounding Cells
                if (isValidCell(row, col - 1)) { floodCells.Add(CellGrid[row, col - 1]); } // top center

                if (isValidCell(row - 1, col)) { floodCells.Add(CellGrid[row - 1, col]); } // middle left
                if (isValidCell(row + 1, col)) { floodCells.Add(CellGrid[row + 1, col]); } // middle right
                
                if (isValidCell(row, col + 1)) { floodCells.Add(CellGrid[row, col + 1]); } // bottom center

                // Cycle through Each Cell, Check Live Neighbors
                foreach (Cell cell in floodCells)
                {
                    if (!cell.IsDiscovered) 
                    {
                        cell.IsDiscovered = true;
                        this.floodFill(cell.Position[0], cell.Position[1]); 
                    }
                }
            }  
        }
    }
}
