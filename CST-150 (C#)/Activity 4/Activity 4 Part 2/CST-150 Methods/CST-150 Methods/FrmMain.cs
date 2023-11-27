/* Kohl Johnson
 * CST-150 
 * Activity 4
 * 11-18-2023
 * Citation(s):
 */

namespace CST_150_Methods
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblResults.Visible = false;
        }

        /// <summary>
        /// Button Click Event Handler for Executing Methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExecuteMethods(object sender, EventArgs e)
        {
            int num1 = 2, num2 = 3, num3 = 4;
            int randomSum = 0;
            double double1 = 1.1D, double2 = 2.2D, double3 = 3.3D;
            double double4 = 4.4D, double5 = 5.5D;
            string firstString = "This is test number 82", secondString = "The sky is blue today";
            double[] doubles = { 4.4D, 23.56D, 24.45D, 16.1D, 125.25D, 45.3D };
            

            SumInts(num1, num2); // First Method
            DisplayResults("Avg of 5 doubles is: " + AvgValue(double1, double2, double3, double4, double5), true); // Second Method
            randomSum = RandomInt();
            DisplayResults(String.Format("Method 3: Sum of random ints: {0}", randomSum.ToString()), false);
            bool isDivisibleByTwo = DivByTwo(num1, num2, num3);
            DisplayResults(String.Format("Method 4: Is sum of 3 ints div by 2: {0}", isDivisibleByTwo), false);
            FewestChars(firstString, secondString);
            double maxDouble = LargestDouble(doubles);
            DisplayResults(string.Format("Method 6: Largest Double: {0}", maxDouble.ToString()), false);
            int[] tenRandInts = TenRandomInts();
            string tenInts = "[ ";
            for (int x = 0; x < tenRandInts.Length; x++)
            {
                tenInts += tenRandInts[x];
                if (x < tenRandInts.Length - 1) { tenInts += ", "; } else { tenInts += " ]"; }
            }
            DisplayResults(String.Format("Method 7: Ten Random Ints: {0}", tenInts), false);
            bool b1 = true, b2 = false;
            DisplayResults(String.Format("Method 8: Bools same: {0}", CompareBools(b1, b2)), false);
            DisplayResults(String.Format("Method 9: Add Int and Double: {0}", Product(num1, double3)), false);
            lblResults.Visible = true;
        }

        /// <summary>
        /// Method 1: Add Two Integers Together and Display Sum with Descriptive Text
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        private void SumInts(int num1, int num2)
        {
            int sum = num1 + num2; // find the sum
            DisplayResults("Method 1: Sum of " + num1 + " and " + num2 + " = " + sum, true); // call DisplayResults
        }

        /// <summary>
        /// Displays descText to lblResults, requires the text to display and a bool for clearing the label prior
        /// </summary>
        /// <param name="descText"></param>
        /// <param name="clearLabel"></param>
        private void DisplayResults(string descText, bool clearLabel)
        {
            if (clearLabel) { lblResults.Text = ""; } // clear the lbl if needed
            lblResults.Text += String.Format("{0}\n", descText); // display results
        }

        /// <summary>
        /// Method 2: Takes in Five Doubles and Returns the Average of those
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="val3"></param>
        /// <param name="val4"></param>
        /// <param name="val5"></param>
        /// <returns></returns>
        private double AvgValue(double val1,  double val2, double val3, double val4, double val5) 
        {
            double average = (val1 + val2 + val3 + val4 + val5) / 5.0D;
            return average;
        }

        /// <summary>
        /// Method 3: Returns a Random Int
        /// </summary>
        /// <returns></returns>
        private int RandomInt()
        {
            int num1 = 0, num2 = 0, sum = 0;
            Random rand = new Random();
            num1 = rand.Next(1, 101); // Random number >= 1 and < 101
            num2 = rand.Next(1, 101);
            sum = num1 + num2;
            return sum;
        }

        /// <summary>
        /// Method 4: Returns true or false if the sum of ints is divisible by 2
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>
        private bool DivByTwo(int num1, int num2, int num3)
        {
            int sum = num1 + num2 + num3;
            if (sum % 2 == 0) { return true; } else { return false; }
        }

        /// <summary>
        /// Method 5: Takes two strings, finds one with fewest chars
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        private void FewestChars(string string1, string string2)
        {
            int countChar1 = 0, countChar2 = 0, pointer = 0;
            do
            {
                try
                {
                    if (char.IsLetter(string1[pointer]))
                    {
                        countChar1++;
                    }
                }
                catch (Exception e)
                {
                    // do nothing
                }

                try
                {
                    if (char.IsLetter(string2[pointer]))
                    {
                        countChar2++;
                    }
                } catch (Exception e)
                {
                    // do nothing
                }
                pointer++;
            } while ((pointer < string1.Length) || (pointer < string2.Length));

            if (countChar1 > countChar2)
            {
                DisplayResults("Method 5: String 2 has fewer letters.", false);
            } else if (countChar2 > countChar1)
            {
                DisplayResults("Method 5: String 1 has fewer letters.", false);
            } else
            {
                DisplayResults("Method 5: Both strings have same amount of letters.", false);
            }
        }

        /// <summary>
        /// Method 6: Takes an Array of Doubles, returns largest of the bunch
        /// </summary>
        /// <param name="arrDoubles"></param>
        /// <returns></returns>
        private double LargestDouble(double[] arrDoubles)
        {
            int arrPointer = 0;
            double valueAtIndex = 0D;
            double biggestdouble = 0D;

            while(arrPointer < arrDoubles.Length)
            {
                valueAtIndex = arrDoubles[arrPointer];
                if (valueAtIndex > biggestdouble) { biggestdouble = valueAtIndex; }
                arrPointer++;
            }

            return biggestdouble;
        }

        /// <summary>
        /// Method 7: Returns an Array of 10 Random Integers
        /// </summary>
        /// <returns></returns>
        private int[] TenRandomInts()
        {
            Random rand = new Random();
            int[] ints = new int[10];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rand.Next(0, 10);
            }
            return ints;
        }

        /// <summary>
        /// Method 8: Takes two Bools, returns true if they are same, else false
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        private bool CompareBools(bool b1, bool b2)
        {
            if (b1 == b2) { return true; } else { return false; }
        }

        /// <summary>
        /// Method 9: Takes a double and int, adds together, returns product
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="double1"></param>
        /// <returns></returns>
        private double Product(int num1, double double1)
        {
            double prod = num1 + double1;
            return prod;
        }
    }
}