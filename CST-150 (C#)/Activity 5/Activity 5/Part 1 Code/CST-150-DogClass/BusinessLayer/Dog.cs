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
namespace CST_150_DogClass.BusinessLayer
{
    internal class Dog
    {
        // Define Attributes
        public string Name { get; set; }
        public double NeckRad {  get; set; }
        public string Color {  get; set; }
        public double Weight {  get; set; }
        public bool Sit {  get; set; }

        // Default Constructor
        public Dog()
        {
            Name = "";
            NeckRad = 0.00D;
            Color = "";
            Weight = 0.00D;
            Sit = false;
        }

        /// <summary>
        /// Parameterized Constructor the Dog Class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="neckRad"></param>
        /// <param name="color"></param>
        /// <param name="weight"></param>
        /// <param name="sit"></param>
        public Dog(string name, double neckRad, string color, double weight, bool sit)
        {
            Name = name;
            NeckRad = neckRad;
            Color = color;
            Weight = weight;
            Sit = sit;
        }

        /// <summary>
        /// Function to Calculate Neck Circumference
        /// </summary>
        /// <returns></returns>
        public double CalCircumfrence()
        {
            const double cmConversion = 2.54D;
            double circumfrence = 0.0D;
            circumfrence = 2 * Math.PI * NeckRad;
            return (cmConversion * circumfrence);
        }

        /// <summary>
        /// Function to Convert Weight
        /// </summary>
        /// <returns></returns>
        public double CalWeight()
        {
            const double kgConversion = 0.453592D;
            return (Weight * kgConversion);
        }


    }
}
