using System;
using System.Collections.Generic;
using System.Text;

namespace BacTracking
{
    public static class LexicographicalOrder
    {
        public static  void  Method(int k)
        {
            for(int i=1; i <= 9; i++)
            {
                Dfs(i, k);
            }
        }

        public static void Dfs(int i, int k)
        {
            if (i > k)
            {
                return;
            }
            Console.WriteLine(i);
            for(int j=0; j<=9; j++)
            {
                Dfs(i * 10 + j, k);
            }
        }
    }
}
