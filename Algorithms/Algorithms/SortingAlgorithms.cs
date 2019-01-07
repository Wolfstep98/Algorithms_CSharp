using System;
using System.Collections.Generic;

namespace Algorithms
{
    namespace SortingAlgorithms
    {
        public static class SelectionSort<T> where T : IComparable<T>
        {
            /// <summary>
            /// Sort the array using the Selection Sort Algorithms.
            /// </summary>
            /// <param name="array">The array to sort.</param>
            public static void Sort(T[] array)
            {
                if (array == null)
                    throw new NullReferenceException("The array you try to sort is referenced to null.");
                if (array.Length == 0 || array.Length == 1)
                    return;

                int minIndex = 0;

                for(int index = 0; index < array.Length - 1; index++)
                {
                    minIndex = index;
                    for(int i = index + 1; i < array.Length;i++)
                    {
                        if (array[i].CompareTo(array[minIndex]) == -1)
                            minIndex = i;
                    }
                    if (index != minIndex)
                        Swap(array, index, minIndex);    
                }
            }

            /// <summary>
            /// Swap 2 values at 2 differents indexes.
            /// </summary>
            /// <param name="array">The array to swap values.</param>
            /// <param name="index">Index of the first value to swap.</param>
            /// <param name="minIndex">Index of the second value to swap.</param>
            private static void Swap(T[] array, int index, int minIndex)
            {
                T temp = array[index];
                array[index] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}
