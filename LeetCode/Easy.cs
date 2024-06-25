using System.Security.Cryptography.X509Certificates;

namespace LeetCode;

public class Easy
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSum_0(int[] nums, int target) 
    {
        if(nums.Length == 0)
            return [0,0];
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if(nums[j] + nums[i] == target)
                    return [i, j];
            }
        }
        return [0,0];
    }
    public static int[] TwoSum_1(int[] nums, int target) 
    {
        Dictionary<int, int> seen = new ();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if(seen.ContainsKey(diff))
                return [seen[diff], i];
            else
                seen.Add(nums[i], i);
        }
        return [0,0];
    }
}
