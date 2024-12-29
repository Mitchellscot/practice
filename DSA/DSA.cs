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
    public static bool CheckForTarget(int[] nums, int target)
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
    //Given two sorted integer arrays arr1 and arr2, return a new array that combines both of them and is also sorted.
    //time complexity is 0(n) and space complexity is 0(1)
    public static int[] CombineAndSort(int[] arr1, int[] arr2)
    {
        var ans = new List<int>();
        int i = 0, j = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                ans.Add(arr1[i]);
                i++;
            }
            else
            {
                ans.Add(arr2[j]);
                j++;
            }
        }
        //these account for the remaining elements in the arrays, adding them as they are already sorted.
        while (i < arr1.Length)
        {
            ans.Add(arr1[i]);
            i++;
        }
        while (j < arr2.Length)
        {
            ans.Add(arr2[j]);
            j++;
        }
        return ans.ToArray();
    }
    //Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    //For example, "ace" is a subsequence of "abcde" because "abcde" contains the letters "ace" in that same order - the fact that they aren't consecutive doesn't matter.
    public static bool IsSubsequence(string s, string t)
    {
        int i = 0, j = 0;
        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j])
            {
                i++;
            }
            j++;
        }
        return i == s.Length;
    }
    //reverse a string
    public static char[] ReverseString(char[] s)
    {
        if (s.Length == 0)
        {
            return s;
        }
        char[] answer = new char[s.Length];
        int answerIndex = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            answer[answerIndex] = s[i];
            answerIndex++;
        }
        return answer;
    }
    //reverse a string in place. i = start, e = end
    public static void ReverseStringInPlace(char[] s)
    {
        // int i = 0;
        // int e = s.Length - 1;
        // while (i < e)
        // {
        //     char temp = s[i];
        //     s[i] = s[e];
        //     s[e] = temp;
        //     i++;
        //     e--;
        // }
        int e = s.Length - 1;
        for (int i = 0; i < e; i++)
        {
            //first we move the current to a temp
            char temp = s[i];
            //then we override the current with the one at the end
            s[i] = s[e];
            //then we assign the one at the end the current
            s[e] = temp;
            //then move the pointer down
            e--;
        }
    }
}