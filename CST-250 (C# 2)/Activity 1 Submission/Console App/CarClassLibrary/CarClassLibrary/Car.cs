using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        // Car Attributes
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        // Parameterized Constructor
        public Car(string make, string model, decimal price, string color, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Color = color;
            this.Year = year;
        }

        // Default Constructor
        public Car()
        {
            this.Make = "";
            this.Model = "";
            this.Price = 0.00M;
            this.Color = "";
            this.Year = 0;
        }

        // Display
        public string Display
        {
            get 
            {
                return string.Format("{0} {1} ${2}", this.Make, this.Model, this.Price);
            }
        }
    }
}
