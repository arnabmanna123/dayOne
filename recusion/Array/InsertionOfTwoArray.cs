using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class InsertionOfTwoArray
    {
        public static int[] Method(int[] inputOne , int[] inputTwo)
        {
            int i = 0, j = 0;
            List<int> newList = new List<int>();
            while (inputOne.Length > i && inputTwo.Length > j)
            {
                while (i + 1 < inputOne.Length && inputOne[i] == inputOne[i + 1])
                {
                    i++;
                }
                while (i + 1 < inputTwo.Length && inputTwo[j] == inputTwo[j + 1])
                {
                    j++;
                }
                if (inputOne[i] < inputTwo[j])
                {
                    
                    i++;
                }
                else if (inputOne[i] > inputTwo[j])
                {
                    
                    j++;
                }
                else
                {
                    newList.Add(inputOne[i]);
                    i++;
                    j++;
                }

            }
           
            return newList.ToArray();
        }

    }
}
