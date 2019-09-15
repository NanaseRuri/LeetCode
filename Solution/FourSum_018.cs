using System.Collections.Generic;
using System;
namespace LeetCode.Solution
{
    public class FourSum_018
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums == null || nums.Length < 4)
            {
                return result;
            }
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 3 && nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] <= target; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length && nums[i] + nums[j] + nums[j + 1] + nums[j + 2] <= target; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }
                    int left = j + 1;
                    int right = nums.Length - 1;
                    while (left < right)
                    {
                        int currentSum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (currentSum == target)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }
                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            right--;
                            left++;
                        }
                        else if (currentSum > target)
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }
                    }
                }
            }
            return result;
        }

        public void Test()
        {
            int[] nums = { 1, -2, -5, -4, -3, 3, 3, 5 };
            IList<IList<int>> lists = FourSum(nums, -11);
            foreach (var list in lists)
            {
                foreach (var element in list)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine();
            }
        }
    }
}