using ChessBoardModel;
namespace ChessBoardConsoleApp
{
    internal class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            printGrid(myBoard);
            Cell myLocation = setCurrentCell();
            string piece = getChessPiece();
            myBoard.MarkNextLegalMoves(myLocation, piece);
            Console.WriteLine("\nYou elected to place a {0} at position [{1}, {2}]\nHere are the moves you can make..", piece, myLocation.RowNumber, myLocation.ColNumber);
            printGrid(myBoard);
            Console.ReadLine();
        }

        static public void printGrid(Board myBoard)
        {
            string horzLine = "\n*---*---*---*---*---*---*---*---*";
            Console.WriteLine(horzLine);
            for (int i = 0; i < myBoard.Size; i++)
            {
                Console.Write("|");
                for (int j = 0; j < myBoard.Size; j++)
                {
                    if (myBoard.theGrid[i, j].CurrentlyOccupied)
                    {
                        
                        Console.Write(" X |");
                    } else if (myBoard.theGrid[i, j].LegalNextMove)
                    {
                        Console.Write(" + |");
                    } else
                    {
                        Console.Write("   |");
                    }
                }
                Console.WriteLine(horzLine);
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 33)));
        }

        static public Cell setCurrentCell()
        {
            int currentRow = 0;
            int currentCol = 0;
            bool inputValid = false;
            while (!inputValid)
            {
                Console.Out.WriteLine("Enter your current row number: ");
                if (int.TryParse(Console.ReadLine(), out currentRow) ) 
                {   
                    if (currentRow >= 0 && currentRow < myBoard.Size) 
                    {
                        Console.Out.WriteLine("Enter you current column number: ");
                        if (int.TryParse(Console.ReadLine(), out currentCol))
                        {
                            if (currentCol >= 0 && currentRow < myBoard.Size) { inputValid = true; } else { Console.Out.WriteLine("Enter a number between 0 and 8"); }
                        } else { Console.Out.WriteLine("Please enter a valid number"); }
                    } else { Console.Out.WriteLine("Enter a number between 0 and 8"); }
                } else { Console.Out.WriteLine("Please enter a valid number"); }
                
                
            }

            myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;
            return myBoard.theGrid[currentRow, currentCol];
        }

        static public string getChessPiece()
        {
            int selection = 0;
            string piece;
            bool inputValid = false;
            while (!inputValid)
            {
                Console.Out.WriteLine("Choose your Chess Piece...\n[1] Knight\n[2] King\n[3] Rook\n[4] Bishop\n[5] Queen");
                if (int.TryParse (Console.ReadLine(), out selection) )
                {
                    if (selection > 0 && selection <= 5) { inputValid = true; }
                }
            }
            switch (selection)
            {
                case 1:
                    piece = "Knight";
                    break;
                case 2:
                    piece = "King";
                    break;
                case 3:
                    piece = "Rook";
                    break;
                case 4:
                    piece = "Bishop";
                    break;
                case 5:
                    piece = "Queen";
                    break;
                default:
                    piece = "Knight";
                    break;
            }
            return piece;
        }
    }
}