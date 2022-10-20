using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
  public static  class Stack
    {
        public static Stack<int> stack;

         static Stack()
        {
            stack = new Stack<int>();
        }

      public  static void Add(int value)
        {
            stack.Push(value);
        }

       public static int pop()
        {
           if( stack.Count != 0){
                int value = stack.Pop();
                return value;
            }
            else
            {
                return -1;
            }
        }
    }
}
