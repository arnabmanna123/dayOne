using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class SqureOfSortedArrayOfPosNeg
    {
        public static double[] Method(List<int> input)
        {
            int i = 0;
            int j = input.Count-1;
            double[] newArr = new double[input.Count];
            int k = input.Count - 1;
            while (i <= j)
            {
                var left = Math.Pow(input[i], 2);
                var right = Math.Pow(input[j], 2);

                if (left > right)
                {
                    newArr[k] = left;
                    i++;
                }
                else
                {
                    newArr[k] = right;
                    j--;
                }
                k--;
            }
            return newArr;
        }
    }
}
