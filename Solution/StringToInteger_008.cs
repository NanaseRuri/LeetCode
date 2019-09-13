using System.Text;
using System.Text.RegularExpressions;
using System;
namespace LeetCode.Solution
{
    public class StringToInteger_008
    {
        /// v1.0 正则版本
        // public int MyAtoi(string str)
        // {
        //     string regex = @"^[\s\-]*\d+";
        //     string result = Regex.Match(str, regex).Value.TrimStart();

        //     Int64 large = Int64.Parse(result);
        //     if (large > int.MaxValue)
        //     {
        //         return int.MaxValue;
        //     }
        //     else if (large < int.MinValue)
        //     {
        //         return int.MinValue;
        //     }
        //     return (int)large;
        // }

        /// v2.0 状态机
        // public int MyAtoi(string str)
        // {
        //     str = str.Trim();
        //     if (string.IsNullOrEmpty(str))
        //     {
        //         return 0;
        //     }

        //     StringBuilder firstProcess = new StringBuilder();
        //     bool getNumberOrOperator = false;

        //     int index = 0;
        //     while (index < str.Length)
        //     {
        //         char c = str[index];
        //         index++;
        //         switch (c)
        //         {
        //             case ' ': break;
        //             case '-':
        //             case '+':
        //             case '1':
        //             case '2':
        //             case '3':
        //             case '4':
        //             case '5':
        //             case '6':
        //             case '7':
        //             case '8':
        //             case '9':
        //             case '0':
        //                 firstProcess.Append(c);
        //                 getNumberOrOperator = true;
        //                 break;

        //             default: return 0;
        //         }
        //         if (getNumberOrOperator)
        //         {
        //             break;
        //         }
        //     }

        //     bool beInterrupted = false;
        //     if (getNumberOrOperator)
        //     {
        //         while (index < str.Length)
        //         {
        //             char c = str[index];
        //             index++;
        //             switch (c)
        //             {
        //                 case '1':
        //                 case '2':
        //                 case '3':
        //                 case '4':
        //                 case '5':
        //                 case '6':
        //                 case '7':
        //                 case '8':
        //                 case '9':
        //                 case '0':
        //                     firstProcess.Append(c);
        //                     break;
        //                 default: beInterrupted = true; break;
        //             }

        //             if (beInterrupted)
        //             {
        //                 break;
        //             }
        //         }
        //     }

        //     string result = firstProcess.ToString();

        //     int number;
        //     try
        //     {
        //         number = int.Parse(result);
        //     }
        //     catch (OverflowException)
        //     {
        //         if (result[0] == '-')
        //         {
        //             return int.MinValue;
        //         }
        //         return int.MaxValue;
        //     }
        //     catch
        //     {
        //         return 0;
        //     }

        //     return number;
        // }

        public int MyAtoi(string str)
        {
            str = str.Trim();
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int index = 0;
            int sign = 1;
            if (str[index] == '+' || str[index] == '-')
            {
                sign = str[index] == '+' ? 1 : -1;
                index++;
            }

            Int64 result = 0;
            int resultLength = 0;
            while (resultLength < 12 && index < str.Length && str[index] >= '0' && str[index] <= '9')
            {
                Int64 preResult = result;
                result = 10 * result + str[index] - '0';
                index++;

                if (preResult != result)
                {
                    resultLength++;
                }
            }

            result = sign * result;
            if (result == (int)result)
            {
                return (int)result;
            }
            else
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }
        }


        public void Test()
        {
            Console.WriteLine("请输入测试值");
            string testString = Console.ReadLine();
            Console.WriteLine(MyAtoi(testString));
        }
    }
}