using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public static class TargetSumPair
    {
        public static void TargetSumPairMethod(List<int> input,int sum)
        {
            input.Sort();
            int i = 0;
            int j = input.Count - 1;

            while (i <= j)
            {
                if(input[i]+input[j]>sum)
                {
                    j--;
                }
                else if(input[i] + input[j] < sum)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine($"{i}  {j}");
                    i++;
                    j--;
                }
            }
        }
    }
}
