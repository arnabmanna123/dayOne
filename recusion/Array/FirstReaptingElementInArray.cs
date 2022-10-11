using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
   public static class FirstReaptingElementInArray
    {
        public static int Method(List<int> input)
        {
            HashSet<int> set = new HashSet<int>();
            int min = int.MaxValue;


            for(int i=0; i< input.Count; i++)
            {
                if (set.Contains(input[i]))
                {
                    min = input[i];
                }
                else
                {
                    set.Add(input[i]);
                }
            }
            return min;

        }

        public static int MethodTwo(List<int> input)
        {
            int max = int.MinValue;

            for(int i=0;i<input.Count; i++)
            {
                if (max < input[i])
                {
                    max = input[i];
                }
            }

            int[] countArr = new int[max];
            int min = int.MinValue;
            for (int i =input.Count-1; i>=0; i--)
            {
                int val = input[i]-1;
                countArr[val] += 1;
                if (countArr[val] > 1)
                {
                    min = input[i];
                }
            }
            return min;
        }
    }
}
