using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class BinarySearch
    {
        public static int BinarySearchMethod(int[] input,int element)
        {
            int mid = input.Length / 2;

            if (input[mid] == element)
            {
                return mid;
            }
            else if(input[mid] > element)
            {
              return  linierSearch(input, 0, mid - 1, element);
            }
            else
            {
                return linierSearch(input, mid +1, input.Length-1, element);

            }
        }

        static int linierSearch(int[] input, int start , int end,int value)
        {
            while (start <= end)
            {
                if (input[start] == value)
                {
                    return start;
                }
                start++;
            }
            return -1;
        }
    }
}
