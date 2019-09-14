using System.Linq;
using System;
namespace LeetCode.Solution
{
    public class LongestCommonPrefix_14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                string beComparedString = strs[i];
                int index = 0;
                for (int j = 0; j < prefix.Length && j < beComparedString.Length && prefix.Length > 0; j++)
                {
                    if (prefix[j] == beComparedString[j])
                    {
                        index++;
                    }
                    else
                    {
                        break;
                    }
                }
                prefix = prefix.Substring(0, index);
            }

            return prefix;
        }

        public void Test()
        {
            string[] strs = new[]{
                "aca","cba"
            };
            Console.WriteLine(LongestCommonPrefix(strs));
        }
    }
}