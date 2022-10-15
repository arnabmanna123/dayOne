using System;
using System.Collections.Generic;
using System.Text;

namespace BacTracking
{
   public static class MaximumScoreOfWordsProblem
    {
        public static int Method(string[] words, char[] letters, int[] score)
        {
            int[] frequency = new int[26];
            for(int i=0;i<letters.Length; i++)
            {
                char ch = letters[i];
                frequency[ch - 'a']++;
            }

            int result = Solution(words, frequency, score, 0);
            return result;
        }
        public static int Solution(string[] words,int[] freq, int[] score, int idx)
        {
            if (idx == words.Length)
            {
                return 0;
            }
           int NoScore=0+ Solution(words, freq, score, idx + 1);//not encluded


            //included 
            int SWordScore = 0;
            string word = words[idx];
            int[] map1 = new int[26];
            bool canTake = true;
            int YesScore = 0;
            for (int i = 0; i < word.Length; i++)//checking is it ok to take or not
            {
                char ch = word[i];
                map1[ch - 'a']++;
                if (map1[ch - 'a'] > freq[ch - 'a'])
                {
                    canTake = false;
                    break;
                }
            }
            if (canTake)//taking
            {
                for (int i = 0; i < word.Length; i++)
                {
                    char ch = word[i];


                    freq[ch - 'a']--;
                    SWordScore += score[ch - 'a'];
                }


                 YesScore = SWordScore + Solution(words, freq, score, idx + 1); //included


                for (int i = 0; i < word.Length; i++)
                {
                    char ch = word[i];
                    freq[ch - 'a']++;
                }
            }
            

            return Math.Max(YesScore, NoScore);

            }
    }
}
