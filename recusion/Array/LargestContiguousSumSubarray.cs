using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class LargestContiguousSumSubarray
    {
        public static int Max(int[] input)
        {
            int maxSoFar = int.MinValue;
            int maxEndingHere = 0;

            for (int i = 0; i < input.Length; i++)
            {
                maxEndingHere = maxEndingHere + input[i];

                if (maxEndingHere < 0)
                {
                    maxEndingHere = 0;
                }
                else if(maxSoFar<maxEndingHere)
                {
                    maxSoFar = maxEndingHere;
                }
            }
            return maxSoFar;

        }
    }
}
