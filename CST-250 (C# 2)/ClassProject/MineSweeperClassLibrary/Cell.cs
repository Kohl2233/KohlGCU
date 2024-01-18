using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperClassLibrary
{
    public class Cell
    {
        // Attributes/Properties
        public int[] Position { get; set; } // int array for position (x, y)
        public bool IsDiscovered { get; set; } // takes the place of "visited"
        public bool IsLive { get; set; } // whether cell has a bomb
        public int NumLiveNeighbors { get; set; } // num of adjacent cells with live bombs


        // Parameterized Consructor
        public Cell(int[] position, bool isDiscovered, bool isLive, int numLiveNeighbors)
        {
            this.Position = position;
            this.IsDiscovered = isDiscovered;
            this.IsLive = isLive;
            this.NumLiveNeighbors = numLiveNeighbors;
        }


        // Default Constructor
        public Cell() 
        {
            this.Position = new int[2] { -1, -1 };
            this.IsDiscovered = false;
            this.IsLive = false;
            this.NumLiveNeighbors = 0;
        }
    }
}
