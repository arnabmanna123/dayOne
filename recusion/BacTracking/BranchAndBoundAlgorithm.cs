using System;
using System.Collections.Generic;
using System.Text;

namespace BacTracking
{
    public static class BranchAndBoundAlgorithm
    {
        public static void Method(bool[,] input)
        {
            int diagonalLength = 2 * input.GetLength(0) - 1;
            bool[] c= new bool[input.GetLength(0)];
            bool[] nd = new bool[diagonalLength];
            bool[] rd = new bool[diagonalLength];

            NQueen(input,0, c, nd, rd, "");
        }

        public static void NQueen(bool[,] input ,int row, bool[] c , bool[] nd , bool[] rd,string result)
        {
            if (row == input.GetLength(0))
            {
                Console.WriteLine(result);
            }
            for(int col=0; col<input.GetLength(1); col++)
            {
                if (c[col] == false && nd[row+col]==false && rd[(row-col)+ (input.GetLength(0)-1)]==false)//most important line
                {
                    input[row, col] = true;
                    c[col] = true;
                    nd[row + col] = true;
                    rd[(row - col) + (input.GetLength(0) - 1)] = true;
                    NQueen(input, row + 1, c, nd, rd, result + "(" + row.ToString() + ","  + col.ToString() + "),");

                    input[row, col] = false;
                    c[col] = false;
                    nd[row + col] = false;
                    rd[(row - col) + (input.GetLength(0) - 1)] = false;
                }
            }
        }
    }
}
