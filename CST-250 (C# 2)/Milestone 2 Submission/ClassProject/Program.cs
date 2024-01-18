using MineSweeperClassLibrary;
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
            bool runGame = true;
            while (runGame)
            {
                // Clear Console
                Console.Clear();
                displayGameBoard(board);
                displayGameStats(board);
                

                // Ask User for Row Input
                bool rowInputValid = false;
                bool colInputValid = false;
                string userRowString = "";
                string userColString = "";
                int userRow = 0;
                int userCol = 0;

                
                while (!rowInputValid)
                {
                    Console.Write("\nEnter Row Number (x): ");
                    userRowString = Console.ReadLine();
                    try
                    {
                        userRow = int.Parse(userRowString);
                    } catch
                    {
                        // bad input
                    } finally
                    {
                        if ((userRow > 0) && (userRow <= board.Size))
                        {
                            rowInputValid = true;
                        } else
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

                // Check Cell
                userRow--;
                userCol--;

                Cell focusCell = board.CellGrid[userRow, userCol];
                focusCell.IsDiscovered = true;

                // Check if Still Alive
                if (focusCell.IsLive)
                {
                    Console.WriteLine("\nBOOOOOOOOOOOOOOOOOOM!\nyou blew up.. better luck next time rookie :O\n\n");
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
                // Print Header
                Console.Write("   ");
                for (int i = 0; i < board.Size; i++)
                {
                    Console.Write("[" + (i + 1) + "]");
                }
                Console.Write("\n\n");

                // Print Game Board
                for (int y = 0; y < board.Size; y++)
                {
                    string line = "[" + (y + 1) + "] ";
                    for (int x = 0; x < board.Size ; x++)
                    {
                        // Check if Cell is Discovered
                        Cell cell = board.CellGrid[x, y];
                        if (cell.IsDiscovered)
                        {
                           // Check if Cell is Live
                           if (cell.IsLive)
                            {
                                line += "#  ";
                            } else if (cell.NumLiveNeighbors > 0)
                            {
                                line += cell.NumLiveNeighbors + "  ";
                            } else
                            {
                                line += "   ";
                            }
                        } else
                        {
                            line += "?  ";
                        }
                        
                    }
                    Console.WriteLine(line + "\n");
                }
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