using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
   public static class UnionUnSortedArray
    {
        public static int[] Method(int[] arrayOne , int[] arrTwo)
        {
            HashSet<int> newSet = new HashSet<int>();
            var finalArray = new int[arrTwo.Length + arrayOne.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < arrayOne.Length)
            {
                if (!newSet.Contains(arrayOne[i]))
                {
                    newSet.Add(arrayOne[i]);
                    finalArray[k] = arrayOne[i];
                    k++;
                }
                i++;
            }
            while (j < arrTwo.Length)
            {
                if (!newSet.Contains(arrTwo[j]))
                {
                    newSet.Add(arrTwo[j]);
                    finalArray[k] = arrTwo[j];
                    k++;
                }
                j++;
            }

            return finalArray;
        }
    }
}
