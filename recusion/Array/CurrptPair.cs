using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class CurrptPair
    {
        public static void Method(List<int> input)
        {
            int[] newArray = new int[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                int val = input[i] - 1;
                newArray[val]++;
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] == 0)
                {
                    Console.WriteLine($"Missing {i + 1}");
                }
                else if (newArray[i] > 1)
                {
                    Console.WriteLine($"Duplicate {i + 1}");
                }

            }
        }
    }
}
