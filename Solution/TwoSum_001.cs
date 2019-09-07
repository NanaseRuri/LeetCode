using System.Collections.Generic;
using System;

public class TwoSum_1
{

    public static Dictionary<int, List<int>> GetDictionary(int[] nums)
    {
        Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();

        int index = 0;
        foreach (var num in nums)
        {
            if (!dictionary.ContainsKey(num))
            {
                dictionary.Add(num, new List<int> { index });
            }
            else
            {
                dictionary[num].Add(index);
            }
            index++;
        }

        return dictionary;
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        Dictionary<int, List<int>> dictionary = GetDictionary(nums);

        int index = 0;
        foreach (var num in nums)
        {
            int temp = target - num;
            if (dictionary.ContainsKey(temp))
            {
                if (index == dictionary[temp][0])
                {
                    if (dictionary[temp].Count > 1)
                    {
                        result[0] = index;
                        result[1] = dictionary[temp][1];
                        return result;
                    }
                }
                else
                {
                    result[0] = index;
                    result[1] = dictionary[temp][0];
                    return result;
                }
            }
            index++;
        }
        return null;
    }

    public void Test()
    {

        int[] nums = new int[] { 3, 3 };
        var result = TwoSum_1.TwoSum(nums, 6);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
