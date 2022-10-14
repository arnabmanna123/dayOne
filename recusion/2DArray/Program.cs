using System;
using System.Collections.Generic;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultTwo = Rotate90Degree.Method(new List<List<int>> { new List<int> { 11, 12, 13, 14 }, new List<int> { 21, 22, 23, 24 }, new List<int> { 31, 32, 33, 34 } });
            var resultOne = Rotate90Degree.Method(new List<List<int>> { });
            ExitPointOfAMatrix.Method(new List<List<int>> { new List<int> {0,0,1,0 }, new List<int> {1,0,0,1 }, new List<int> {0,0,0,1 }, new List<int> { 1, 0, 1, 0 } });
            WaveTraversal.Method(new List<List<int>> { new List<int> { 11,12,13,14 }, new List<int> { 21, 22, 23, 24 }, new List<int> { 31, 32, 33, 34 } });
            var result = MatrixMultiplication.Multiplication(new List<List<int>> { new List<int> { 12, 23, 34 }, new List<int> { 33, 44, 55 } }, new List<List<int>> { new List<int> { 11, 12, 13, 14 }, new List<int> { 21, 22, 23, 24 }, new List<int> { 31, 32, 33, 34 } });
        }
    }
}
