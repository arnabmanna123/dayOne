using System;
using System.Collections.Generic;
using System.Text;

namespace BacTracking
{
   public static class GameofExecutionJosephusProblem
    {
        public static int Method(int n , int k)
        {
            if (n == 1)
            {
                return 0;//when one is elive then then we stat from 0,1,2,3 ==> for 1 then it will be 0
            }
            int x = Method(n - 1, k);

            int y = (x + k) % n;
            return y;//if condition theke 0 then y e seta 1 => 1=> 0=> 3 hobe
        }

      
    }
}
