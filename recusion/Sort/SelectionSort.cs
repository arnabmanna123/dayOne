using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class SelectionSort
    {
        public static List<int> SelectionSortMethod(List<int> input)
        {
            for(int i=0; i<input.Count; i++)
            {
                for(int j = i; j<input.Count; j++)
                {
                    if (input[i] > input[j])
                    {
                        var temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
    }
}
