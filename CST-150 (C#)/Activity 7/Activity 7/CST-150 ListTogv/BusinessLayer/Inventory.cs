using CST_150_ListTogv.Models;
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
namespace CST_150_ListTogv.BusinessLayer
{
    internal class Inventory
    {
        /// <summary>
        /// Method to Read Inventory
        /// </summary>
        /// <param name="invItems"></param>
        /// <returns></returns>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            string dirLocation = Application.StartupPath + "Data\\topic6.txt";

            // Open file with 'using', manages resources and auto realeases all resources when done
            using (var str = File.OpenText(dirLocation))
            {
                foreach (string line in File.ReadLines(dirLocation, Encoding.UTF8))
                {
                    // Split Items and Create new InvItem Object
                    string[] rowData = line.Split(',');
                    invItems.Add(new InvItem(rowData[0].ToString().Trim(), rowData[1].ToString().Trim(), Convert.ToInt32(rowData[2])));
                }
            }
            // Return List
            return invItems;
        }

        /// <summary>
        /// Method to Update Inventory in the DataGridView
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="selectedRowIndex"></param>
        /// <returns></returns>
        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex) 
        {
            int updatedQty = invItems[selectedRowIndex].Qty += 1; // increment qty
            invItems[selectedRowIndex].Qty = updatedQty; // update qty
            return invItems; // return new inventory
        }

        /// <summary>
        /// Method to Write Updated Inventory to New, Seperate File
        /// </summary>
        /// <param name="invItems"></param>
        public void WriteInventory(List<InvItem> invItems)
        {
            StreamWriter outputFile;
            using (outputFile = new StreamWriter(Application.StartupPath + "Data\\updatedInv.txt", false))
            {
                foreach (InvItem item in invItems)
                {
                    string itemStr = item.Type + "," + item.Color + "," + item.Qty.ToString() + "\n";
                    outputFile.Write(itemStr);
                }
            }
        }


        /// <summary>
        /// Search the Main Inventory for Items Matching the Search Criteria
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="searchItem"></param>
        /// <param name="searchCriteria"></param>
        /// <returns></returns>
        public List<InvItem> SearchItem(List<InvItem> invItems, List<InvItem> invSearch, string searchCriteria) 
        {
            invSearch.Clear(); // clear the search inventory
            foreach(InvItem item in invItems)
            {
                if (item.Type.ToLower().Contains(searchCriteria.ToLower()))
                {
                    invSearch.Add(item); // add found item to list
                }
            }
            return invSearch;
        }
    }
}
