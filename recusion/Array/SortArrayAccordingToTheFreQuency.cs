using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    public static class SortArrayAccordingToTheFreQuency
    {
        public static List<int> Method(List<int> input)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for(int i=0; i<input.Count; i++)
            {
                int val = input[i];
                if (!frequency.ContainsKey(input[i]))
                {
                    frequency.Add(input[i], 1);
                }
                else
                {
                    frequency[val] += 1;

                }
            }
            List<int> value = new List<int>();
            var result =frequency.OrderByDescending(key => key.Value).ThenBy(x=>x.Key);
            foreach(var res in result)
            {
                int j = 0;
                var val = res.Value;
                while (j < val)
                {
                    value.Add(res.Key);
                    j++;
                }
            }
             return value;
        }
    }
}
