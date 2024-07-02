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
        if (nums.Length == 0)
            return [0, 0];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] + nums[i] == target)
                    return [i, j];
            }
        }
        return [0, 0];
    }
    public static int[] TwoSum_1(int[] nums, int target)
    {
        Dictionary<int, int> seen = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (seen.ContainsKey(diff))
                return [seen[diff], i];
            else if (!seen.ContainsKey(diff) && !seen.ContainsKey(nums[i]))
            {
                seen.Add(nums[i], i);
            }
        }
        return [0, 0];
    }
    public static bool IsPalindrome_0(int n)
    {
        if (n < 0)
            return false;
        if (n < 10)
            return true;

        var middle = n.ToString().Length / 2;
        var stringified = n.ToString();
        var firstHalf = stringified.Substring(0, middle);
        var secondHalfReversed = n.ToString().Length % 2 == 0 ? 
            String.Join("", stringified.Substring(middle).Reverse()) : 
            String.Join("", stringified.Substring(middle + 1).Reverse());

        return firstHalf == secondHalfReversed;
    }
    //solution provided
    public static bool IsPalindrome_1(int n)
    {
        // N Cant be negative, and if it ends in 0 
        // then it starts with 0
        if(n < 0 || (n % 10 == 0 && n != 0))
            return false;

        int revertedNumber = 0;
        // Modding by 10 leaves you with the 
        // last digit
        // 12 % 10 => 2
        while (n > revertedNumber)
        {
            //Append the last digit of n
            revertedNumber = revertedNumber * 10 + n % 10;
            //change the last digit of n
            n /= 10;
        }
        return n == revertedNumber || n == revertedNumber / 10;
    }
}
