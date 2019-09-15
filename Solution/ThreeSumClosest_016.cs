using System;
namespace LeetCode.Solution
{
    public class ThreeSumClosest_016
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int result = nums[0] + nums[1] + nums[2];
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int left = i + 1, right = nums.Length - 1;
                int current = 0;
                while (left < right)
                {
                    current = nums[i] + nums[left] + nums[right];
                    if (Math.Abs(result - target) > Math.Abs(current - target))
                    {
                        result = current;
                    }

                    if (current < target)
                    {
                        left++;
                    }
                    else if (current > target)
                    {
                        right--;
                    }
                    else
                    {
                        return target;
                    }
                }
            }
            return result;
        }

        public void Test()
        {
            int[] nums = new[] { 0, 2, 1, -3 };
            Console.WriteLine(ThreeSumClosest(nums, 1));
        }
    }
}