using System;
namespace LeetCode.Solution
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;

            int area = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    area = Math.Max(area, height[left] * (right - left));
                    left++;
                }
                else
                {
                    area = Math.Max(area, height[right] * (right - left));
                    right--;
                }
            }
            return area;
        }
    }
}