using System;
namespace LeetCode.Solution
{
    public class IntegerToRoman_12
    {
        /// v1.0 使用程序建立表
        // public string IntToRoman(int num)
        // {
        //     char[] originSimbol = new[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

        //     string[][] composedSymbol ={
        //         new string[10],
        //         new string[10],
        //         new string[10],
        //         new string[4],
        //     };
        //     for (int i = 0; i < 3; i++)
        //     {
        //         int j = 0;
        //         composedSymbol[i][j] = "";
        //         j++;
        //         while (j < 4)
        //         {
        //             composedSymbol[i][j] = new string(originSimbol[2 * i], j);
        //             j++;
        //         }
        //         composedSymbol[i][j] = originSimbol[2 * i].ToString() + originSimbol[2 * i + 1].ToString();
        //         j++;
        //         while (j < 9)
        //         {
        //             composedSymbol[i][j] = originSimbol[2 * i + 1].ToString() + new string(originSimbol[2 * i], j - 5);
        //             j++;
        //         }
        //         composedSymbol[i][j] = originSimbol[2 * i ].ToString() + originSimbol[2 * i + 2].ToString();
        //     }
        //     composedSymbol[3]=new[]{"","M","MM","MMM"};


        //     int bit = 0;
        //     string result = "";
        //     while (num != 0)
        //     {
        //         int index = num % 10;
        //         result = composedSymbol[bit][index] + result;
        //         num /= 10;
        //         bit++;
        //     }
        //     return result;
        // }

        /// v2.0 手动建立表
        // public string IntToRoman(int num)
        // {
        //     string[][] composedSymbol=new []{
        //         new[]{"","I","II","III","IV","V","VI","VII","VIII","IX"},
        //         new[]{"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC"},
        //         new[]{"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"},
        //         new[]{"","M","MM","MMM"}
        //     };
        //     int bit = 0;
        //     string result = "";
        //     while (num != 0)
        //     {
        //         int index = num % 10;
        //         result = composedSymbol[bit][index] + result;
        //         num /= 10;
        //         bit++;
        //     }
        //     return result;
        // }

        public string IntToRoman(int num)
        {
            char[] originSimbol = new[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

            int bit = 0;
            string result = "";
            int index = 0;
            while (num != 0)
            {
                index = num % 10;
                switch (index)
                {
                    case 0: break;
                    case 1:
                    case 2:
                    case 3:
                        result = new string(originSimbol[2 * bit], index)+result;
                        break;

                    case 4:
                        result = originSimbol[2 * bit].ToString() + originSimbol[2 * bit + 1].ToString() + result;
                        break;

                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        result = originSimbol[2 * bit + 1].ToString() + new string(originSimbol[2 * bit], index - 5) + result;
                        break;

                    case 9:
                        result = originSimbol[2 * bit].ToString() + originSimbol[2 * bit + 2].ToString() + result;
                        break;
                }
                num /= 10;
                bit++;
            }
            return result;
        }
        public void Test()
        {
            Console.WriteLine("请输入测试数据：");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(IntToRoman(number));
        }
    }
}