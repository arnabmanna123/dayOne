using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class MissingNumber
    {
        public static int Method(List<int> number)
        {
            int len = number.Count + 1;

            int[] newArr = new int[len];

            for(int i = 0; i < number.Count; i++)
            {
                int val = number[i] - 1;

                newArr[val]++;
            }


            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == 0)
                {
                    return i + 1;
                }
            }
            return -1;
        }
    }
}
