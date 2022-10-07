using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
   public class InsertionSort
    {
       public static List<int> InsertionSortMethod(List<int> input)
        {
            for(int i=1; i<input.Count; i++)
            {
                for(int j=i; j>=0; j--)
                {
                    if (j - 1 >= 0)
                    {
                        if (input[j] > input[j - 1])
                        {
                            int temp = input[j];
                            input[j] = input[j - 1];
                            input[j - 1] = temp;
                        }
                    }
                   
                }
            }
            return input;
        }
    }
}
