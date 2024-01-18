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
            displayBoard(board);

            
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

        }
    }
}