using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums=new int[]{3,3};
            var result=TwoSum_1.TwoSum(nums,6);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
