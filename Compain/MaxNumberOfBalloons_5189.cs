using System;
using System.Linq;
namespace LeetCode.Compain
{
    public class MaxNumberOfBalloons_5189
    {
        public int MaxNumberOfBalloons(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return 0;
            }
            int[] count = new int[128];
            foreach (var t in text)
            {
                switch (t)
                {
                    case 'b':
                    case 'a':
                    case 'l':
                    case 'o':
                    case 'n':
                        count[t]++; break;
                    default: break;
                }
            }

            int singleMin = new[] { count['b'], count['a'], count['n'] }.Min();
            int doubleMin = new[] { count['l'], count['o'] }.Min();

            return Math.Min(singleMin,  doubleMin/2);
        }
    }
}