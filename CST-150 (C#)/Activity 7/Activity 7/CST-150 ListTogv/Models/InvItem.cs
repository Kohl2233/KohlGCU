using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Kohl Johnson
 * CST-150
 * Activity 6
 * 12-03-2023
 * Citation(s):
 */
namespace CST_150_ListTogv.Models
{
    /// <summary>
    /// Model Class For all Inventory Items
    /// </summary>
    public class InvItem
    {
        // Properties/Attributes
        public string Type { get; set; }
        public string Color { get; set; }
        public int Qty { get; set; }

        /// <summary>
        /// Parameterized Constructor for InvItem
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="qty"></param>
        public InvItem(string type, string color, int qty)
        {
            Type = type;
            Color = color;
            Qty = qty;
        }
    }
}
