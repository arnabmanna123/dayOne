using System;

namespace BacTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            LexicographicalOrder.Method(11);
            int alive = GameofExecutionJosephusProblem.Method(5, 3);
            MaximumScoreOfWordsProblem.Method(new string[] { "dog", "cat", "dad", "good" }, new char[] { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' }, new int[] { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            BranchAndBoundAlgorithm.Method(new bool[4, 4]);
            PrintAbbreviations.Method("pep", "", 0,0);
            Console.ReadLine();
        }
    }
}
