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
    internal class Utility
    {
        /// <summary>
        /// Method to Check if String is Null
        /// </summary>
        /// <param name="textToTest"></param>
        /// <returns></returns>
        public bool NotNull(string textToTest)
        {
            if (String.IsNullOrWhiteSpace(textToTest))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method to Check if Valid Double
        /// </summary>
        /// <param name="valueToTest"></param>
        /// <returns></returns>
        public (double doublValue, bool isConverted) ValidDouble(string valueToTest)
        {
            double convertValue = 0.00D;
            if (Double.TryParse(valueToTest, out convertValue))
            {
                return (convertValue, true);
            }
            return (-1D, false);
        }

        /// <summary>
        /// Method to Convert Yes or No Value to Boolean
        /// </summary>
        /// <param name="YesOrNo"></param>
        /// <returns></returns>
        public bool ConvertToBool(string YesOrNo)
        {
            if (YesOrNo == "Yes") { return true; }
            return false;
        }
    }
}
