namespace GraphAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create Graph
            Graph graph = new Graph(5);

            // Add Edges
            // Node 0
            graph.AddEdge(0, 1, 3);
            // Node 1
            graph.AddEdge(1, 2, 6);
            // Node 2
            graph.AddEdge(2, 0, 1);
            // Node 3
            graph.AddEdge(3, 0, -4);
            graph.AddEdge(3, 2, 5);
            // Node 4
            graph.AddEdge(4, 0, 1);
            graph.AddEdge(4, 1, 3);
            graph.AddEdge(4, 2, 2);
            graph.AddEdge(4, 3, 2);

            // Call Algo
            bool result = graph.IsCyclic();
            if (result)
            {
                Console.WriteLine("Cycle Detected.");
                graph.PrintPath();
            } else
            {
                Console.WriteLine("No Cycle Present.");
            }
        }
    }
}