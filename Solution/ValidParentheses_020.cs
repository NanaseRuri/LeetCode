using System.Linq;
using System;
using System.Collections.Generic;
namespace LeetCode.Solution
{
    public class ValidParentheses_020
    {
        public bool IsValid(string s)
        {
            Stack<char> leftBrackets = new Stack<char>(s.Length / 2);
            Dictionary<char, char> matchings = new Dictionary<char, char>(){
                {'(',')'},
                {'[',']'},
                {'{','}'}
            };

            foreach (var bracket in s)
            {
                switch (bracket)
                {
                    case '(':
                    case '{':
                    case '[':
                        leftBrackets.Push(bracket);
                        break;
                    default:
                        if (leftBrackets.TryPop(out char temp) && matchings[temp] == bracket)
                        {
                            break;
                        }
                        else
                        {
                            return false;
                        }
                }
            }

            if (leftBrackets.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Test()
        {
            string[] datas = {
                "()[]{}",
                "(]",
                "{[]}" };

            foreach (var item in datas)
            {
                Console.WriteLine(IsValid(item));
            }
        }
    }
}