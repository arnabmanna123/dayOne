using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class BalancedBrackets
    {
        public static bool Solution(string input)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ')')
                {

                   if(! SmallMethod(stack, '(')) return false;

                }
                else if (input[i] == '}')
                {
                    if (!SmallMethod(stack, '{')) return false;

                }
                else if (input[i] == ']')
                {
                    if (!SmallMethod(stack, '{')) return false;

                }
                else
                {
                    stack.Push(input[i]);
                }
            }
            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }

        public static bool SmallMethod(Stack<char> stack ,char ch )
        {
            while (stack.Count > 0 && stack.Peek() != ch)
            {

                stack.Pop();
            }
            if (stack.Count <= 0)
            {
                return false;
            }
            stack.Pop();
            return true;
        }
    }
}
