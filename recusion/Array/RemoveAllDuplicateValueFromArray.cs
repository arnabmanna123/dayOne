using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class RemoveAllDuplicateValueFromArray
    {
        public static int[] Method(int[] input)
        {
            var result = new int[input.Length];
            result[0] = input[0];
            int j = 1;
            for(int i = 1; i < input.Length; i++)
            {
                if (result[j - 1] != input[i])
                {
                    result[j] = input[i];
                        j++;
                }
            }
            return result;
        }
    }
}
