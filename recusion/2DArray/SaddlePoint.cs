using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class SaddlePoint
    {
        public static void Method(List<List<int>> input)
        {
            for(int i=0; i< input.Count-1; i++)
            {
                int sdj = 0;
                for(int j =1;  j<input[0].Count; j++)
                {
                    if (input[i][sdj] < input[i][j])
                    {
                        sdj = j;//it's storing the low in row and concidering that will be the max point
                    }
                }
                Boolean flag = true;
                for(int k=0;k<input.Count; k++)
                {
                    if (input[k][sdj] > input[i][sdj])//check is that the saddle point
                    {
                        flag = false;
                    }
                }
                if (true)
                {
                    Console.WriteLine($"Saddle point {input[i][sdj]}");
                }
            }
        }
    }
}
