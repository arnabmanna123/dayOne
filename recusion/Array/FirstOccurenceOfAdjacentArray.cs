using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class FirstOccurenceOfAdjacentArray
    {
        public static int FindIndex(List<int> input,int number)
        {
            int i = input[0]-number;
            int j = 0;
            while (j<=input.Count)
            {
                j += i;
                if (input[j] == number)
                {
                    return j;
                }
                i = input[j] - number;
            }
            return -1;
        }

        public static int FindIndexWithADifferAtMostAdjocentValue(List<int> input, int number, int diff)
        {
        
            int j = 0;
            while (j < input.Count)
            {
                if (number == input[j])
                {
                    return j;
                }
                 j += (number - input[j]) / diff == 0 ? 1 : (number - input[j]) / diff;
               
            }
            return -1;
        }
    }
}
