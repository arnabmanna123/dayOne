using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class SagretrateEvenOdd
    {
        public static List<int> Method(List<int> input)
        {
            int i = 0;
            int j = 0;
            while (i < input.Count)
            {
                if (input[i] % 2 != 0)
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
