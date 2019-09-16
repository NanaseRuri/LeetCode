using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters_003
    {
        public int LengthOfLongestSubstring(string s)
        {
            int[] record = new int[128];
            int left = 0;
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                left = Math.Max(left, record[s[i]]);
                max = Math.Max(max, i - left + 1);
                record[s[i]] = i + 1;
            }
            return max;
        }

        public void Test()
        {
            Console.WriteLine(LengthOfLongestSubstring("abcabc"));
            Console.WriteLine(LengthOfLongestSubstring("bbbbbb"));
            Console.WriteLine(LengthOfLongestSubstring("qwerttrewq"));
            Console.WriteLine(LengthOfLongestSubstring("a"));
        }
    }
}