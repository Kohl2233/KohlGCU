using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Store
    {
        // Attributes/Properties
        public List<Car> CarsList { get; set; }
        public List<Car> ShoppingList { get; set; }

        // Constructor
        public Store()
        {
            this.CarsList = new List<Car>();
            this.ShoppingList = new List<Car>();
        }


        /// <summary>
        /// Method to Checkout
        /// Takes no params and returns total of cars in shopping cart
        /// </summary>
        /// <returns></returns>
        public decimal checkout()
        {
            // Local Var(s)
            decimal totalCost = 0;

            // Calculate Total
            foreach(var car in this.CarsList)
            {
                totalCost += car.Price;
            }

            // Clear Shopping Cart
            this.ShoppingList.Clear();

            // Return Total Cost
            return totalCost;
        }
    }
}
