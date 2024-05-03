using System.Runtime.CompilerServices;

namespace GreedyAlgo
{
    public class Program
    {
        // Driver Method
        static void Main(string[] args)
        {
            // Variables
            Algo algo = new Algo();
            int numItems = 6, weightLimit = 280;
            List<TradeGood> goods = new List<TradeGood>();

            // Six Items
            // Add Goods to List
            goods.Add(new TradeGood(20, 70));
            goods.Add(new TradeGood(30, 80));
            goods.Add(new TradeGood(40, 90));
            goods.Add(new TradeGood(60, 110));
            goods.Add(new TradeGood(70, 120));
            goods.Add(new TradeGood(90, 200));

            // Find Solution
            Console.WriteLine("Max Profit with 6 Goods: {0}\n\tNum Steps: {1}\n\tNum Comparisons: {2}",
                algo.KnapSack(numItems, weightLimit, goods), algo.numSteps, algo.numComps);

            goods.Clear();
            algo.numSteps = 0; algo.numComps = 0;
            // Ten Items
            // Add Goods to List
            numItems = 10;
            goods.Add(new TradeGood(20, 70));
            goods.Add(new TradeGood(30, 80));
            goods.Add(new TradeGood(30, 80));
            goods.Add(new TradeGood(40, 90));
            goods.Add(new TradeGood(60, 110));
            goods.Add(new TradeGood(60, 110));
            goods.Add(new TradeGood(60, 110));
            goods.Add(new TradeGood(70, 120));
            goods.Add(new TradeGood(90, 200));
            goods.Add(new TradeGood(90, 200));

            // Find Solution
            Console.WriteLine("\nMax Profit with 10 Goods: {0}\n\tNum Steps: {1}\n\tNum Comparisons: {2}",
                algo.KnapSack(numItems, weightLimit, goods), algo.numSteps, algo.numComps);
        }       
    }
}