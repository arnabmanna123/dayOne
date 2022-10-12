using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class CyclicSort
    {
        public static List<int> Method(List<int> input)
        {
            int i = 0;
            while (i < input.Count)
            {
                if (input[i] == i + 1)
                {
                    i++;
                }
                else if(input[i] != i + 1 && input[i] <= input.Count)
                {
                    int temp = input[i];
                    input[i] = input[temp - 1];
                    input[temp - 1] = temp;
                }
            }
            return input;
        }
    }
}
