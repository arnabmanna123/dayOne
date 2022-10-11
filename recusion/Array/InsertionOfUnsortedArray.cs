using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class InsertionOfUnsortedArray
    {
        
        public static int[] Insertion(int[] arrayOne , int[] arrayTwo)
        {
            int k = 0;
            HashSet<int> temp = new HashSet<int>();
            HashSet<int> final = new HashSet<int>();
            int[] finalArr = new int[arrayOne.Length + arrayTwo.Length];
            for(int i=0;i<arrayOne.Length; i++)
            {
                if (!temp.Contains(arrayOne[i]))
                {
                    temp.Add(arrayOne[i]);
                }
            }
            for(int i=0;i<arrayTwo.Length; i++)
            {
                if (!temp.Contains(arrayTwo[i]))
                {
                    if (!final.Contains(arrayTwo[i])){
                        final.Add(arrayOne[i]);
                        finalArr[k] = arrayOne[i];
                        k++;
                    }
                }
            }
            return finalArr;
        }
    }
}
