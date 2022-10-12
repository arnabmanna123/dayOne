using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class MissingAndDuplicateValues
    {
        public static void Method(List<int> input)
        {
            int[] newArr = new int[input.Count];
            for(int i =0; i<input.Count; i++)
            {
                int val = input[i] - 1;
                newArr[val]++;
            }

            for(int i=0; i<newArr.Length; i++)
            {
                if (newArr[i] == 0)
                {
                    Console.WriteLine($"Missing {i+1}");
                }
                else if(newArr[i]>1)
                {
                    Console.WriteLine($"Duplicate {i + 1}");
                }
            }
        }
    }
}
