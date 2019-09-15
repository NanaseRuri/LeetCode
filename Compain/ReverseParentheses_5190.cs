using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace LeetCode.Compain
{
    public class ReverseParentheses_5190
    {
        public string ReverseParentheses(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            List<int> leftBracket = new List<int>();
            List<int> rightBracket = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    leftBracket.Add(i);
                }
                else if (s[i] == ')')
                {
                    rightBracket.Add(i);
                }
            }
            leftBracket.Reverse();

            int bracketCount = leftBracket.Count;
            int s_Length = s.Length;
            for (int i = 0; i < bracketCount; i++)
            {
                if (rightBracket[i] - leftBracket[i] >= 1)
                {
                    string s1 = s.Substring(0, leftBracket[i]);
                    var s2 = new string(s.Substring(leftBracket[i], rightBracket[i] - leftBracket[i] + 1).Reverse().ToArray());
                    string s3 = "";
                    if (rightBracket[i] + 1 < s_Length)
                    {
                        s3 = s.Substring(rightBracket[i] + 1, s_Length - rightBracket[i] - 1);
                    }
                    s = s1 + s2 + s3;
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var element in s)
            {
                if (element != '(' && element != ')')
                {
                    stringBuilder.Append(element);
                }
            }
            return stringBuilder.ToString();
        }

        public void Test()
        {
            Console.WriteLine(ReverseParentheses("a(bcdefghijkl(mno)p)q"));
        }
    }
}