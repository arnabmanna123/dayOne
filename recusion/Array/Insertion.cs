using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    public static class Insertion
    {

        public static int[] insertionMethod(int[] input, int position,int value)
        {
            int[] newArray = new int[input.Length + 1];
            position= position-1<0?0: position - 1;
            for(int i=0; i<newArray.Length; i++)
            {
                if (position > i && i< input.Length)
                {
                    newArray[i] = input[i];
                }
                else if (position == i)
                {
                    newArray[i] = value;
                }
                else
                {
                    newArray[i] = input[i - 1];
                }
            }
            return newArray;
        }
    }
}
