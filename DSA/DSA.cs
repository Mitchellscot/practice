namespace DSA;

public static class DSA
{
    //two pointers
    public static bool CheckIfPalidrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    //two pointers solving two sum with a sorted array.
    //0(n) time complexity and 0(1) space complexity
    public bool CheckForTarget(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int curr = nums[left] + nums[right];
            if (curr == target)
            {
                return true;
            }
            if (curr > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return false;
    }