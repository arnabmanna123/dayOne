using System;
using System.Collections.Generic;

namespace StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildNormalQueue.Push(23);
            BuildNormalQueue.Push(2);
            BuildNormalQueue.Push(43);
            BuildNormalQueue.Push(20);
            BuildNormalQueue.Push(73);
            BuildNormalQueue.Push(21);
            BuildNormalQueue.Display();
            BuildNormalQueue.Pop();
            BuildNormalQueue.Display();
            BuildNormalQueue.Peek();

            BuildNormalQueue.Pop();
            BuildNormalQueue.Display();
            BuildNormalQueue.Peek();

            BuildNormalQueue.Pop();
            BuildNormalQueue.Display();
            BuildNormalQueue.Peek();

            BuildNormalQueue.Pop();
            BuildNormalQueue.Display();
            BuildNormalQueue.Peek();

            BuildNormalQueue.Pop();
            BuildNormalQueue.Display();
            BuildNormalQueue.Peek();


            PostfixExpressionsEvalution.Solution("264*8/+3-");

            BuildDynamicStack.Push(2);
            BuildDynamicStack.Push(2);
            BuildDynamicStack.Push(2);
            BuildDynamicStack.Push(2);
            BuildDynamicStack.Push(2);
            BuildDynamicStack.Push(2);
            BuildDynamicStack.Push(2);
            BuildDynamicStack.Display();

            var val1 = BuildNormalStack.Count();
            BuildNormalStack.Push(23);
            BuildNormalStack.Push(2);
            BuildNormalStack.Push(43);
            BuildNormalStack.Push(20);
            BuildNormalStack.Push(73);
            BuildNormalStack.Push(21);
            BuildNormalStack.Display();
            BuildNormalStack.Pop();
          var val22=  BuildNormalStack.Peek();
            var resultThreet = SmallestNumberFollowingPattern.Solution("iididdid");
            MergeOverlappingIntervals.Solution(new List<Pair> { new Pair(1, 8), new Pair(22, 28), new Pair(25, 27), new Pair(14, 19), new Pair(5, 12) });
            PostfixExpressionsEvalution.Solution("264*8/+3-");
            CelebrityProblem.Solution(new List<List<int>> { new List<int> { 0, 1, 1, 1, 1 }, new List<int> { 1, 0, 0, 1, 0 }, new List<int> { 1, 0, 0, 1, 0 }, new List<int> { 0, 0, 0, 0, 0 } , new List<int> { 0, 1, 0, 1, 0 }});
            InfixConversions.Solution("a*(b-c)/d+e");
            int valueInfix = InfixEvelution.Solution("1+2*(5*8/3)");
            var slidingWindow = SlidingWindowMaximum.Solution(new int[] { 2, 9, 3, 8, 1, 7, 12, 6, 14, 4, 32, 0, 7, 19, 8, 12, 6 }, 4);
            var histogram = LargestAreaHistogram.Solution(new int[] { 6, 2, 5, 4, 5, 1, 6 });
            var stock = StockSpan.Solution(new int[] { 2, 3, 7, 4, 6, 2, 4,5, 10, 7, 5, 6, 8, 9, 3 });
            var resultThree = NextGreaterElementOnTheRight.LeftToRight(new List<int> { 2, 5, 9, 3, 1, 12, 6, 8, 7 });

            var resultTwo = NextGreaterElementOnTheRight.RightToLeft(new List<int> { 2, 5, 9, 3, 1, 12, 6, 8, 7 });
            var reslutOne = BalancedBrackets.Solution("((a+b)+{(c+d)*(e/f)})");
           var result = DuplicateBrackets.Method("((a+b)+((c+d)))");
            bool a = true;
            while (a)
            {

                Console.WriteLine("1 for add  2 for remove 3 end");

                switch (Convert.ToInt32( Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("give value");
                        int value =Convert.ToInt32( Console.ReadLine());
                        Stack.Add(value);
                        break;
                    case 2:
                        Console.WriteLine(Stack.pop());
                        Console.WriteLine(Stack.stack.Peek());
                        break;
                    case 3:
                        a = false;
                        break;
                        
                }
            }
        }
    }
}
