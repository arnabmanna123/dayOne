using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class SlidingWindowMaximum
    {
        public static List<int> Solution(int[] input, int k)
        {
            Stack<int> stack = new Stack<int>();
            var output = new int[input.Length];
            var final = new List<int>();
            output[0] =0;
            stack.Push(0);
            for(int i=1; i< input.Length; i++)
            {
                while (stack.Count > 0 && input[i] > input[stack.Peek()])
                {
                    output[stack.Peek()] = i;
                    stack.Pop();
                }
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                output[stack.Peek()] = input.Length;//we are taking as length of array
                stack.Pop();
            }


            for(int i = 0; i <= input.Length-k; i++)
            {
                int start = i;
                int last = i + k;

                
                while (output[start] < last)
                {
                    start = output[start];
                }

                final.Add(input[start]);

            }
            return final;
        }
    }
}
