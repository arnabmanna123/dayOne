using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StackQueue
{
    public static class StockSpan
    {

        public static int[] Solution(int[] input)
        {
            var stack = new Stack<int>();
            var output = new int[input.Length];
            for(int i=0; i< input.Length; i++)
            {
                while(stack.Count>0 && input[stack.Peek()] < input[i])
                {

                    stack.Pop();

                }
                if (stack.Count == 0)
                {
                    output[i] = i + 1;
                }
                else
                {
                    output[i] =i- stack.Peek() ;
                }

                stack.Push(i);
            }

            return output;
        }


        //public static List<int> Solution(List<int> input)
        //{
        //    var outPut = new int[input.Count];
        //    Stack<int> stack = new Stack<int>();
            
        //    for(int i=0; i< input.Count; i++)
        //    {
        //        if (stack.Count == 0)
        //        {
        //            outPut[i] = 1;
        //            stack.Push(outPut[i]);
        //        }
        //        else if(stack.Count>0 && input[i]>input[i-1])
        //        {
        //            int temp = input[i];
        //            int j = i-1;
        //            int count = 0;
        //            while (j>=0 && input[j]<temp)
        //            {
        //                count++;
        //                j--;
        //            }
        //            outPut[i] = count + 1;
        //            stack.Push(outPut[i]);
        //        }
        //        else if(stack.Count > 0 && input[i] < input[i - 1])
        //        {
        //            outPut[i] =  1;
        //            stack.Push(outPut[i]);
        //        }
        //    }

        //    return outPut.ToList();
        //}
    }
}
