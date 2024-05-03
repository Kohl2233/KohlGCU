namespace NPComplete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create New Graph, size 7
            Graph graph = new Graph(7);

            // Add all Edges
            graph.addEdge(0, 1);
            graph.addEdge(0, 2);
            graph.addEdge(0, 4);

            graph.addEdge(1, 0);
            graph.addEdge(1, 2);
            graph.addEdge(1, 3);
            graph.addEdge(1, 5);

            graph.addEdge(2, 0);
            graph.addEdge(2, 1);
            graph.addEdge(2, 3);
            graph.addEdge(2, 5);
            graph.addEdge(2, 6);

            graph.addEdge(3, 1);
            graph.addEdge(3, 2);
            graph.addEdge(3, 5);
            graph.addEdge(3, 6);

            graph.addEdge(4, 0);
            graph.addEdge(4, 5);
            graph.addEdge(4, 6);

            graph.addEdge(5, 1);
            graph.addEdge(5, 2);
            graph.addEdge(5, 3);
            graph.addEdge(5, 4);

            graph.addEdge(6, 2);
            graph.addEdge(6, 3);
            graph.addEdge(6, 4);

            // Color the Graph
            graph.Color();
        }
    }
}