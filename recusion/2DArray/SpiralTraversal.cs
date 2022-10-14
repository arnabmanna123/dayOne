using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
   public static class SpiralTraversal
    {
        public static void Methd(List<List<int>> input)
        {
            int minRow = 0;
            int minCol = 0;
            int maxRow = input.Count-1;
            int maxCol = input[0].Count - 1;
            int total = input.Count * input[0].Count;
            int count = 0;
            while (true)
            {
                //lw
                for(int i=minRow,j=minCol; i <= maxRow; i++)
                {
                    Console.WriteLine(input[i][j]);
                    count++;
                }
                minCol++;
                //br

                for (int i = maxRow, j = minCol; j<=maxCol;j++)
                {
                    Console.WriteLine(input[i][j]);
                    count++;

                }
                maxRow--;
                //rw

                for (int i= maxRow,j=maxCol; i >= minRow; i--)
                {
                    Console.WriteLine(input[i][j]);
                    count++;

                }
                maxCol--;

                //tw
                for (int i = minRow, j = maxCol; j >= minCol; j--)
                {
                    Console.WriteLine(input[i][j]);
                    count++;

                }
                minRow++;

                if (count > total)
                {
                    break;
                }
               
               
            }
        }
    }
}
