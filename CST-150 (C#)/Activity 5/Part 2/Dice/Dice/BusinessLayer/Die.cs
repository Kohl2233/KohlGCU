using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Kohl Johnson
 * CST-150
 * Activity 5
 * 11-25-2023
 * Citation(s):
 */
namespace Dice.BusinessLayer
{
    internal class Die
    {
        // Attributes
        public int RollVal = 0;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Die()
        {
            RollVal = 1;
        }

        /// <summary>
        /// Method to Randomly Roll Die
        /// </summary>
        /// <returns></returns>
        public void RollDie()
        {
            Random randy = new Random();
            this.RollVal = randy.Next(1, 7); // random int between 1 and 6
        }
    }
}
