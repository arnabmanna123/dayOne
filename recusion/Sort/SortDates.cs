using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort
{
    public static class SortDates
    {

        public static List<string> SortDatesMethod(List<string> input)
        {
           input= CountSort(input, 1000000, 100, 32);//day
           input= CountSort(input, 10000, 100, 13);//month
           input= CountSort(input, 1, 10000, 2500);//year

            return input;
        }


        public static List<string> CountSort(List<string> input, int div, int mod, int range)
        {
            var rangeArray = new int[range];
            string[] result = new string[input.Count];
            for (int i = 0; i < input.Count; i++)
            {
                int day;
                int.TryParse(input[i], out day);
                day = day / div % mod;
                rangeArray[day] = rangeArray[day] + 1;
            }

            for(int i=1; i<rangeArray.Length; i++)
            {
                rangeArray[i] = rangeArray[i] + rangeArray[i - 1];
            }

            for(int i = input.Count-1; i>=0 ; i--)
            {
                int day;
                int.TryParse(input[i], out day);
                day = day / div % mod;
                result[rangeArray[day] - 1] = input[i];
                rangeArray[day]--;
            }

            return result.ToList();
        }


    }
}
