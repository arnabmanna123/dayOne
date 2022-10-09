using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
   public static class CountSort
    {
        public static List<int> CountSortMethod(List<int> input , int min , int max)
        {
            int[] result = new int[input.Count];
            int[] countArray = new int[max - min + 1];

            for (int i = 0; i < input.Count; i++)
            {
                int value = input[i];
                countArray[value - min]++;

            }

            for(int i=0; i<countArray.Length-1; i++)
            {
                countArray[i + 1] = countArray[i + 1] + countArray[i];
            }

             for(int i = input.Count-1; i>=0; i--)
            {
                int value = input[i];
                result[countArray[value - min]-1] = value;
                countArray[value - min]--;
            }

            return result.ToList();

        }
    }
}
