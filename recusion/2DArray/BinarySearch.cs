using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class BinarySearch
    {
        public static void Method(List<List<int>> input, int target)
        {
            int i = 0;
            int j = input[0].Count - 1;
            while (true)
            {

                if (input[i][j] > target)
                {
                    j--;
                }
                else if (input[i][j] < target)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine($"Found at {i + 1} ,{j + 1} the value was {input[i][j]}");
                    break;
                }

                if (i < 0 || i>= input.Count || j< 0 || j >= input.Count)
                {
                    Console.WriteLine("Not Found !!");
                    break;
                }
            }
        }
    }
}
