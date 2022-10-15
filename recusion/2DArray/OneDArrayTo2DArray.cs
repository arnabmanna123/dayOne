using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
   public static class OneDArrayTo2DArray
    {
        public static  int[,] Method(List<int> input,int row, int col)
        {
            if (input.Count != row * col)
                return new int[0,0];
            int[,] result = new int[row, col];

            for(int i=0; i< input.Count; i++)
            {
                int r = i / col;
                int c = i % col;
                result[r, c] = input[i];
            }

            return result;
        }

    }
}
