using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class MultiplicationPairMatch
    {
        public static void FindPair(List<int> number , int value) //for only positive number
        {
            number.Sort();

            int i = 0, j = number.Count - 1;
            while (i <= j)
            {
                if (number[i] * number[j]>value)
                {
                    j--;
                }
                else if(number[i] * number[j] < value)
                {
                    i++;
                }
                else
                {
                    Console.WriteLine($"{number[i]} {number[j]}");
                    i++;
                    j--;
                }
            }
        }


        public static bool FindPairBothPosNeg(List<int> number, int value)
        {
            HashSet<int> TempSet = new HashSet<int>();

            for(int i=0; i< number.Count; i++)
            {
                if(value%number[i]==0 && TempSet.Contains(value/ number[i]))
                {
                    return true;
                }
                else
                {
                    TempSet.Add(number[i]);
                }
            }
            return false;
        }
    }
}
