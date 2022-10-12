using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class LongestSubArrayWithReplaceKZero
    {
        public static int Length(List<int> input, int k)
        {
            int longest = int.MinValue;
            int i = 0;
            int count = 0;
            int length = 0;
            Queue<int> pipe = new Queue<int>();
            while (i < input.Count)
            {
               
                if(input[i] == 0)
                {
                    pipe.Enqueue(i);
                    count++;
                }

                if (count > k)
                {
                    var check = pipe.Dequeue();
                    length = length - check;

                    count--;
                }
                longest = Math.Max(longest, length);

                length++;
                i++;
                
            }
            return longest;
        }
    }
}
