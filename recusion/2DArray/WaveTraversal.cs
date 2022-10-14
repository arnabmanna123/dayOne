using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class WaveTraversal
    {
        public static void Method(List<List<int>> input)
        {
            for(int i=0; i< input[0].Count; i++)
            {
                if (i % 2 == 0)
                {
                    for(int j=0; j< input.Count; j++)
                    {
                        Console.WriteLine(input[j][i]);
                    }
                }
                else
                {
                    for (int j = input.Count-1; j >=0; j--)
                    {
                        Console.WriteLine(input[j][i]);

                    }
                }
            }
        }
    }
}
