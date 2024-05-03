using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Source(s)
 * DFS: https://www.geeksforgeeks.org/depth-first-search-or-dfs-for-a-graph/
 * Weighted/Directed Graphs: https://www.tutorialspoint.com/weighted-graph-representation-in-data-structure
 * Floyd-Warshall: https://www.geeksforgeeks.org/floyd-warshall-algorithm-dp-16/
 */

namespace GraphAlgorithms
{
    internal class Graph
    {
        // Attrbiutes
        private int NumNodes;
        private List<List<int[]>> AdjNodes;

        private bool[] visited, recStack;

        private int numComps = 0, numExchanges = 0;

        // Default Constructor
        public Graph (int NumNodes)
        {
            this.NumNodes = NumNodes;
            AdjNodes = new List<List<int[]>>(NumNodes);

            for (int i = 0; i < NumNodes; i++)
            {
                AdjNodes.Add(new List<int[]>());
            }
        }



        /// <summary>
        /// Method to Add Edge to Graph
        /// Big O: O(1)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <param name="weight"></param>
        public void AddEdge(int source, int dest, int weight)
        {
            // add edge to list of source node's adjacent nodes (children)
            int[] destWeight = { dest, weight };
            AdjNodes[source].Add(destWeight);
        }



        /// <summary>
        /// Recursive Function to Check if Cycle Exists
        /// Big O: O(n + e), n being num nodes, e being num edges
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool RecursiveCycleCheck(int i)
        {
            // Mark Current Node as Visited & Part of Recursion Stack
            if (recStack[i]) { return true; }
            if (visited[i]) { return false; }
            numComps += 2;

            visited[i] = true;
            recStack[i] = true;
            List<int[]> children = AdjNodes[i];
            numExchanges++;

            // Check Each Child
            for (int j = 0; j < children.Count; j++)
            {
                numComps++;
                if (RecursiveCycleCheck(children[j][0])) { return true; }
            }

            recStack[i] = false;
            return false;
        }



        /// <summary>
        /// Start Point For Checking if Graph has a Cycle
        /// </summary>
        /// <returns></returns>
        public bool IsCyclic()
        {
            // Reset Visited and RecStack
            visited = new bool[NumNodes];
            recStack = new bool[NumNodes];

            // Call Recursive Function to Check Each Tree
            for (int i = 0; i < NumNodes; i++)
            {
                if (RecursiveCycleCheck(i)) 
                {
                    return true; 
                }
            }

            return false;
        }



        /// <summary>
        /// Simple(ish) Method to Print Path w/ Nodes and Weight
        /// </summary>
        public void PrintPath()
        {
            // Get Path
            List<String> cyclePath = new List<String>();
            List<int> cycleWeight = new List<int>();
            int weightSum = 0;
            for (int i = 0; i < NumNodes; i++)
            {
                if (recStack[i] == true)
                {
                    cyclePath.Add(getFancyNodeName(i));
                }
            }

            // Add Start Node to End (to visually show start is same as end)
            cyclePath.Add(getFancyNodeName(0));

            // Get All Weights
            for (int i = 0; i < cyclePath.Count - 1; i++)
            {
                // Get Edges for Current Node
                List<int[]> children = AdjNodes[i];
                int destTarget;
                if (i + 1 == cyclePath.Count - 1)
                {
                    destTarget = 0;
                } else { destTarget = i + 1; }

                // Find Weight
                for (int j = 0; j < children.Count; j++)
                {
                    if (children[j][0] == destTarget)
                    {
                        cycleWeight.Add(children[j][1]);
                        weightSum += children[j][1];
                    }
                }

            }

            Console.Write("\nPath:\t");
            for (int i = 0; i < cyclePath.Count; i++)
            {
                if (i != cyclePath.Count - 1)
                {
                    Console.Write(String.Format("{0} -- {1} --> ", cyclePath[i], cycleWeight[i]));
                } else
                {
                    Console.Write(String.Format("{0}", cyclePath[i]));
                }
                
            }
            Console.WriteLine("\nTotal Weight: {0}", weightSum);
            Console.WriteLine("\nTotal Comparisons: {0}\nTotal Data Exchanges: {1}", numComps, numExchanges);
        }




        private string getFancyNodeName(int i)
        {
            string res = "";
            switch (i)
            {
                case 0: res = "A"; break;
                case 1: res = "B"; break;
                case 2: res = "C"; break;
                case 3: res = "D"; break;
                case 4: res = "E"; break;
            }
            return res;
        }
    }
}
