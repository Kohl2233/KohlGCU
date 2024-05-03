using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSorting
{
    internal class SortingAlgorithms
    {
        // Default Constructor
        public SortingAlgorithms() { }



        /// <summary>
        /// Method for using Selection Sort Algo
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SelectionSort(DynamicArray dyArr)
        {
            int[] array = dyArr.GetArray();
            int numCompare = 0;
            int numDataExchange = 0;
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Find Min Element
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min_idx]) { min_idx = j; }
                    numCompare++;
                    numDataExchange++;
                }

                // Swap Found Element with First Element
                int temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
                numDataExchange += 3;
            }

            // Overwrite Array
            dyArr.OverwriteArray(array);

            // Return Num Comparisons
            int[] ret = new int[2];
            ret[0] = numCompare; ret[1] = numDataExchange;
            return ret;
        }



        /// <summary>
        /// Method for Using Bubble Sort Algo
        /// </summary>
        /// <param name="dyArr"></param>
        /// <returns></returns>
        public int[] BubbleSort(DynamicArray dyArr)
        {
            int[] array = dyArr.GetArray();
            int numCompares = 0;
            int numDataExchanges = 0;
            int i, j, temp;
            int n = dyArr.GetArray().Length;
            bool swapped;
            for (i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap Two Vals
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                        numCompares++;
                        numDataExchanges += 3;
                    }
                }

                if (swapped == false) { break; }
            }

            // Overwrite Array
            dyArr.OverwriteArray(array);

            // Return Data
            int[] ret = new int[2];
            ret[0] = numCompares; ret[1] = numDataExchanges;
            return ret;
        }
    }
}
