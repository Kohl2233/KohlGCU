namespace RecursionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count to One Example
            Console.Out.WriteLine("-- Count to One --");
            Console.Out.Write("Please Enter an Integer: ");
            int startNum = int.Parse(Console.ReadLine());
            int x = CountToOne(startNum);

            // Factorial Example
            Console.Out.WriteLine("\n\n-- Factorial --");
            startNum = 6;
            Console.Out.WriteLine("Final Result: {0}", Factorial(startNum));

            // Greatest Common Denominator Example
            Console.Out.WriteLine("\n\n-- GCD --");
            int num1 = 400;
            int num2 = 85;
            int answer = GCD(num1, num2);
            Console.Out.WriteLine("The GCD of {0} and {1} is {2}", num1, num2, answer);
        }



        /// <summary>
        /// Function for Counting to One using Recursion
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static public int CountToOne(int num)
        {
            Console.Out.WriteLine("Num is {0}", num);
            if (num == 1) {
                return 1;
            } else
            {
                if (num % 2 == 0)
                {
                    Console.Out.WriteLine("{0} is even, we will divide by 2.", num);
                    return CountToOne(num / 2);
                } else
                {
                    Console.Out.WriteLine("{0} is odd, we will add one.", num);
                    return CountToOne(num + 1);
                }
            }
        }



        /// <summary>
        /// Function for Factorials using Recursion
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int Factorial(int num)
        {
            Console.Out.WriteLine("Num is {0}", num);
            if (num == 1)
            {
                return 1;
            } else
            {
                return num * Factorial(num - 1);
            }
        }



        /// <summary>
        /// Function for Finding GCD using Recursion
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int GCD(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            } else
            {
                Console.Out.WriteLine("Not Found Yet. Remainder is {0}", num1 % num2);
                return GCD(num2, num1 % num2);
            }
        }
    }
}