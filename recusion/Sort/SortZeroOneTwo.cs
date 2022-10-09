using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public static class SortZeroOneTwo
    {
        public static List<int> SortZeroOneTwoMethod(List<int> input)
        {
            int i = 0;
            int j = 0;
            int k = input.Count - 1;
            while (i <=k)//this condition is important
            {
                if (input[i] == 2)
                {
                    int temp = input[i];
                    input[i] = input[k];
                    input[k] = temp;

                    k--; // we swap and decrese because we know we are switching 2 but dont know the the number was in k's place it could be anything 0/1/2
                }
                else if (input[i] == 0)
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                    j++;
                }
                else
                {
                    i++;
                }

               
            }

            return input;
        }
    }
}
