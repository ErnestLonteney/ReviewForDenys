using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    static class ArrayFilters
    {
        public static int[] Filter(this int[] array, Predicate predicate)
        {
            int[] result = new int[array.Length];

            for (int i = 0, k = 0; i < array.Length; i++)
            {
                if (predicate.Invoke(array[i]))
                {
                    result[k++] = array[i];
                }
            }

            return result;
        }
    }
}
