using System;
using System.Collections.Generic;
namespace LeetCode.Solution
{
    public class GenerateParentheses_022
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> list = new List<string>();
            RecallPushBrackets(list, "", 0, 0, n);

            return list;
        }

        void RecallPushBrackets(List<string> list, string current, int leftCount, int rightCount, int n)
        {
            if (current.Length == 2 * n)
            {
                list.Add(current);
                return;
            }

            if (leftCount < n)
            {
                RecallPushBrackets(list, current+"(", leftCount+1, rightCount, n);
            }
            if (rightCount < leftCount)
            {
                RecallPushBrackets(list, current+")", leftCount, rightCount+1, n);
            }
        }

        public void Test()
        {
            IList<string> list = GenerateParenthesis(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}