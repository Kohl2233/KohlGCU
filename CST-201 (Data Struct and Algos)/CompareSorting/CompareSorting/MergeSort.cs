using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSorting
{
    internal class MergeSort
    {
        // Attributes
        public int numComps = 0;
        public int numExchanges = 0;
        private int[] arr = null;
        
        // Default Constructor
        public MergeSort(DynamicArray arr) 
        {
            this.arr = arr.GetArray();
        }

        /// <summary>
        /// Method For Recursively Splitting Array into Two
        /// </summary>
        /// <param name="array"></param>
        private void Sort(int[] array)
        {
            // Base Case
            if (array.Length <= 1) return;

            // Split Array into Two
            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            // Populate Left Array
            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
                numComps++;
            }

            // Pop Right Array
            for (int i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
                numExchanges++;
            }

            // Recursive Call
            Sort(left);
            Sort(right);

            // Merge
            Merge(array, left, right);
        }


        /// <summary>
        /// Method For Merge Two Halfs With Main Array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                numComps++;
                numExchanges++;
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                } else
                {
                    array[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                numExchanges++; numComps++;
                array[k++] = left[i++];
            }

            while (j < right.Length)
            {
                numExchanges++; numComps++;
                array[k++] = right[j++];
            }
        }

        /// <summary>
        /// Public Method for Performing Merge Sort
        /// </summary>
        public void PerformMergeSort()
        {
            Sort(this.arr);
        }
    }
}
