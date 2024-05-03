using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CompareSorting
{
    internal class QuickSort
    {
        public int numComps = 0;
        public int numExchanges = 0;
        private int[] arr = null;

        // Default Constructor
        public QuickSort(DynamicArray arr) 
        {
            this.arr = arr.GetArray();
        }

        /// <summary>
        /// Method to Swap two Elements
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            numExchanges += 3;
        }
        
        /// <summary>
        /// Method to Choose a Pivot
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private int Partition(int[] array, int low, int high)
        {
            // Choose Pivot
            int pivot = arr[high];
            int i = (low - 1);
            numExchanges += 2;
            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    // Inc Index, Swap
                    numComps++;
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, high);
            return (i + 1);
        }

        /// <summary>
        /// Method to Recursivelly Quick Sort
        /// </summary>
        /// <param name="array"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        private void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                numComps++;
                int pi = Partition(array, low, high);
                numExchanges++;
                Sort(array, low, pi - 1);
                Sort(array, pi + 1, high);
            }
        }

        /// <summary>
        /// Public Method to Perform Quick Sort
        /// </summary>
        public void PerformQuickSort()
        {
            Sort(this.arr, 0, this.arr.Length - 1);
        }
    }
}
