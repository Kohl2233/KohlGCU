using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSorting
{
    internal class DynamicArray
    {
        // Attributes
        private int[] array;
        private int count;
        private int size;



        // Default Constructor
        public DynamicArray()
        {
            array = new int[1];
            count = 0;
            size = 1;
        }

        

        /// <summary>
        /// Method to Add New Element at End of Array
        /// </summary>
        /// <param name="val"></param>
        public void Add(int val)
        {
            // Check Size, Grow if Needed
            if (count == size)
            {
                GrowSize();
            }

            // Add new Element, Increment Count
            array[count] = val;
            count++;
        }



        /// <summary>
        /// Method to Double Size of Array
        /// </summary>
        public void GrowSize()
        {
            int[] temp = null;
            if (count == size)
            {
                temp = new int[size * 2];
                for (int i = 0; i < size; i++)
                {
                    // Copy Values
                    temp[i] = array[i];
                }

                // Update Attributes
                this.array = temp;
                this.size = size * 2;
            }
        }



        /// <summary>
        /// Method to Decrease Size of Array
        /// </summary>
        public void ShrinkSize()
        {
            int[] temp = null;
            if (count > 0)
            {
                temp = new int[count];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = array[i];
                }
            }

            // Update Attributes
            this.array = temp;
            this.size = count;

        }



        /// <summary>
        /// Method to Add Val at Given Index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="val"></param>
        public void AddAt(int index, int val)
        {
            // Double Check Size
            if (count == size)
            {
                GrowSize();
            }

            for (int i = count - 1; i >= index; i--)
            {
                // Shift All Elements After Index to the Right
                array[i + 1] = array[i];
            }

            // Insert New Val, Update Attributes
            array[index] = val;
            count++;
        }



        /// <summary>
        /// Method to Overwrite Array
        /// </summary>
        /// <param name="arr"></param>
        public void OverwriteArray(int[] arr)
        {
            array = arr;
        }



        /// <summary>
        /// Method to Shuffle Array
        /// </summary>
        public void ShuffleArray()
        {
            Random randy = new Random();
            for (int i = 0; i < count; i++)
            {
                // Get Two Random Indexes
                int randIdxOne = randy.Next(count);
                int randIdxTwo = randy.Next(count);

                int randOne = array[randIdxOne];
                int randTwo = array[randIdxTwo];

                // Swap Em
                array[randIdxOne] = randTwo;
                array[randIdxTwo] = randOne;
            }
        }



        /// <summary>
        /// Method to Get Copy of Array
        /// </summary>
        /// <returns></returns>
        public int[] GetArray()
        {
            return array;
        }



        /// <summary>
        /// Method to Get Val at Index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetValAtIndex(int index)
        {
            return array[index];
        }
    }
}
