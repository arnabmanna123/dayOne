using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class LeadersInArray
    {
        public static List<int> LeadersInArrayMethod(List<int> input)
        {
            int max = 0;
            List<int> newArray = new List<int>();

            for(int i=input.Count-1; i>=0; i--)
            {
                if (max < input[i])
                {
                    max = input[i];
                    newArray.Add(input[i]);

                }
            }
            return newArray;

        }
    }
}
