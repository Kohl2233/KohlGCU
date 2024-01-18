using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    internal class Car
    {
        // Car Attributes
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        // Parameterized Constructor
        public Car(string Make, string Model, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Price = Price;
        }

        // Default Constructor
        public Car()
        {
            this.Make = "";
            this.Model = "";
            this.Price = 0.00M;
        }
    }
}
