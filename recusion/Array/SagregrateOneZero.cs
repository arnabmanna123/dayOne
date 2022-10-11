using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
   public static class SagregrateOneZero
    {
        public static List<int> Method(List<int> input)
        {
            int i = 0,j = 0;

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
