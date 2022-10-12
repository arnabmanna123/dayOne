using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class ShuffleTheArrayNumber
    {
        public static List<int> Method(List<int> input)
        {
            Random random = new Random();
            

            int i = 0;
            while (i < input.Count)
            {
                int number =random.Next(0, input.Count - 1);
                int temp = input[i];
                input[i] = input[number];
                input[number] = temp;
                i++;
            }

            return input;
        }
    }
}
