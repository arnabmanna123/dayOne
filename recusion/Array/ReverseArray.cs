using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
   public static class ReverseArray
    {

        public static List<string> ReverseArrayMethod(List<string> input , int rotate)
        {

            string[] array = new string[input.Count];
            rotate = rotate % input.Count;
            if (rotate < 0)
            {
                rotate = rotate + input.Count;
            }
            for (int i = 0; i < input.Count; i++)
            {

                    int ind = (i + rotate) % input.Count;
                    array[ind] = input[i];

            }

            return array.ToList();
        }
    }
}
