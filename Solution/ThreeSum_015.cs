using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode.Solution
{
    public class ThreeSum_015
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums == null || nums.Length < 3)
            {
                return result;
            }

            Array.Sort(nums);
            for (int i = 0; i < nums.Length && nums[i] <= 0; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new[] { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }
                        left++;
                        right--;
                    }
                    else if (sum > 0)
                    {
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                }

            }
            return result;
        }


        /// v2.0 除去重复元素，但速度提升不多，理解不能
        // public IList<IList<int>> ThreeSum(int[] nums)
        // {
        //     IList<IList<int>> result = new List<IList<int>>();
        //     if (nums == null || nums.Length < 3)
        //     {
        //         return result;
        //     }
        //     Array.Sort(nums);

        //     for (int i = 0; i < nums.Length - 2 && nums[i] <= 0; i++)
        //     {
        //         for (int j = i + 1; j < nums.Length - 1; j++)
        //         {
        //             if (nums[i] + nums[j] > 0)
        //             {
        //                 break;
        //             }
        //             int position = BinarySearch(nums, -nums[i] - nums[j], j + 1, nums.Length - 1);
        //             if (position != -1)
        //             {
        //                 result.Add(new List<int> { nums[i], nums[j], nums[position] });

        //                 while (j < nums.Length - 1)
        //                 {
        //                     if (nums[j] == nums[j + 1])
        //                     {
        //                         j++;
        //                     }
        //                     else
        //                     {
        //                         break;
        //                     }
        //                 }
        //                 while (i<j)
        //                 {
        //                     if (nums[i] == nums[i + 1])
        //                     {
        //                         i++;
        //                     }
        //                     else
        //                     {
        //                         break;
        //                     }
        //                 }
        //             }
        //         }
        //     }
        //     return result;
        // }


        /// v1.0
        // public IList<IList<int>> ThreeSum(int[] nums)
        // {
        //     IList<IList<int>> result = new List<IList<int>>();
        //     QuickSort(nums, 0, nums.Length - 1);
        //     Dictionary<int, List<List<int>>> dictionary = new Dictionary<int, List<List<int>>>();

        //     int pre_i = int.MaxValue;
        //     for (int i = 0; i < nums.Length - 2 && nums[i] <= 0; i++)
        //     {
        //         if (nums[i] == pre_i)
        //         {
        //             continue;
        //         }
        //         int pre_j = int.MinValue;
        //         for (int j = i + 1; j < nums.Length - 1; j++)
        //         {
        //             if (nums[j] == pre_j)
        //             {
        //                 continue;
        //             }
        //             int position = BinarySearch(nums, -nums[i] - nums[j], j + 1, nums.Length - 1);
        //             if (position != -1)
        //             {
        //                 List<int> fitArray = new List<int> { nums[i], nums[j], nums[position] };
        //                 int hashCode = GetHashCode(fitArray);
        //                 if (!dictionary.ContainsKey(hashCode))
        //                 {
        //                     dictionary.Add(hashCode, new List<List<int>>());
        //                     dictionary[hashCode].Add(fitArray);
        //                     result.Add(fitArray);
        //                 }
        //                 else if (!ContainsList(dictionary[hashCode], fitArray))
        //                 {
        //                     dictionary[hashCode].Add(fitArray);
        //                     result.Add(fitArray);
        //                 }

        //                 pre_i = nums[i];
        //                 pre_j = nums[j];
        //             }
        //         }
        //     }
        //     return result;
        // }

        // void QuickSort(int[] nums, int left, int right)
        // {
        //     if (left > right)
        //     {
        //         return;
        //     }

        //     int index = SortUnit(nums, left, right);
        //     QuickSort(nums, left, index - 1);
        //     QuickSort(nums, index + 1, right);
        // }

        // int SortUnit(int[] nums, int left, int right)
        // {
        //     int key = nums[left];
        //     while (left < right)
        //     {
        //         while (nums[right] >= key && right > left)
        //         {
        //             right--;
        //         }
        //         nums[left] = nums[right];
        //         while (nums[left] <= key && left < right)
        //         {
        //             left++;
        //         }
        //         nums[right] = nums[left];
        //     }
        //     nums[left] = key;

        //     return right;
        // }

        int BinarySearch(int[] nums, int target, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (target == nums[middle])
                {
                    return middle;
                }
                else if (target > nums[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }
            return -1;
        }

        // bool IsEquals(IList<int> arr1, IList<int> arr2)
        // {
        //     for (int i = 0; i < arr1.Count; i++)
        //     {
        //         if (arr1[i] != arr2[i])
        //         {
        //             return false;
        //         }
        //     }
        //     return true;
        // }

        // bool ContainsList(List<List<int>> conflictList, IList<int> list)
        // {
        //     foreach (var element in conflictList)
        //     {
        //         if (IsEquals(element, list))
        //         {
        //             return true;
        //         }
        //     }
        //     return false;
        // }

        // int GetHashCode(IList<int> array)
        // {
        //     int result = 0;
        //     foreach (var element in array)
        //     {
        //         result = 31 * result + element;
        //     }
        //     return result;
        // }

        public void Test()
        {
            int[] nums = new int[] { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 };
            IList<IList<int>> result = ThreeSum(nums);
            foreach (var list in result)
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