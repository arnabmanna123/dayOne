using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class ShellRotation
    {
        public static List<List<int>> Method(List<List<int>> input, int shell, int rotate)
        {
            int[]  oned = FillOnedFromShell(input, shell);

           oned=  Rotate(oned, rotate);

            FillShellFromOned(input, shell, oned);
            return input;
        }

        public static int[] FillOnedFromShell(List<List<int>>  input,int shell)
        {
            int minRow = shell - 1;
            int minCol = shell - 1;
            int maxRow = input.Count - 1 - minRow;
            int maxCol = input[0].Count - 1 - minCol;
            int length = maxRow * maxCol;
            int size = 2 * (maxRow - minRow +maxCol - minCol );
            int[] newArr = new int[size];
            int idx=0;
            //lw
            for (int i = minRow, j = minCol; i <= maxRow; i++)
            {
                newArr[idx] = input[i][j];
                idx++;
            }
           minCol++;
            //bw
            for (int i = maxCol, j = minCol; j <= maxCol; j++)
            {
                newArr[idx] = input[i][j];
                idx++;
            }
            maxRow--;
            //rw
            for(int i = maxRow, j = maxCol; i >= minRow; i--)
            {
                newArr[idx] = input[i][j];
                idx++;
            }
            //tw
            maxCol--;
            for (int i = minRow, j = maxCol; j >= minCol; j--)
            {
                newArr[idx] = input[i][j];
                idx++;
            }
            return newArr;
        }



        public static void FillShellFromOned(List<List<int>> input, int shell,int[] newArr)
        {
            int minRow = shell - 1;
            int minCol = shell - 1;
            int maxRow = input.Count - 1 - minRow;
            int maxCol = input[0].Count - 1 - minCol;
            int length = maxRow * maxCol;

            int idx = 0;
            //lw
            for (int i = minRow, j = minCol; i <= maxRow; i++)
            {
                input[i][j] = newArr[idx] ;
                idx++;
            }
            minCol++;
            //bw
            for (int i = maxCol, j = minCol; j <= maxCol; j++)
            {
                input[i][j] = newArr[idx];
                idx++;
            }
            maxRow--;
            //rw
            for (int i = maxRow, j = maxCol; i >= minRow; i--)
            {
                input[i][j] = newArr[idx];
                idx++;
            }
            //tw
            maxCol--;
            for (int i = maxRow, j = maxCol; j >= minCol; j--)
            {
                input[i][j] = newArr[idx];
                idx++;
            }

        }
        static int[] Rotate(int[] input,int rotate)
        {
            int[] Result = new int[input.Length];
            rotate = rotate % input.Length;
            rotate = rotate < 0 ? rotate + input.Length : rotate;
            for (int i=0; i< input.Length; i++)
            {
                Result[(i + rotate) % input.Length] = input[i];
            }
            return Result;
        }
    }
}
