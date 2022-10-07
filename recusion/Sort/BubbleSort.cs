using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
   public class BubbleSort
    {
        public static List<int> BubbleSortMethod(List<int> input)
        {
            for(int i=0; i< input.Count; i++)
            {
                for(int j =0; j < input.Count; j++)
                {
                    if (j + 1 != input.Count)
                    {
                        if(input[j]> input[j + 1])
                        {
                            var temp = input[j];
                            input[j] = input[j + 1];
                            input[j+1] = temp;
                        }
                    }
                }
            }
            return input;
        }
    }
}
