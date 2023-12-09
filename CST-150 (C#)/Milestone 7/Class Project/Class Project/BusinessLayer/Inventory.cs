using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Kohl Johnson
 * CST-150
 * Class Project
 * 12-3-2023
 * Citation(s):
 */
namespace Class_Project.BusinessLayer
{
    internal class Inventory
    {
        // Attributes
        private string InventoryFile;
        public List<Movie> InventoryList;
        

        /// <summary>
        /// Constructor for Inventory Manager Class
        /// </summary>
        public Inventory(string inventoryFile) 
        {
            // Assign Attributes
            InventoryFile = inventoryFile;
            InventoryList = new List<Movie>();
            
            // Populate Inventory Upon Creation
            ProcessInventory();
        }


        /// <summary>
        /// Function to Populate Inventory Object with Products
        /// </summary>
        /// <returns></returns>
        public void ProcessInventory()
        {
            InventoryList.Clear(); // wipe inventory list
            using (var str = File.OpenText(InventoryFile))
            {
                foreach (string line in File.ReadLines(InventoryFile, Encoding.UTF8))
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

                    // Add Object to Inventory List
                    InventoryList.Add(movie);
                }
            }
        }


        /// <summary>
        /// Method to Update Inventory in the DataGridView
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="selectedRowIndex"></param>
        /// <returns></returns>
        public void AdjustQtyValue(int selectedRowIndex, int amount)
        {
            if ((amount == -1) && (InventoryList[selectedRowIndex].Qty < 2))
            {
                string message = "Can not lower quantity below 1. " +
                    "You can use the 'Remove Movie' button to delete " +
                    "it if that is what you wish.";
                string title = "Ahhhh No Can Do Bud";
                MessageBox.Show(message, title);
            } else
            {
                int updatedQty = InventoryList[selectedRowIndex].Qty += amount; // increase/decrease qty
                InventoryList[selectedRowIndex].Qty = updatedQty; // update qty
                WriteInventory(); // update inventory file
                ProcessInventory(); // reload inventory
            }
            
        }


        /// <summary>
        /// Method to Write Updates to Inventory Text File
        /// </summary>
        private void WriteInventory()
        {
            StreamWriter outputFile;
            using (outputFile = new StreamWriter(Application.StartupPath + "Data\\inventory.txt", false))
            {
                foreach (Movie movie in InventoryList)
                {
                    string movieString = movie.Name + "@ "
                        + movie.Description + "@ "
                        + movie.Qty.ToString() + "@ "
                        + movie.Price.ToString("n2") + "@ "
                        + movie.ReleaseDate + "@ "
                        + movie.Runtime.ToString() + "@ "
                        + movie.Rating + "@ "
                        + movie.AudienceScore.ToString() + "\n";
                    outputFile.Write(movieString);
                }
            }
        }


        /// <summary>
        /// Method to Delete Movie Object From List
        /// </summary>
        /// <param name="index"></param>
        public void DeleteMovie(int index)
        {
            InventoryList.RemoveAt(index);
            WriteInventory();
            ProcessInventory();
        }


        /// <summary>
        /// Method to Add New Movie to Inventory
        /// </summary>
        /// <param name="newMovie"></param>
        public void AddNewMovie(Movie newMovie)
        {
            InventoryList.Add(newMovie);
            WriteInventory();
            ProcessInventory();
        }

        /// <summary>
        /// Function to Populate Inventory Object with Default Products
        /// </summary>
        /// <returns></returns>
        public void InventoryReset()
        {
            InventoryList.Clear(); // wipe inventory list
            using (var str = File.OpenText(Application.StartupPath + "Data\\masterInventory.txt"))
            {
                foreach (string line in File.ReadLines(Application.StartupPath + "Data\\masterInventory.txt", Encoding.UTF8))
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

                    // Add Object to Inventory List
                    InventoryList.Add(movie);

                    // Save Data
                    WriteInventory();
                }
            }
        }
    }
}
