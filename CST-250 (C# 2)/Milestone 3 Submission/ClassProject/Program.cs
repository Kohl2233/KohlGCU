using MineSweeperClassLibrary;
using System;

namespace ClassProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Board
            Board board = new Board(10);
            board.setupLiveNeighbors();
            board.calculateLiveNeighbors();
            //displayBoard(board);

            // Main Program Loop
            int numIterations = 0;
            bool runGame = true;
            int userRow = 0;
            int userCol = 0;
            while (runGame)
            {
                if (numIterations > 0) { Console.Clear(); }
                displayGameBoard(board);
                displayGameStats(board);

                // Ask User for Row Input
                bool rowInputValid = false;
                bool colInputValid = false;
                bool inputValid = false;
                string userRowString = "";
                string userColString = "";

                if (numIterations > 0) { Console.WriteLine(String.Format("Previous Selection: [{0}, {1}]", userRow + 1, userCol + 1)); }
                while (!inputValid)
                {
                    while (!rowInputValid)
                    {
                        Console.Write("\nEnter Row Number (x): ");
                        userRowString = Console.ReadLine();
                        try
                        {
                            userRow = int.Parse(userRowString);
                        }
                        catch
                        {
                            // bad input
                        }
                        finally
                        {
                            if ((userRow > 0) && (userRow <= board.Size))
                            {
                                rowInputValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number between {0} and {1}", 1, board.Size);
                            }
                        }
                    }

                    // Ask User for Col Input
                    while (!colInputValid)
                    {
                        Console.Write("\nEnter Row Number (y): ");
                        userColString = Console.ReadLine();
                        try
                        {
                            userCol = int.Parse(userColString);
                        }
                        catch
                        {
                            // bad input
                        }
                        finally
                        {
                            if ((userCol > 0) && (userCol <= board.Size))
                            {
                                colInputValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a number between {0} and {1}", 1, board.Size);
                            }
                        }
                    }

                    // Check if Cell Been Discovered
                    if (board.CellGrid[userRow - 1, userCol - 1].IsDiscovered)
                    {
                        Console.WriteLine("You have already been to this cell.");
                        rowInputValid = false;
                        colInputValid = false;
                    } else
                    {
                        inputValid = true;
                    }
                }
                

                // Check Cell
                numIterations++;
                userRow--;
                userCol--;

                Cell focusCell = board.CellGrid[userRow, userCol];
                focusCell.IsDiscovered = true;
                board.floodFill(userRow, userCol);

                // Check if Still Alive
                if (focusCell.IsLive)
                {
                    Console.WriteLine("\nBOOOOOOOOOOOOOOOOOOM!\nyou blew up.. better luck next time rookie :O\n\n");
                    displayGameBoard(board);
                    
                    runGame = false;
                } else if (getNumSafeCellsLeft(board) == 0)
                {
                    Console.WriteLine("\nYOU WIN!\n\n");
                    runGame = false;
                }

            }
            
            void displayBoard(Board board)
            {
                for (int y = 0; y < board.Size; y++)
                {
                    string line = "";
                    for (int x = 0; x < board.Size; x++)
                    {
                        line += board.CellGrid[x, y].NumLiveNeighbors + "  ";
                    }
                    Console.WriteLine(line + "\n");
                    
                }
            }

            
            void displayGameBoard(Board board)
            {
                string startHorzLine = "*---*";
                string horzLine = "---*";

                // Print Game Board
                for (int y = 0; y < board.Size; y++)
                {
                    Console.WriteLine(startHorzLine + string.Concat(Enumerable.Repeat(horzLine, board.Size - 1)));
                    string line = "|";
                    for (int x = 0; x < board.Size ; x++)
                    {
                        // Check if Cell is Discovered
                        Cell cell = board.CellGrid[x, y];
                        if (cell.IsDiscovered)
                        {
                           // Check if Cell is Live
                           if (cell.IsLive)
                            {
                                line += " # |";
                            } else if (cell.NumLiveNeighbors > 0)
                            {
                                line += string.Format(" {0} |", cell.NumLiveNeighbors);
                            } else
                            {
                                line += "   |";
                            }
                        } else
                        {
                            line += " ? |";
                        }
                        
                    }
                    Console.WriteLine(line);
                }
                Console.WriteLine(startHorzLine + string.Concat(Enumerable.Repeat(horzLine, board.Size - 1)));
            }

            void displayGameStats(Board board)
            {
                Console.WriteLine("\n----- GAME STATS -----\nSafe Cells Left: {0}\n", getNumSafeCellsLeft(board));
            }


            int getNumSafeCellsLeft(Board board)
            {
                int cellsLeft = 0;
                for (int y = 0; y < board.Size ; y++)
                {
                    for (int x = 0; x < board.Size ; x++)
                    {
                        Cell cell = board.CellGrid[x, y];
                        if (!cell.IsLive)
                        {
                            if (!cell.IsDiscovered)
                            {
                                cellsLeft++;
                            }
                        }
                    }
                }
                return cellsLeft;
            }

        }
    }
}