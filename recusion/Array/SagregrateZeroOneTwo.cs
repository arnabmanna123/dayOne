using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class SagregrateZeroOneTwo
    {
        public static List<int> Method(List<int> input)
        {
            int i = 0;
            int j = 0;
            int k = input.Count-1;

            while (i <= k)
            {
                if (input[i] == 2)
                {
                    int temp = input[i];
                    input[i] = input[k];
                    input[k] = temp;
                    k--;
                }
                else if (input[i] == 1)
                {
                    i++;
                }
                else if (input[i] == 0)
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    j++;
                    i++;
                }
            }

            return input;
        }
    }
}
