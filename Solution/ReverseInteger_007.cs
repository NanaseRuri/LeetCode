using System;
using System.Collections.Generic;
namespace LeetCode.Solution
{
    public class ReverseInteger_007
    {
        public int Reverse(int x)
        {
            Int64 result=0;
            while(x!=0){
                result=10*result+x%10;
                x/=10;
            }
            if(result>int.MaxValue||result<int.MinValue){
                return 0;
            }
            return (int)result;
        }

        public void Test(){
            Console.WriteLine("请输入测试值");
            int testNumber=int.Parse(Console.ReadLine());
            Console.WriteLine(Reverse(testNumber));
        }
    }
}