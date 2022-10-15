using System;
using System.Collections.Generic;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultThree = OneDArrayTo2DArray.Method(new List<int> { 1, 2, 3, 4, 5, 6,7,8 }, 4,2);
            NQueeenProblem.printNQueens(new int[4,4],"", 0);
          BinarySearch.Method(new List<List<int>> { new List<int> { 00, 01, 02, 03, 04 }, new List<int> { 10, 11, 12, 13, 14 }, new List<int> { 20, 21, 22, 23, 24 }, new List<int> { 30, 31, 32, 33, 34 }, new List<int> { 40, 41, 42, 43, 44 } }, 45);
            SaddlePoint.Method(new List<List<int>> { new List<int> { 00, 01, 02, 03, 04 }, new List<int> { 10, 11, 12, 13, 14 }, new List<int> { 20, 21, 22, 23, 24 }, new List<int> { 30, 31, 32, 33, 34 }, new List<int> { 40, 41, 42, 43, 44 } });
             DiagonalTraversal.Method(new List<List<int>> { new List<int> { 00, 01, 02, 03, 04 }, new List<int> { 10, 11, 12, 13, 14 }, new List<int> { 20, 21, 22, 23, 24 }, new List<int> { 30, 31, 32, 33, 34 }, new List<int> { 40, 41, 42, 43, 44 } });
            var resultthree = ShellRotation.Method(new List<List<int>> { new List<int> {11,12,13,14,15,16 }, new List<int> {21,22,23,24,25,26 }, new List<int> {31,32,33,34,35,36 }, new List<int> {41,42,43,44,45,46 }, new List<int> {51,52,53,54,55,56 }, new List<int> {61,62,63,64,65,66 } },2,1);
            var resultTwo = Rotate90Degree.Method(new List<List<int>> { new List<int> { 11, 12, 13, 14 }, new List<int> { 21, 22, 23, 24 }, new List<int> { 31, 32, 33, 34 } });
            var resultOne = Rotate90Degree.Method(new List<List<int>> { });
            ExitPointOfAMatrix.Method(new List<List<int>> { new List<int> {0,0,1,0 }, new List<int> {1,0,0,1 }, new List<int> {0,0,0,1 }, new List<int> { 1, 0, 1, 0 } });
            WaveTraversal.Method(new List<List<int>> { new List<int> { 11,12,13,14 }, new List<int> { 21, 22, 23, 24 }, new List<int> { 31, 32, 33, 34 } });
            var result = MatrixMultiplication.Multiplication(new List<List<int>> { new List<int> { 12, 23, 34 }, new List<int> { 33, 44, 55 } }, new List<List<int>> { new List<int> { 11, 12, 13, 14 }, new List<int> { 21, 22, 23, 24 }, new List<int> { 31, 32, 33, 34 } });
        }
    }
}
