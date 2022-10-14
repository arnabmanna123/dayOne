using System;
using System.Collections.Generic;
using System.Text;

namespace _2DArray
{
    public static class NQueeenProblem
    {
 



        public static void printNQueens(int[,] chess, String qsf, int row)
        {
            if (row == chess.GetLength(0))
            {
                Console.WriteLine(qsf + ".");
                return;
            }
            for (int col = 0; col < chess.GetLength(1); col++)
            {
                if (chess[row,col] == 0
                    && isQueenSafe(chess, row, col) == true)
                {
                    chess[row,col] = 1;
                    printNQueens(chess,
                                 qsf + row + "-" + col + ", ", row + 1);
                    chess[row,col] = 0;
                }
            }
        }

        public static bool isQueenSafe(int[,] chess,
                                          int row, int col)
        {
            for (int i = row - 1, j = col - 1;
                 i >= 0 && j >= 0; i--, j--)//left diagonal
            {
                if (chess[i,j] == 1)
                {
                    return false;
                }
            }

            for (int i = row - 1, j = col; i >= 0; i--)//virtical
            {
                if (chess[i, j] == 1)
                {
                    return false;
                }
            }

            for (int i = row - 1, j = col + 1; i >= 0
                 && j < chess.GetLength(1); i--, j++)//right diagonal
            {
                if (chess[i, j] == 1)
                {
                    return false;
                }
            }

            for (int i = row, j = col - 1; j >= 0; j--)//horizontal
            {
                if (chess[i, j] == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
