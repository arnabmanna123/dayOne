using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class DiagonalTraversal
    {
        public static void Method(List<List<int>> input)
        {
            int len = input.Count;
            for(int i=len-1; i>=0; i--)
            {
                int k = 0;
                int j = i;

                while (j <= len-1)
                {
                    Console.WriteLine(input[k][j]);
                    k++;
                    j++;
                }
            }
        }
    }
}
