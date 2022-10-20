using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public static class LargestAreaHistogram
    {
        public static int Solution(int[] input)
        {
            
            int[] rightBoundary = new int[input.Length];
            Stack<int> rst = new Stack<int>();
            rst.Push(input.Length - 1);//as the last index is this
            rightBoundary[input.Length - 1] = input.Length;//by default we are taking the length of the array(7 -(-1)+1) =7
            for(int i=input.Length-2; i >= 0; i--)
            {
                while(rst.Count>0 && input[i] < input[rst.Peek()])
                {
                    rst.Pop();
                }

                if (rst.Count == 0)
                {
                    rightBoundary[i] = input.Length;
                }
                else
                {
                    rightBoundary[i] = rst.Peek();
                }
                rst.Push(i);
            }

            int[] leftBoundary = new int[input.Length];
            Stack<int> lst = new Stack<int>();
            lst.Push(0);
            leftBoundary[0] = -1;//by default we are taking the length as -1  array(7 -(-1)+1) =7
            for (int i = 1; i< input.Length; i++)
            {
                while (lst.Count > 0 && input[i] < input[lst.Peek()])
                {
                    lst.Pop();
                }

                if ( lst.Count == 0)
                {
                    leftBoundary[i] = -1;
                }
                else
                {
                    leftBoundary[i] = lst.Peek();
                }
                lst.Push(i);
            }

            int maxwidth = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int dif =  rightBoundary[i]-leftBoundary[i]  - 1;
                int width = dif * input[i];
                maxwidth = Math.Max(width, maxwidth);
            }
            return maxwidth;
        }
    }
}
