using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class EquilibriumPoint
    {
        public static int equilibriumPointMethod(int[] arr, int N)
        {
            int valueSoFar = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sum -= arr[i];

                if (sum == valueSoFar)
                {
                    return i;
                }
                valueSoFar += arr[i];
            }
            return -1;
        }
    }
}
