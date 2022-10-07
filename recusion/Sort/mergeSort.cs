using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class mergeSort
    {
       public static List<int> margeSort(List<int> input, int min, int max)
        {
            if (min == max)
            {
                return new List<int> { input[min] };
            }

            int mid = (min + max) / 2;

            var res1 = margeSort(input, min, mid);
            var res2 = margeSort(input, mid + 1, max);
            var finalRes = MargeSortedArray(res1, res2);
            return finalRes;
        }

       public static List<int> MargeSortedArray(List<int> inputOne , List<int> inputTwo)
        {
            int i = 0;
            int j = 0;

            List<int> finalResult = new List<int>();
            while(i<inputOne.Count && j<inputTwo.Count)
            {
                if (inputOne[i] < inputTwo[j])
                {
                    finalResult.Add(inputOne[i]);
                    i++;

                }
                else
                {
                    finalResult.Add(inputTwo[j]);
                    j++;
                }

            }
            while(i< inputOne.Count)
            {
                finalResult.Add(inputOne[i]);
                i++;
            }
            while (j < inputTwo.Count)
            {
                finalResult.Add(inputTwo[j]);
                j++;
            }
            return finalResult;
        }
    }


}
