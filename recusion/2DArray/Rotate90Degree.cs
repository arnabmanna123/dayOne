using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class Rotate90Degree
    {
        public static List<List<int>> Method(List<List<int>> input)
        {
            //transpose
            for(int i=0; i<input.Count; i++)
            {
                for(int j=i; j< input[0].Count; j++)
                {
                    int temp = input[i][j];
                    input[i][j] = input[j][i];
                    input[j][i] = temp;
                }
            }

            //reverse
            for(int i=0; i< input.Count; i++)
            {
                int r1 = 0;
                int r2 = input[0].Count;

                while (r1 < r2)
                {
                    int temp = input[i][r1];
                    input[i][r1] = input[i][r2];
                    input[i][r2] = temp;
                }
            }

            return input; 
        }
    }
}

