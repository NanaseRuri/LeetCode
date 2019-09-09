using System.Linq;
using System;
namespace LeetCode.Solution
{
    public class LongestPalindromicSubstring_005
    {
        ///     v1.0
        // public string LongestPalindrome(string s)
        // {
        //     string temp = "#";
        //     foreach (var s1 in s)
        //     {
        //         temp += s1;
        //         temp += "#";
        //     }

        //     int tempLength = temp.Length;
        //     int[] count = new int[tempLength];


        //     for (int i = 1; i < tempLength / 2; i++)
        //     {
        //         for (int j = 1; j <= i; j++)
        //         {
        //             if (temp[i - j] == temp[i + j])
        //             {
        //                 count[i]++;
        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }
        //     }

        //     for (int i = tempLength / 2; i < tempLength - 1; i++)
        //     {
        //         for (int j = 1; j <= tempLength - i - 1; j++)
        //         {
        //             if (temp[i - j] == temp[i + j])
        //             {
        //                 count[i]++;
        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }
        //     }

        //     int maxLength = 0;
        //     int maxMiddle = 0;
        //     for (int i = 1; i < tempLength - 1; i++)
        //     {
        //         if (maxLength < count[i])
        //         {
        //             maxLength = count[i];
        //             maxMiddle = i;
        //         }
        //     }

        //     return s.Substring((maxMiddle - maxLength)/2, maxLength);
        // }

        public string LongestPalindrome(string s)
        {
            int max=0;
            int pre=0;
            int position=0;
            for(int i=0;i<s.Length;i++){
                pre=max;
                int oddSituation=LongestEverySituation(s,i,i);
                int evenSituation=LongestEverySituation(s,i,i+1);
                max=Math.Max(oddSituation,max);
                max=Math.Max(evenSituation,max);

                if(pre!=max){
                    position=i-(max-1)/2;                    
                }
            }

            return s.Substring(position,max);
        }

        public int LongestEverySituation(string s,int left,int right){
            while(left>=0&&right<s.Length&&s[left]==s[right]){
                    left--;
                    right++;

            }
            return right-left-1;
        }

        public void Test()
        {
            Console.WriteLine(LongestPalindrome("abbc"));
        }
    }
}