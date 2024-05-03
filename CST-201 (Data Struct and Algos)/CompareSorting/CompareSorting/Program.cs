using System.Drawing;
using System.Numerics;

namespace CompareSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Benchmark Vars
            int selectSortAverage, bubbleSortAverage, mergeSortAverage, quickSortAverage, insertionSortAverage;

            // User Input
            Console.Write("Enter an Integer: ");
            string sizeString = Console.ReadLine();
            int size = Int32.Parse(sizeString);
            Console.WriteLine("\n\n");

            // Create Dynamic Array & Populate
            DynamicArray dynamicArray = new DynamicArray();
            for (int i = 0; i < size; i++)
            {
                dynamicArray.Add(i);
            }
            

            // Shrink Array
            dynamicArray.ShrinkSize();

            // Print Default Array
            //Console.Write("Base Array:      ");
            //printArray(dynamicArray.GetArray());

            // Shuffle Array
            dynamicArray.ShuffleArray();

            // Print Shuffled Array
            //Console.Write("Shuffled Array:  ");
            //printArray(dynamicArray.GetArray());

            // Create SortingAlgos Class
            SortingAlgorithms algos = new SortingAlgorithms();

            // Run Selection Sort 100 Times
            int sumComps = 0;
            int sumData = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.Write("\rRunning Selection Sorts... " +  (i + 1) + "%");

                // Run Selection Sort
                int[] results = algos.SelectionSort(dynamicArray);
                sumComps += results[0];
                sumData += results[1];
                
                // Shuffle After Each Sort
                if (i < 99)
                {
                    dynamicArray.ShuffleArray();
                }
            }

            selectSortAverage = sumComps / 100;
            Console.WriteLine("\nTotal Num Comparisons: " + String.Format("{0:n0}", sumComps) +
                "\nTotal Num Data Exchanges: " + String.Format("{0:n0}", sumData) +
                "\nAverage Num Comparisons: " + String.Format("{0:n0}", sumComps / 100) +
                "\nAverage Num Data Exchanges: " + String.Format("{0:n0}", sumData / 100) + "\n\n");

            //Console.Write("\nSorted Array:    ");
            //printArray(dynamicArray.GetArray());

            // Run Bubble Sort
            dynamicArray.ShuffleArray();
            sumComps = 0;
            sumData = 0;
            for (int i = 0; i < 100; i++)
            {
                Console.Write("\rRunning Bubble Sorts... " + (i + 1) + "%");

                // Run Bubble Sort
                int[] results = algos.BubbleSort(dynamicArray);
                sumComps += results[0];
                sumData += results[1];

                // Shuffle After Each Sort
                if (i < 99) { dynamicArray.ShuffleArray(); }
            }

            bubbleSortAverage = sumComps / 100;
            Console.WriteLine("\nTotal Num Comparisons: " + String.Format("{0:n0}", sumComps) +
                "\nTotal Num Data Exchanges: " + String.Format("{0:n0}", sumData) +
                "\nAverage Num Comparisons: " + String.Format("{0:n0}", sumComps / 100) +
                "\nAverage Num Data Exchanges: " + String.Format("{0:n0}", sumData / 100) + "\n\n");

            // Run Merge Sort
            dynamicArray.ShuffleArray();
            sumComps = 0;
            sumData = 0;
            for (int i = 0; i < 100; i++)
            {
                // Perform Sort
                Console.Write("\rRunning Merge Sorts... " + (i + 1) + "%");
                MergeSort sort = new MergeSort(dynamicArray);
                sort.PerformMergeSort();

                // Get Data
                sumComps += sort.numComps;
                sumData += sort.numExchanges;

                // Shuffle Array
                if (i < 99) { dynamicArray.ShuffleArray(); }
            }

            mergeSortAverage = sumComps / 100;
            Console.WriteLine("\nTotal Num Comparisons: " + String.Format("{0:n0}", sumComps) +
                "\nTotal Num Data Exchanges: " + String.Format("{0:n0}", sumData) +
                "\nAverage Num Comparisons: " + String.Format("{0:n0}", sumComps / 100) +
                "\nAverage Num Data Exchanges: " + String.Format("{0:n0}", sumData / 100) + "\n\n");

            // Run Quick Sort
            dynamicArray.ShuffleArray();
            sumComps = 0;
            sumData = 0;
            for (int i = 0; i < 100; i++)
            {
                // Perform Sort
                Console.Write("\rRunning Quick Sorts... " + (i + 1) + "%");
                QuickSort sort = new QuickSort(dynamicArray);
                sort.PerformQuickSort();

                // Get Data
                sumComps += sort.numComps;
                sumData += sort.numExchanges;

                // Shuffle Array
                if (i < 99) { dynamicArray.ShuffleArray(); }
            }

            quickSortAverage = sumComps / 100;
            Console.WriteLine("\nTotal Num Comparisons: " + String.Format("{0:n0}", sumComps) +
                "\nTotal Num Data Exchanges: " + String.Format("{0:n0}", sumData) +
                "\nAverage Num Comparisons: " + String.Format("{0:n0}", sumComps / 100) +
                "\nAverage Num Data Exchanges: " + String.Format("{0:n0}", sumData / 100) + "\n\n");

            // Run Custom Sort (Insertion Sort)
            dynamicArray.ShuffleArray();
            sumComps = 0;
            sumData = 0;
            for (int i = 0; i < 100; i++)
            {
                // Perform Sort
                Console.Write("\rRunning Insertion Sorts... " + (i + 1) + "%");
                InsertionSort sort = new InsertionSort(dynamicArray);
                sort.PerformInsertionSort();

                // Get Data
                sumComps += sort.numComps;
                sumData += sort.numExchanges;

                // Shuffle Array
                if (i < 99) { dynamicArray.ShuffleArray(); }
            }

            insertionSortAverage = sumComps / 100;
            Console.WriteLine("\nTotal Num Comparisons: " + String.Format("{0:n0}", sumComps) +
                "\nTotal Num Data Exchanges: " + String.Format("{0:n0}", sumData) +
                "\nAverage Num Comparisons: " + String.Format("{0:n0}", sumComps / 100) +
                "\nAverage Num Data Exchanges: " + String.Format("{0:n0}", sumData / 100) + "\n\n");

            
        }


        /// <summary>
        /// Method to Print out Array
        /// not used since arrays tested are huge
        /// </summary>
        /// <param name="array"></param>
        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    Console.Write(array[i] + ",");
                }
                else
                {
                    Console.Write(array[i] + "\n");
                }
            }
        }
    }
}