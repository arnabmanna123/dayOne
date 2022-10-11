using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class FIrstMissingPositiveNumber
    {
        public static int Method(List<int> input)
        {
            int[] newArr = new int[input.Count + 1];

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] < newArr.Length && 0 < input[i])
                {
                    int indx = input[i] - 1;
                    newArr[indx]++;
                }
            }

            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == 0)
                {
                    return i + 1;
                }
            }

            return -1;
        }


        public static void MethodToFindKMissingNumber(List<int> input, int k)
        {
            int max = int.MinValue;

            for(int i = 0; i < input.Count; i++)
            {
                if (max < input[i])
                {
                    max = input[i];
                }
            }
            int[] aNewArr = new int[max];
            for(int i = 0; i < input.Count; i++)
            {
                if (input[i] > 0 && input[i] > 0)
                {
                    int val = input[i]-1;
                    aNewArr[val]++;
                }
            }

            int t = 0;
            int j = 0;
            while (t <= k && j<aNewArr.Length-1)
            {
                if (aNewArr[j] == 0)
                {
                    Console.WriteLine(j+1);
                    k++;
                }
                j++;
            }
        }


    }
}
