using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class TripletsWithSumSmallerYhanTargetSum
    {
        public static void Method(List<int> input, int target)
        {
            for(int i = 0; i < input.Count; i++)
            {
                int leftPart = target - input[i];

                int j = i + 1;
                int k = input.Count - 1;

                while (j < k)
                {
                    if (input[j] + input[k] > leftPart)
                    {
                        k--;
                    }
                    else if(input[j] + input[k] == leftPart)
                    {
                        j++;
                        
                    }
                    else
                    {
                        Console.WriteLine($"{input[i] } {input[j] } {input[k] }");
                        j++;
                    }
                }

            }
        }
    }
}
