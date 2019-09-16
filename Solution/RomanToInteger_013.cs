using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode.Solution
{
    public class RomanToInteger_013
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>(){
                                                        {'I', 1},
                                                        {'V', 5},
                                                        {'X', 10},
                                                        {'L', 50},
                                                        {'C', 100},
                                                        {'D', 500},
                                                        {'M', 1000}};

            int result = 0;
            int pre = 0;
            int next = 0;
            for (int i = 0; i < s.Length; i++)
            {
                next = dic[s[i]];
                if (pre < next)
                {
                    result -= pre;
                }
                else
                {
                    result += pre;
                }
                pre = next;
            }
            result += next;
            return result;
        }

        public void Test()
        {
            Console.WriteLine("请输入测试数据：");
            Console.WriteLine(RomanToInt(Console.ReadLine()));
        }
    }
}