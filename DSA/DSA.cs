﻿namespace DSA;

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
    // Write a function that reverses a string. The input string is given as an array of characters s.
    // Must be done in place...
    public static void ReverseString(char[] s)
    {
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
    // Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
    public static int[] SortedSquares(int[] nums)
    {

        int z = nums.Length - 1;
        int y = 0;
        int[] answer = new int[nums.Length];

        for (int x = nums.Length - 1; x >= 0; x--)
        {
            var leftPointer = nums[y] * nums[y];
            var rightPointer = nums[z] * nums[z];
            if (leftPointer > rightPointer)
            {
                answer[x] = leftPointer;
                y++;
            }
            else
            {
                answer[x] = rightPointer;
                z--;
            }
        }
        return answer;
    }
    //Given an array of positive integers nums and an integer k, find the length of the longest subarray whose sum is less than or equal to k.
    public static int FindLength(int[] nums, int k)
    {
        // curr is the current sum of the window
        int left = 0, curr = 0, ans = 0;

        for (int right = 0; right < nums.Length; right++)
        {
            curr += nums[right];

            while (curr > k)
            {
                curr -= nums[left];
                left++;
            }
            // answer the the length of the subarray. We want the longest one.
            ans = Math.Max(ans, right - left + 1);
        }

        return ans;
    }
}