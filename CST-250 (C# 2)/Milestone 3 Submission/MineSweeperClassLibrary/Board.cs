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
        public Board(int size)
        {
            this.Size = size;
            this.CellGrid = populateCellGrid(this.Size);
            this.Difficulty = 10;
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

            // Setup Difficulty
            totalCells = this.Size * this.Size;
            Console.WriteLine("\nTotal Cells: " + totalCells);
            Console.WriteLine("Difficulty: " + this.Difficulty + "%");
            numLiveCells = (totalCells - (totalCells - this.Difficulty));
            Console.WriteLine("Number of Bombs to Plant: " + numLiveCells.ToString());

            // Create Random Bombs
            for (int bombs = numLiveCells; bombs > 0; bombs--)
            {
                // Choose Valid Random Cell
                bool valid = false;
                int xCord = -1;
                int yCord = -1;
                while (!valid)
                {
                    Random randy = new Random();
                    xCord = randy.Next(0, this.Size - 1);
                    yCord = randy.Next(0, this.Size - 1);

                    // Check if Cell is NOT Live (if so we choose a different cell)
                    if (this.CellGrid[xCord, yCord].IsLive == false)
                    {
                        valid = true;
                    }
                }
                
                // Set Selected Cell to Live
                this.CellGrid[xCord, yCord].IsLive = true;
            }
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
