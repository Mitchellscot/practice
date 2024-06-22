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
        int[] answer = [0,0];
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == nums.Length)
                break;
            else if(nums[i] + nums[i+1] == target)
                return new [] {i, i + 1};
        }
        return answer;
    }
}
