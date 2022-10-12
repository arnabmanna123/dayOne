using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class QuadrupleForGivenSum
    {
        public static void Method(List<int> input, int target)
        {
            input.Sort();
            for(int i = 0; i < input.Count - 3; i++)
            {
                for(int j = i+1; j < input.Count - 2; j++)
                {
                    int required = target-( input[i] + input[j]);

                    int k = j+1;
                    int l = input.Count-1;

                    while (k < l)
                    {
                        if(input[k]+ input[l] > required)
                        {
                            l--;
                        }
                        else if(input[k] + input[l] < required)
                        {
                            k++;
                        }
                        else
                        {
                            Console.WriteLine($"{input[i]},{input[j]},{input[k]},{input[l]}");
                            l--;
                            k++;
                        }
                    }

                }
            }
        }
    }
}
