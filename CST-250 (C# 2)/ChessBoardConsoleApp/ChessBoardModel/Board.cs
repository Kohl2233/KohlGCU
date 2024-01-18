using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Board
    {
        public int Size { get; set; }

        public Cell[,] theGrid;

        // Constructor
        public Board(int s)
        {
            this.Size = s;
            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {
            // Clear all Previous Legal Moves
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                }
            }

            // Find all Legal Next Moves
            switch (chessPiece)
            {
                case "Knight":
                    if (checkInBounds(currentCell.RowNumber - 2, currentCell.ColNumber - 1)) { theGrid[currentCell.RowNumber - 2, currentCell.ColNumber - 1].LegalNextMove = true; }
                    if (checkInBounds(currentCell.RowNumber - 2, currentCell.ColNumber + 1)) { theGrid[currentCell.RowNumber - 2, currentCell.ColNumber + 1].LegalNextMove = true; }
                    if (checkInBounds(currentCell.RowNumber - 1, currentCell.ColNumber + 2)) { theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 2].LegalNextMove = true; }
                    if (checkInBounds(currentCell.RowNumber + 1, currentCell.ColNumber + 2)) { theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 2].LegalNextMove = true; }
                    if (checkInBounds(currentCell.RowNumber + 2, currentCell.ColNumber + 1)) { theGrid[currentCell.RowNumber + 2, currentCell.ColNumber + 1].LegalNextMove = true; }
                    if (checkInBounds(currentCell.RowNumber + 2, currentCell.ColNumber - 1)) { theGrid[currentCell.RowNumber + 2, currentCell.ColNumber - 1].LegalNextMove = true; }
                    if (checkInBounds(currentCell.RowNumber + 1, currentCell.ColNumber - 2)) { theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 2].LegalNextMove = true; }
                    if (checkInBounds(currentCell.RowNumber - 1, currentCell.ColNumber - 2)) { theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 2].LegalNextMove = true; }
                    break;
                case "King":
                    // Vertical
                    theGrid[currentCell.RowNumber, currentCell.ColNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber, currentCell.ColNumber - 1].LegalNextMove = true;

                    // Horizontal
                    theGrid[currentCell.RowNumber - 1, currentCell.ColNumber].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColNumber].LegalNextMove = true;

                    // Diagonal
                    theGrid[currentCell.RowNumber - 1, currentCell.ColNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColNumber + 1].LegalNextMove = true;
                    break;
                case "Rook":
                    // Horizontal
                    for (int col = currentCell.ColNumber - 1; col >= 0; col--) { theGrid[currentCell.RowNumber, col].LegalNextMove = true;  }
                    for (int col = currentCell.ColNumber + 1; col < this.Size; col++) { theGrid[currentCell.RowNumber, col].LegalNextMove = true; }
                    
                    // Vertical
                    for (int r = currentCell.RowNumber + 1;  r < this.Size; r++) { theGrid[r, currentCell.ColNumber].LegalNextMove = true; }
                    for (int r = currentCell.RowNumber - 1; r >= 0; r--) { theGrid[r, currentCell.ColNumber].LegalNextMove = true; }
                    break;
                case "Bishop":
                    // Diagonal 'left up'
                    int c = currentCell.ColNumber - 1;
                    for (int r = currentCell.RowNumber - 1; r >= 0; r--) 
                    { 
                        if (checkInBounds(r, c)) { theGrid[r, c].LegalNextMove = true; c--; }
                    }
                    // Diagonal 'right up'
                    c = currentCell.ColNumber + 1;
                    for (int r = currentCell.RowNumber - 1; r >= 0; r--) 
                    { 
                        if (checkInBounds(r, c)) { theGrid[r, c].LegalNextMove = true; c++; }
                    }
                    // Diagonal 'left down'
                    c = currentCell.ColNumber - 1;
                    for (int r = currentCell.RowNumber + 1; r < this.Size; r++) 
                    { 
                        if (checkInBounds(r, c)) { theGrid[r, c].LegalNextMove = true; c--; }
                    }
                    // Diagonal 'right down'
                    c = currentCell.ColNumber + 1;
                    for (int r = currentCell.RowNumber + 1; r < this.Size; r++) 
                    {
                        if (checkInBounds(r, c)) { theGrid[r, c].LegalNextMove = true; c++; } 
                    }
                    break;
                case "Queen":
                    // Horizontal
                    for (int col = currentCell.ColNumber - 1; col >= 0; col--) { theGrid[currentCell.RowNumber, col].LegalNextMove = true; }
                    for (int col = currentCell.ColNumber + 1; col < this.Size; col++) { theGrid[currentCell.RowNumber, col].LegalNextMove = true; }

                    // Vertical
                    for (int r = currentCell.RowNumber + 1; r < this.Size; r++) { theGrid[r, currentCell.ColNumber].LegalNextMove = true; }
                    for (int r = currentCell.RowNumber - 1; r >= 0; r--) { theGrid[r, currentCell.ColNumber].LegalNextMove = true; }
                    // Diagonal 'left up'
                    c = currentCell.ColNumber - 1;
                    for (int r = currentCell.RowNumber - 1; r >= 0; r--)
                    {
                        if (checkInBounds(r, c)) { theGrid[r, c].LegalNextMove = true; c--; }
                    }
                    // Diagonal 'right up'
                    c = currentCell.ColNumber + 1;
                    for (int r = currentCell.RowNumber - 1; r >= 0; r--)
                    {
                        if (checkInBounds(r, c)) { theGrid[r, c].LegalNextMove = true; c++; }
                    }
                    // Diagonal 'left down'
                    c = currentCell.ColNumber - 1;
                    for (int r = currentCell.RowNumber + 1; r < this.Size; r++)
                    {
                        if (checkInBounds(r, c)) { theGrid[r, c].LegalNextMove = true; c--; }
                    }
                    // Diagonal 'right down'
                    c = currentCell.ColNumber + 1;
                    for (int r = currentCell.RowNumber + 1; r < this.Size; r++)
                    {
                        if (checkInBounds(r, c)) { theGrid[r, c].LegalNextMove = true; c++; }
                    }
                    break;

            }
        }

        private bool checkInBounds(int row, int col)
        {
            if (row >= 0 && row < this.Size)
            {
                if (col >= 0 && col < this.Size) { return true; } else { return false; }
            } else
            {
                return false;
            }
        }
    }
}
