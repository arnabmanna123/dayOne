using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class MaxMultiplicationOfTwoNumber
    {
        public static int MaxMultiplication(List<int> input)
        {
            input.Sort();
            int len = input.Count;
            int resultOne = input[0] * input[1];
            int resultTwo = input[len-1] * input[len-2];
            if (resultOne > resultTwo)
            {
                return resultOne;
            }
            else
            {
                return resultTwo;
            }
        }
    }
}
