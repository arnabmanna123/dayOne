using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class SmallestNumberFollowingPattern
    {
        public static List<int> Solution(string input)
        {
            Stack<int> stack = new Stack<int>();
            List<int> result = new List<int>();

            int count = 1;
            for(int i=0; i < input.Length; i++)
            {
                stack.Push(count);
                count++;
                if (stack.Count>0 && input[i] == 'i')
                {
                    while (stack.Count > 0)
                    {
                        result.Add(stack.Peek());
                        stack.Pop();
                    }
                }
 
            }
            stack.Push(count);

            while (stack.Count > 0)
            {
                result.Add(stack.Peek());
                stack.Pop();
            }

            return result;
        }
    }
}
