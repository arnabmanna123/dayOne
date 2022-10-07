using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class QuickSort
    {
        public static List<int> QuickSortMethod(List<int> input, int lo , int hi)
        {
            if (lo >= hi)
            {
                return new List<int>();
            }
            
            int pi = partition(input, input[hi], lo, hi);
           
           QuickSortMethod(input, lo, pi - 1);
           QuickSortMethod(input, pi + 1, hi);
            return input;
        }


        public static int partition(List<int> input, int pivot , int lo, int hi)
        {
            int i = lo;
            int j = lo;

            while (i <= hi)
            {
                if(input[i] <= pivot)
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                    j++;
                }
                else
                {
                    i++;
                }

            }
            return j - 1;
        }

        
    }
}
