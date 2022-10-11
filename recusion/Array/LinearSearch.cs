using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class LinearSearch
    {
        public static int LeanerSearchMethod(int[] input,int element)
        {
            int i = 0;
            while (i < input.Length)
            {
                if (input[i] == element)
                {
                    return i+1;
                }
                i++;
            }
            return -1;
        }
    }
}
