using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _2DArray
{
    public static class MatrixMultiplication
    {
        public static int[,] Multiplication(List<List<int>> inputOne, List<List<int>> inputTwo)
        {
            if (inputOne[0].Count != inputTwo.Count)
            {
                throw new ArgumentException("The input is the not correct");
            }

            int[,] result = new int[inputOne.Count, inputTwo[0].Count];

            for (int i = 0; i < result.GetLength(0); i++)//for row length
            {
                for (int j = 0; j < result.GetLength(1); j++)//for column length
                {
             
                    for(int k=0;k< inputOne[0].Count; k++)
                    {
                        result[i, j] += (inputOne[i][k] * inputTwo[k][j]);
                    }
                 

                }
            }

            return result;

        }
    }
}
