using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class MaxSumSubArray
    {
        public static int MethodPositive(List<int> input)
        {
            int maxSoFar = 0;
            int sumTillHere = 0;

            for(int i =0; i < input.Count; i++)
            {
                sumTillHere += input[i];
                if (maxSoFar < sumTillHere)
                {
                    maxSoFar = sumTillHere;
                }
                if (sumTillHere < 0)
                {
                    sumTillHere = 0;
                }
            }
            return maxSoFar;

        }

        public static int MethodPositiveNegetive(List<int> input)
        {
            int maxSoFar = int.MinValue;
            int sumTillHere = 0;
            int max_element = int.MinValue;
            bool isAllNegetiveVal = true;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] >= 0)
                {
                    isAllNegetiveVal = false;
                }
                max_element = Math.Max(max_element, input[i]);
                sumTillHere += input[i];
                if (maxSoFar < sumTillHere)
                {
                    maxSoFar = sumTillHere;
                }
                if (sumTillHere < 0)
                {
                    sumTillHere = 0;
                }
            }
            if (isAllNegetiveVal)
            {
                return max_element;
            }
            return maxSoFar;

        }

    }
}
