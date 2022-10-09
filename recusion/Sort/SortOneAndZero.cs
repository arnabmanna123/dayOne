using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public static class SortOneAndZero
    {

        public static List<int> SortOneAndZeroMethod(List<int> input)
        {
            int i = 0;
            int j = 0;
            while (i < input.Count)
            {
                if (input[i] == 1)
                {
                    i++;
                }
                else
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                    j++;
                }
            }
            return input;
        }
     }
}
