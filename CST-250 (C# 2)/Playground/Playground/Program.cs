namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int propellant = 10;
            Console.WriteLine("Recursive Function..");
            BurnBooster(propellant);
            Console.WriteLine("\n\nWhile Loop Function");
            BurnBoosterLoop(propellant);
        }

        // Recursive Function
        static void BurnBooster(int propellant)
        {
            // Base Case
            if (propellant < 1)
            {
                Console.WriteLine("Out of Propellant :(");
            } else
            {
                // General Case
                Console.WriteLine("Propellant: {0}", propellant);
                BurnBooster(propellant - 1); // call self
            }
        }

        // Simnple Loop Example
        static void BurnBoosterLoop(int propellant)
        {
            while (propellant > 0)
            {
                Console.WriteLine("Propellant: {0}", propellant);
                propellant--;
            }
            Console.WriteLine("Out of Propellant :(");
        }
    }
}