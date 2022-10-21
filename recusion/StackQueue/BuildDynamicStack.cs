using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    class BuildDynamicStack
    {
        static int[] stack = new int[3];
        static int tos = -1;

        public static void Push(int item)
        {
            if (tos == stack.Length - 1)
            {
                var newStack = new int[stack.Length * 2];
                for(int i=0; i < stack.Length; i++)
                {
                    newStack[i] = stack[i];
                }
                stack = newStack;
                tos++;
                stack[tos] = item;
            }
            else
            {
                tos++;
                stack[tos] = item;
            }
        }

        public static void Display()
        {
            for (int i = tos; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }

        public static void Pop()
        {
            if (tos <= -1)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                tos = tos - 1;
            }
        }

        public static int Count()
        {
            return tos + 1;
        }

        public static int Peek()
        {
            if (tos == -1)
            {
                throw new NullReferenceException("empty");
            }
            else
            {
                return stack[tos];
            }
        }
    }
}
