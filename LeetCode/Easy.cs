namespace LeetCode;

public class Easy
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSum(int[] nums, int target) 
    {
        if(nums.Length == 0)
            return [0,0];
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == nums.Length - 1)
                return [0,0];
            else if(nums[i] + nums[i+1] == target)
                return [i, i + 1];
        }
        return [0,0];
    }
}
