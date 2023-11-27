using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Kohl Johnson
 * CST-150
 * Class Project
 * 11-25-2023
 * Citation(s): 
 */
namespace Class_Project.BusinessLayer
{
    internal class Inventory
    {
        // Attributes
        private string InventoryFile;
        public ArrayList InventoryList;
        

        /// <summary>
        /// Constructor for Inventory Manager Class
        /// </summary>
        public Inventory(string inventoryFile) 
        {
            // Assign Attributes
            InventoryFile = inventoryFile;
            InventoryList = new ArrayList();
            
            // Populate Inventory Upon Creation
            this.ProcessInitialInventory();
        }


        /// <summary>
        /// Function to Populate Inventory Object with Initial Products
        /// </summary>
        /// <returns></returns>
        private void ProcessInitialInventory()
        {
            // Inventory File Reading
            string[] lines = File.ReadAllLines(InventoryFile); // read in all contents from file

            // Process Inventory String
            foreach (string line in lines)
            {
                string[] inventoryList = line.Split("@ "); // split each attribute up

                // Assign Values
                string name = inventoryList[0];
                string descr = inventoryList[1];
                int qty = Int32.Parse(inventoryList[2]);
                float price = float.Parse(inventoryList[3]);
                string releaseDate = inventoryList[4];
                int runtime = Int32.Parse(inventoryList[5]);
                string rating = inventoryList[6];
                int audScore = Int32.Parse(inventoryList[7]);

                // Create Movie Object
                Movie movie = new Movie(name, descr, qty, price, releaseDate, runtime, rating, audScore);

                // Add Object to Movie Object ArrayList
                InventoryList.Add(movie);
            }
        }  
    }
}
