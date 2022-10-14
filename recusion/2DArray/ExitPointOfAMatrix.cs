using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class ExitPointOfAMatrix
    {
        public static void Method(List<List<int>> input)
        {
            int minRow = 0;
            int maxRow = input.Count;
            int minCol = 0;
            int maxCol = input[0].Count;
            int direction = 0;
            while (true)
            {
                if (input[minRow][minCol] == 1)
                {
                    direction = (direction + 1) % 4;
                }

                switch (direction)
                {
                    case 0:
                        minCol++;
                        break;
                    case 1:
                        minRow++;
                        break;
                    case 2:
                        minCol--;
                        break;
                    case 3:
                        minRow--;
                        break;
                }

                if(minRow>= input.Count || minCol >= input[0].Count|| minRow<0 || minCol<0)
                {
                    minRow = minRow < 0 ? 0 : minRow;
                    minRow = minRow >= input.Count ? minRow - 1 : minRow;
                    minCol = minCol < 0 ? 0 : minCol;
                    minCol = minCol >= input[0].Count ? minCol - 1 : minCol;
                    minCol = minCol >= input[0].Count ? minCol - 1 : minCol;
                    Console.WriteLine($"Exit : {minRow} {minCol}");
                    break;
                }
                else
                {
                    
                }
            }
        }
    }
}
