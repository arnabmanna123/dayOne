using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace StackQueue
{
    public class Pair
    {
        public int st;
        public int et;
        public Pair(int x, int y)
        {
            st = x;
            et = y;
        }
    }
    public static class MergeOverlappingIntervals
    {
        public static void Solution(List<Pair> pairs)
        {
          pairs=  pairs.OrderBy(x => x.st).ThenBy(x => x.et).ToList();

            Stack<Pair> pairsStack = new Stack<Pair>();

            for (int i = 0; i < pairs.Count; i++)
            {
                if (pairsStack.Count == 0)
                {
                    pairsStack.Push(pairs[i]);
                }
                else
                {
                    var previous = pairsStack.Peek();
                    var current = pairs[i];

                    if (current.st < previous.et)
                    {
                        var stPush = current.st > previous.st ? previous.st : current.st;
                        var etPush = current.et < previous.et ? previous.et : current.et;

                        pairsStack.Pop();
                        pairsStack.Push(new Pair(stPush, etPush));
                    }
                    else
                    {
                        pairsStack.Push(pairs[i]);
                    }
                }

            }
        }
    }
}
