using System;
using System.Collections.Generic;
using System.Text;

namespace BacTracking
{
    public static class PrintAbbreviations
    {
        public static void Method(string input, string outPut, int index,int sum)
        {
            if (index == input.Length)
            {
                if (sum == 0)
                {
                    Console.WriteLine(outPut);

                }
                else
                {
                    Console.WriteLine(outPut + sum.ToString());
                }
                return;
            }

            if (sum == 0)
            {
                Method(input, outPut +  input[index].ToString(), index + 1, 0);

            }
            else
            {
                Method(input, outPut + Convert.ToString(sum) + input[index].ToString(), index + 1, 0);


            }
            Method(input, outPut, index + 1, sum + 1); ;


        }
    }
}
