using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class CelebrityProblem
    {
        public static int Solution(List<List<int>> input)
        {
            Stack<int> stack = new Stack<int>();
            int i = 0;
            while (i < input.Count)
            {
                stack.Push(i);
                i++;
            }

            while (stack.Count> 1)
            {
                int v2 = stack.Pop();
                int v1 = stack.Pop();
                if (input[v1][v2] == 0)
                {
                    stack.Push(v1);
                }
                else
                {
                    stack.Push(v2);

                }
            }

            if (stack.Count == 1)
            {
                int k = stack.Peek();
                int j = 0;
                while (j < input.Count)
                {
 
                    if((j == k && input[k][j] == 0) || (  input[k][j]==0 && input[j][k] == 1))
                    {
                        
                    }
                    else
                    {
                        return -1;
                    }
                    j++;
                }

            }
            return stack.Peek();

        }
    }
}
