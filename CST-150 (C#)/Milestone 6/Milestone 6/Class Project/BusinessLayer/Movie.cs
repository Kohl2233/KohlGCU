using System;
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
    public class Movie
    {
        // Attributes
        public string Name;
        public string Description;
        public int Qty;
        public double Price;
        public string ReleaseDate;
        public int Runtime;
        public string Rating;
        public int AudienceScore;


        /// <summary>
        /// Default Constructor
        /// </summary>
        public Movie()
        {
            Name = "";
            Description = "";
            Qty = 0;
            Price = 0.00D;
            ReleaseDate = "";
            Runtime = 0;
            Rating = "";
            AudienceScore = 0;
        }


        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="qty"></param>
        /// <param name="price"></param>
        /// <param name="releaseDate"></param>
        /// <param name="runtime"></param>
        /// <param name="rating"></param>
        /// <param name="audienceScore"></param>
        public Movie(string name, string description, int qty, double price, string releaseDate, int runtime, string rating, int audienceScore)
        {
            // Assign Attributes
            Name = name;
            Description = description;
            Qty = qty;
            Price = price;
            ReleaseDate = releaseDate;
            Runtime = runtime;
            Rating = rating;
            AudienceScore = audienceScore;
        }
    }
}
