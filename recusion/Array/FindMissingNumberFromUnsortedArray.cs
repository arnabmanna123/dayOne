using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
   public static class FindMissingNumberFromUnsortedArray
    {
        public static int FindMissing(List<int> number)
        {
            int total = number.Count + 1;
            int sum = (total * (total + 1)) / 2;
            for(int i=0; i< number.Count; i++)
            {
                sum = sum - number[i];
            }
            return sum;
        }
    }
}
