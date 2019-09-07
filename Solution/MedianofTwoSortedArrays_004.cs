using System;
namespace LeetCode.Solution
{
    public class MedianofTwoSortedArrays_004
    {
        /// V1.0

        // public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        // {
        //     int nums1_length = nums1.Length;
        //     int nums2_length = nums2.Length;
        //     int total_length = nums1_length + nums2_length;

        //     int[] longerNums = nums1_length > nums2_length ? nums1 : nums2;

        //     int[] total = new int[total_length];
        //     int index = 0;
        //     int nums1_index = 0, nums2_index = 0;

        //     while (nums1_index < nums1_length && nums2_index < nums2_length)
        //     {
        //         if (nums1[nums1_index] < nums2[nums2_index])
        //         {
        //             total[index] = nums1[nums1_index];
        //             index++;
        //             nums1_index++;
        //         }
        //         else
        //         {
        //             total[index] = nums2[nums2_index];
        //             index++;
        //             nums2_index++;
        //         }
        //     }
        //     while (nums1_index < nums1_length && nums2_index >= nums2_length)
        //     {
        //         total[index] = nums1[nums1_index];
        //         index++;
        //         nums1_index++;
        //     }
        //     while (nums2_index < nums2_length && nums1_index >= nums1_length)
        //     {
        //         total[index] = nums2[nums2_index];
        //         index++;
        //         nums2_index++;
        //     }

        //     if (total_length % 2 == 0)
        //     {
        //         return (total[total_length / 2] + total[total_length / 2 - 1]) / 2.0;
        //     }
        //     else
        //     {
        //         return total[total_length / 2];
        //     }
        // }


        ///     v2.0
        // public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        // {
        //     int nums1_length = nums1.Length;
        //     int nums2_length = nums2.Length;
        //     int total_length = (nums1_length + nums2_length)/2+1;

        //     int[] total = new int[total_length];
        //     int index = 0;
        //     int nums1_index = 0, nums2_index = 0;

        //     while (index<total_length)
        //     {   
        //         if (nums1_index < nums1_length && nums2_index < nums2_length)
        //         {
        //             if (nums1[nums1_index] < nums2[nums2_index])
        //             {
        //                 total[index] = nums1[nums1_index];
        //                 index++;
        //                 nums1_index++;
        //             }
        //             else
        //             {
        //                 total[index] = nums2[nums2_index];
        //                 index++;
        //                 nums2_index++;
        //             }
        //         }
        //         else if (nums1_index < nums1_length && nums2_index >= nums2_length)
        //         {
        //             total[index] = nums1[nums1_index];
        //             index++;
        //             nums1_index++;
        //         }
        //         else
        //         {
        //             total[index] = nums2[nums2_index];
        //             index++;
        //             nums2_index++;
        //         }
        //     }

        //     if ((nums1_length+nums2_length) % 2 == 0)
        //     {
        //         return (total[total_length-1] + total[total_length- 2]) / 2.0;
        //     }
        //     else
        //     {
        //         return total[total_length-1];
        //     }
        // }


        ///     v3.0
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int nums1_length = nums1.Length;
            int nums2_length = nums2.Length;
            int total_length = nums1_length + nums2_length;

            int[] total = total_length % 2 == 0 ? new int[2] : new int[1];

            int index = 0;
            int count = 0;
            int nums1_index = 0, nums2_index = 0;


            while (count < (total_length / 2 + 1))
            {
                if (total.Length == 2)
                {
                    if (nums1_index < nums1_length && nums2_index < nums2_length)
                    {
                        if (nums1[nums1_index] < nums2[nums2_index])
                        {
                            total[index] = nums1[nums1_index];
                            nums1_index++;
                        }
                        else
                        {
                            total[index] = nums2[nums2_index];
                            nums2_index++;
                        }
                    }
                    else if (nums1_index < nums1_length && nums2_index >= nums2_length)
                    {
                        total[index] = nums1[nums1_index];
                        nums1_index++;
                    }
                    else
                    {
                        total[index] = nums2[nums2_index];
                        nums2_index++;
                    }
                    index = (index + 1) % 2;
                }
                else
                {
                    if (nums1_index < nums1_length && nums2_index < nums2_length)
                    {
                        if (nums1[nums1_index] < nums2[nums2_index])
                        {
                            total[index] = nums1[nums1_index];
                            nums1_index++;
                        }
                        else
                        {
                            total[index] = nums2[nums2_index];
                            nums2_index++;
                        }
                    }
                    else if (nums1_index < nums1_length && nums2_index >= nums2_length)
                    {
                        total[index] = nums1[nums1_index];
                        nums1_index++;
                    }
                    else
                    {
                        total[index] = nums2[nums2_index];
                        nums2_index++;
                    }
                }
                count++;
            }

            if ((total_length) % 2 == 0)
            {
                return (total[0] + total[1]) / 2.0;
            }
            else
            {
                return total[0];
            }
        }
        public void Test()
        {
            var nums1 = new int[] { 1, 2 };
            var nums2 = new int[] { 3, 4 };
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));

            var nums3 = new int[] { };
            var nums4 = new[] { 2, 3 };
            Console.WriteLine(FindMedianSortedArrays(nums3, nums4));

        }
    }
}