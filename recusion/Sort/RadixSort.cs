using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
    public static class RadixSort
    {
        public static List<int> RadixSortMethod(List<int> input)
        {
            int max = input[0];

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
            }

            int exp = 1;
           
            while (exp <= max)
            {
                input = CountSortMethod(input, exp);
                exp = exp * 10;
            }
            return input;
        }


        public static List<int> CountSortMethod(List<int> input, int exp)
        {
            int[] result = new int[input.Count];
            int[] countArray = new int[10];

            for (int i = 0; i < input.Count; i++)
            {
                int value = input[i];
                countArray[value/exp%10]++;

            }

            for (int i = 0; i < countArray.Length - 1; i++)
            {
                countArray[i + 1] = countArray[i + 1] + countArray[i];
            }

            for (int i = input.Count - 1; i >= 0; i--)
            {
                int value = input[i]/exp%10;
                result[countArray[value] - 1] = input[i];
                countArray[value]--;
            }

            return result.ToList();

        }
    }
}

