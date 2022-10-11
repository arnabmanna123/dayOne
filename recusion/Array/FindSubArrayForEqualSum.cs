
using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class FindSubArrayForEqualSum
    {
        public static void FindSubArray(List<int> input,int target)
        {
            FindSubArray(input, 0, "", 0, target);
        }
        public static void FindSubArray(List<int> input, int index, string set, int sumSOFar, int target)
        {
            if (index == input.Count)
            {
                if (sumSOFar == target)
                {
                    Console.WriteLine(set + ".");
                }
                return;
            }
            FindSubArray(input, index + 1, set + " , " + input[index].ToString(), sumSOFar + input[index], target);
            FindSubArray(input, index + 1, set, sumSOFar, target);

        }



        public static void findSubArrayPositiveNumbers(int[] arr, int sum)
        {
            if (arr.Length == 0)
            {
               Console.WriteLine("Array is empty");
                return;
            }

            int start, end, window_Sum;
            start = end = 0;
            window_Sum = 0;

            while (end < arr.Length)
            {
                window_Sum = window_Sum + arr[end];

                if (window_Sum == sum)
                {
                   Console.WriteLine("Start Index: " + start.ToString() + ", End Index: " + end.ToString());
                    return;
                }

                while (window_Sum > sum && start <= end)
                {
                    window_Sum = window_Sum - arr[start++];

                    if (window_Sum == sum)
                    {
                       Console.WriteLine("Start Index: " + start.ToString() + ", End Index: " + end.ToString());
                        return;
                    }
                }

                end++;
            }

           Console.WriteLine("There is no such sub-array");
        }

        public static void findSubArrayNeg(int[] arr, int sum)
        {
            if (arr.Length == 0)
            {
               Console.WriteLine("Array is empty");
                return;
            }

            int end, totalSumTillNow;
            end = 0;
            totalSumTillNow = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();

            while (end < arr.Length)
            {
                totalSumTillNow = totalSumTillNow + arr[end];

                if (totalSumTillNow == sum)
                {
                   Console.WriteLine("Start Index: " + 0 + ", End Index: " + end);
                    return;
                }

                int windowSum = totalSumTillNow - sum;

                if (map.ContainsKey(windowSum))
                {
                    int start = map[windowSum];
                   Console.WriteLine("Start Index: " + (start + 1) + ", End Index: " + end);
                    return;
                }


                map[totalSumTillNow] = end++;
            }
        }
    }
}
