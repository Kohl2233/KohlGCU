namespace KnightsTour
{
    internal class Program
    {
        static int BoardSize = 8;
        static int attemptedMoves = 0;
        static int[] xMove = { 2, 1, -1, -2, -2, -1, 2, 2 };
        static int[] yMove = { 1, 2, 2, 1, -1, -2, 2, -1 };
        static int[,] boardGrid = new int[BoardSize, BoardSize];
        static void Main(string[] args)
        {
            SolveKT();
     
        }



        /// <summary>
        /// Uses Backtracing to Solve the Knights Tour Problem. 
        /// </summary>
        static void SolveKT()
        {
            // Grid Init with -1, meaning cell not visited
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    boardGrid[x, y] = -1;
                }
            }

            int startX = 0;
            int startY = 0;

            // Set start pos
            boardGrid[startX, startY] = 0;

            // Count total num of guesses
            attemptedMoves = 0;

            // Explore all tours using solveKTUtil()
            if (!SolveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("Solution does not exist for {0} {1}.", startX, startY);
            } else
            {
                PrintSolution(boardGrid);
                Console.Out.WriteLine("Total Attempted Moves: {0}", attemptedMoves);
            }
        }




        static bool SolveKTUtil(int x, int y, int moveCount)
        {
            attemptedMoves++;
            if (attemptedMoves % 1000000 == 0) { Console.Out.WriteLine("Attempts: {0}", attemptedMoves); }

            int k, next_x, next_y;

            // Check if we've reached a solution
            if (moveCount == BoardSize * BoardSize) { return true; }


            
            // Try all next moves from current coordinate x, y
            for (k = 0; k < 8; k++)
            {
                next_x = x + xMove[k];
                next_y = y + yMove[k];

                
                
                if (IsSquareSafe(next_x, next_y))
                {
                    boardGrid[next_x, next_y] = moveCount;
                    if (SolveKTUtil(next_x, next_y, moveCount + 1))
                    {
                        return true;
                    } else { boardGrid[next_x, next_y] = -1; }
                }
            }
            return false;
        }



        /// <summary>
        /// Utility Function to Check if Square is Within Bounds
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static bool IsSquareSafe(int x, int y) 
        {
            return (x >= 0 && x < BoardSize && y >= 0 && y < BoardSize && boardGrid[x, y] == -1);
        }



        /// <summary>
        /// Utility Function to Print out Board
        /// </summary>
        /// <param name="solution"></param>
        static void PrintSolution(int[,] solution)
        {
            for (int x = 0; x < BoardSize; x++)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    Console.Write(solution[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}