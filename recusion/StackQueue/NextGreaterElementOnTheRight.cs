using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackQueue
{
    public static class NextGreaterElementOnTheRight
    {
        public static List<int> RightToLeft(List<int> input)
        {
            Stack<int> stack = new Stack<int>();
            int[] inputTwo = new int[input.Count];
            for (int i = input.Count - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() < input[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                {
                    inputTwo[i] = -1;
                }
                else if (stack.Peek() > input[i]) {
                    inputTwo[i] = stack.Peek();

                }
                else if (stack.Peek() < input[i])
                {


                    inputTwo[i] = stack.Peek();



                }
                stack.Push(input[i]);


            }
            return inputTwo.ToList();

        }

        public static List<int> LeftToRight(List<int> input)
        {
            Stack<int> stack = new Stack<int>();
            var output = new int[input.Count];
            stack.Push(0);
            for(int i=1;i<input.Count; i++)
            {
                while(stack.Count>0 && input[i]>input[stack.Peek()])
                {
                    output[stack.Peek()] = input[i];
                    stack.Pop();
                }
                stack.Push(i);
            }

            while (stack.Count > 0)
            {
                int pos = stack.Peek();
                output[pos] = -1;
                stack.Pop();
            }
            return output.ToList();
        }
    }
}
