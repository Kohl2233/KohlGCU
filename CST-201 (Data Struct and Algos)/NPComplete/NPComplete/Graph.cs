using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPComplete
{
    public class Graph
    {
        // Attributes
        private int vertices; // number of vertices
        private List<int>[] adj; // adjacency matrix
        public int numColors = 0; // number of colors needed

        // Constructor
        public Graph(int vertices)
        {
            this.vertices = vertices;
            adj = new List<int>[vertices];
            for (int i = 0; i < vertices; ++i)
            {
                adj[i] = new List<int>();
            }
        }



        /// <summary>
        /// Method to Add Edge Between Two Vertices
        /// O(1)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        public void addEdge(int source, int target)
        {
            // Add Edge to Both since Graph is Undirected
            adj[source].Add(target);
            adj[target].Add(source);
        }



        /// <summary>
        /// Method to 'Color' Graph
        /// </summary>
        public void Color()
        {
            int[] result = new int[vertices];

            // Make all Vertices have Unassigned Color (-1)
            for (int i = 0; i < vertices; i++)
            {
                result[i] = -1;
            }

            // Assign First Color to First Vertex
            result[0] = 0; // color 1 is 0

            // Create temp array to store available colors
            // value of available[i] would denote that color i
            // is already assigned to adjacent vertex
            bool[] available = new bool[vertices];

            // Set All Colors to Initially be Available
            for (int i = 0; i < vertices; i++)
            {
                available[i] = true;
            }

            // Assign Colors to the Rest of the Vertices
            for (int u = 1; u < vertices; u++)
            {
                // For Each Edge (adjacent vertex) of Current Vertex
                // mark their color as unavailable
                foreach (int i in adj[u])
                {
                    if (result[i] != -1) { available[result[i]] = false; }
                }

                // Find an Available Color
                int color;
                for (color = 0; color < vertices; color++)
                {
                    if (available[color]) 
                    {
                        if (color > numColors) { numColors = color; }
                        break;
                    }
                }

                // Assign the Found Color to Vertex
                result[u] = color;

                // Reset Values for Next Iteration
                for (int i = 0; i < vertices; i++) 
                {
                    available[i] = true;
                }
            }

            // Print out Results
            Console.WriteLine("-- Color Graph --");
            for (int i = 0; i < vertices; i++)
            {
                Console.WriteLine("Vertex {0} --- Color {1}", i, result[i]);
            }

            Console.WriteLine("\nNumber of Lectures Needed: {0}", numColors + 1);

            int[] conflicts = new int[numColors + 1];
            for (int i = 0; i < conflicts.Length; i++) { conflicts[i] = 0; }
            for (int i = 0; i < result.Length; i++)
            {
                int color = result[i];
                conflicts[color] += 1;
            }

            Console.WriteLine("\n-- Number Conflicts Per Lecture --");
            for (int i = 0; i < conflicts.Length; i++) 
            {
                Console.WriteLine("Lecture {0}: {1}", i + 1, vertices - conflicts[i]);
            }
        }
    }
}
