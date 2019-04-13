using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    public static class SearchingValueAlgorithms<T> where T : struct, IComparable<T>
    {
        public static int LinearIndexSearch(T[] array, T item)
        {
            if (array == null)
                throw new NullReferenceException("The array you try to search in is not referenced.");

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
