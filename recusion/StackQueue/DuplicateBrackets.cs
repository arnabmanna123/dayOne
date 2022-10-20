using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackQueue
{
    public static class DuplicateBrackets
    {

        public static bool Method(string input)
        {
            Stack<char> stack = new Stack<char>();

            for(int i =0; i< input.Length; i++)
            {
                if (input[i] == ')')
                {
                    if (stack.Peek() == '(')
                    {
                        return true;
                    }
                    else
                    {
                        while(stack.Peek() != '(')
                        {
                            stack.Pop();
                        }
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(input[i]);
                }
            }
            return false;
        }
    }
}
