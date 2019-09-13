using System.Net.Mime;
using System;
namespace LeetCode.Solution
{
    public class RegularExpressionMatching_010
    {
        public bool IsMatch(string s, string p)
        {
            bool[,] dp = new bool[s.Length + 1, p.Length + 1];
            dp[s.Length, p.Length] = true;

            for (int i = s.Length; i >= 0; i--)
            {
                for (int j = p.Length - 1; j >= 0; j--)
                {
                    bool match = (i < s.Length &&
                                    (s[i] == p[j] || p[j] == '.'));
                    if (j + 1 < p.Length && p[j + 1] == '*')
                    {
                        dp[i, j] = dp[i, j + 2] || match && dp[i + 1, j];
                    }
                    else
                    {
                        dp[i, j] = match && dp[i + 1, j + 1];
                    }
                }
            }
            return dp[0, 0];
        }


        public void Test()
        {
            Console.WriteLine("待匹配字符串");
            string s = Console.ReadLine();
            Console.WriteLine("规则字符串");
            string p = Console.ReadLine();
            Console.WriteLine(IsMatch(s, p));
        }
    }


    /// v1.0 失败
    // public bool IsMatch(string s, string p)
    // {
    //     if (string.IsNullOrEmpty(p))
    //     {
    //         return true;
    //     }


    //     int s_Length = s.Length;
    //     int p_Length = p.Length;

    //     // 由于最后需要判断规则是否匹配完成，所以声明在集合外
    //     int p_Index = 0;
    //     int s_Index = 0;
    //     while (s_Index < s_Length && p_Index < p_Length)
    //     {
    //         if (p[p_Index] == '.')
    //         {
    //             if (p.Length - 1 > p_Index && p[p_Index + 1] == '*')    
    //             {
    //                 while (s_Index < s_Length && p_Index < p_Length)
    //                 {
    //                     s_Index++;
    //                     p_Index++;
    //                 }
    //             }
    //             else
    //             {
    //                 s_Index++;
    //                 p_Index++;
    //             }
    //         }
    //         else if (p[p_Index] != '*')
    //         {
    //             if (p.Length > p_Index)
    //             {
    //                 // 如果一个字符下一个字符是 * ，字符串 p 的下标进 2，字符串 s 的下标递增直到不匹配
    //                 if (p.Length - 1 > p_Index && p[p_Index + 1] == '*')
    //                 {
    //                     while (s_Index < s_Length && s[s_Index] == p[p_Index])
    //                     {
    //                         s_Index++;
    //                     }
    //                     p_Index += 2;
    //                 }
    //                 else if (s[s_Index] == p[p_Index])
    //                 {
    //                     s_Index++;
    //                     p_Index++;
    //                 }
    //                 else
    //                 {
    //                     return false;
    //                 }
    //             }
    //         }
    //         else
    //         {
    //             return false;
    //         }
    //     }

    //     if (p_Index == p_Length && s_Index == s_Length)
    //     {
    //         return true;
    //     }

    //     return false;
    // }

}
