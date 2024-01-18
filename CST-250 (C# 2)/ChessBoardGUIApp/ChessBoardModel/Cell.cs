using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardModel
{
    public class Cell
    {
        // Cells position
        public int RowNumber {  get; set; }
        public int ColNumber { get; set; }
        
        // T/F is chess piece on board
        public bool CurrentlyOccupied { get; set; }

        // Is cell a legal move for chess piece on board
        public bool LegalNextMove { get; set; }

        // Constructor
        public Cell(int r, int c)
        {
            this.RowNumber = r;
            this.ColNumber = c;
        }
    }
}
