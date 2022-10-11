using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class PairThatMatchTheSum
    {
        public static void Method(List<int> number,int sum)//should be sorted
        {
            
            int i = 0;
            int j = number.Count-1;
            while (i <= j)
            {
                if (number[i] + number[j] > sum)
                {
                    j--;
                }
                else if(number[i] + number[j] < sum)
                {
                    i++; 
                }
                else
                {
                    Console.WriteLine($"{i}{j}");
                }
            }
        }
    }
}
