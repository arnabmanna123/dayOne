using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public static class ShellSort
    {
        public static List<int> ShellSortMethod(List<int> input)
        {
            int gap = input.Count / 2;
            while (gap >= 1)
            {
                GapCompare(input, gap);
                gap = gap / 2;
            }
            return input;
        }

        public static void GapCompare(List<int> input, int gap)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if(i+gap < input.Count)
                {
                    int gapInd = i + gap;
                    if (input[i] > input[gapInd])
                    {
                        int temp = input[i];
                        input[i] = input[gapInd];
                        input[gapInd] = temp;

                        int BackGapInd = i - gap;
                        if (BackGapInd > -1)
                        {
                            if (input[i] < input[BackGapInd])
                            {
                                int temp1 = input[i];
                                input[i] = input[BackGapInd];
                                input[BackGapInd] = temp1;
                            }
                        }
                    }

                  
                }
            }
        }
    }
}
