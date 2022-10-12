using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    public static class FindAllTripletsForGivenSum
    {
        public static void Method(List<int> input, int target)
        {

            input.Sort();
            int[] triplet = new int[3];
            for (int i = 0; i < input.Count; i++)
            {
                int leftPart = target - (input[i]);

                int k = i + 1;
                int j = input.Count - 1;
                while (k < j)
                {

                    if (input[k] + input[j] > leftPart)
                    {
                        j--;
                    }
                    else if (input[k] + input[j] < leftPart)
                    {
                        k++;
                    }
                    else
                    {
                        Console.WriteLine($"{input[i]},{input[j]},{input[k]}");
                        j--;
                        k++;
                    }




                }
            }
        }
    }
}
