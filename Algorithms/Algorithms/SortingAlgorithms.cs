using System;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Main class for sortings algortihms.
    /// </summary>
    /// <typeparam name="T">Type to sort. Must implement IComparable<typeparamref name="T"/> interface.</typeparam>
    public static class Sort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sort the array using the Selection Sort Algorithms.
        /// </summary>
        /// <param name="array">The array to sort.</param>
        public static void SelectionSort(T[] array)
        {
            if (array == null)
                throw new NullReferenceException("The array you try to sort is referenced to null.");
            if (array.Length == 0 || array.Length == 1)
                return;

            int minIndex = 0;

            for (int index = 0; index < array.Length - 1; index++)
            {
                minIndex = index;
                for (int i = index + 1; i < array.Length; i++)
                {
                    if (array[i].CompareTo(array[minIndex]) == -1)
                        minIndex = i;
                }
                if (index != minIndex)
                    Swap(array, index, minIndex);
            }
        }

        /// <summary>
        /// Sort the array using the Insertion Sort Algorithms.
        /// </summary>
        /// <param name="array">The array to sort.</param>
        public static void InsertionSort(T[] array)
        {
            if (array == null)
                throw new NullReferenceException("The array you try to sort is referenced to null.");
            if (array.Length == 0 || array.Length == 1)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                T indexValue = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(indexValue) == 1)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = indexValue;
            }
        }

        /// <summary>
        /// Sort the array using the Bubble Sort Algorithms.
        /// </summary>
        /// <param name="array">The array to sort.</param>
        public static void BubbleSort(T[] array)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) == 1)
                    {
                        if (!swapped) swapped = true;
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Sort the array using the Shell Sort Algorithms.
        /// </summary>
        /// <param name="array">The array to sort.</param>
        public static void SheelSort(T[] array)
        {

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
