using static DSA.DSA;

namespace DSATests;

public class DSATests
{
    [Fact]
    public void CheckIfPalidrome_test()
    {
        string s = "racecar";
        bool result = CheckIfPalidrome(s);
        Assert.True(result);
    }
    [Fact]
    public void CheckForTarget_test()
    {
        // Test case 1: Target is found
        int[] nums1 = { 1, 2, 3, 4, 5 };
        int target1 = 9;
        bool result1 = CheckForTarget(nums1, target1);
        Assert.True(result1);

        // Test case 2: Target is not found
        int[] nums2 = { 1, 2, 3, 4, 5 };
        int target2 = 10;
        bool result2 = CheckForTarget(nums2, target2);
        Assert.False(result2);

        // Test case 3: Empty array
        int[] nums3 = { };
        int target3 = 1;
        bool result3 = CheckForTarget(nums3, target3);
        Assert.False(result3);

        // Test case 4: Single element array
        int[] nums4 = { 1 };
        int target4 = 1;
        bool result4 = CheckForTarget(nums4, target4);
        Assert.False(result4);

        // Test case 5: Array with negative numbers
        int[] nums5 = { -3, -2, -1, 0, 1, 2, 3 };
        int target5 = 0;
        bool result5 = CheckForTarget(nums5, target5);
        Assert.True(result5);
    }
    [Fact]
    public void CombineAndSort_test()
    {
        // Test case 1: Both arrays are empty
        int[] arr1 = new int[] { };
        int[] arr2 = new int[] { };
        int[] expected = new int[] { };
        Assert.Equal(expected, CombineAndSort(arr1, arr2));

        // Test case 2: One array is empty
        arr1 = new int[] { 1, 3, 5 };
        arr2 = new int[] { };
        expected = new int[] { 1, 3, 5 };
        Assert.Equal(expected, CombineAndSort(arr1, arr2));

        // Test case 3: Both arrays have elements
        arr1 = new int[] { 1, 3, 5 };
        arr2 = new int[] { 2, 4, 6 };
        expected = new int[] { 1, 2, 3, 4, 5, 6 };
        Assert.Equal(expected, CombineAndSort(arr1, arr2));

        // Test case 4: Arrays with duplicate elements
        arr1 = new int[] { 1, 2, 2, 3 };
        arr2 = new int[] { 2, 3, 4 };
        expected = new int[] { 1, 2, 2, 2, 3, 3, 4 };
        Assert.Equal(expected, CombineAndSort(arr1, arr2));

        // Test case 5: Arrays with negative elements
        arr1 = new int[] { -3, -1, 2 };
        arr2 = new int[] { -2, 0, 3 };
        expected = new int[] { -3, -2, -1, 0, 2, 3 };
        Assert.Equal(expected, CombineAndSort(arr1, arr2));
    }
    [Fact]
    public void IsSubsequence_Test()
    {
        // Test case 1: Subsequence is empty
        string s = "";
        string t = "abc";
        bool expected = true;
        Assert.Equal(expected, IsSubsequence(s, t));

        // Test case 2: Both strings are empty
        s = "";
        t = "";
        expected = true;
        Assert.Equal(expected, IsSubsequence(s, t));

        // Test case 3: Subsequence is longer than the string
        s = "abc";
        t = "a";
        expected = false;
        Assert.Equal(expected, IsSubsequence(s, t));

        // Test case 4: Subsequence is not present
        s = "axc";
        t = "ahbgdc";
        expected = false;
        Assert.Equal(expected, IsSubsequence(s, t));

        // Test case 5: Subsequence is present
        s = "abc";
        t = "ahbgdc";
        expected = true;
        Assert.Equal(expected, IsSubsequence(s, t));
    }
    [Fact]
    public void Squares_Test()
    {
        // Test case 1: Empty array
        int[] nums1 = new int[] { };
        int[] expected1 = new int[] { };
        Assert.Equal(expected1, SortedSquares(nums1));

        // Test case 2: Single element array
        int[] nums2 = new int[] { 2 };
        int[] expected2 = new int[] { 4 };
        Assert.Equal(expected2, SortedSquares(nums2));

        // Test case 3: Array with positive numbers
        int[] nums3 = new int[] { 1, 2, 3 };
        int[] expected3 = new int[] { 1, 4, 9 };
        Assert.Equal(expected3, SortedSquares(nums3));

        // Test case 4: Array with negative numbers
        int[] nums4 = new int[] { -3, -2, -1 };
        int[] expected4 = new int[] { 1, 4, 9 };
        Assert.Equal(expected4, SortedSquares(nums4));

        // Test case 5: Array with mixed positive and negative numbers
        int[] nums5 = new int[] { -3, -1, 0, 1, 2 };
        int[] expected5 = new int[] { 0, 1, 1, 4, 9 };
        Assert.Equal(expected5, SortedSquares(nums5));

        //Test case 6 from the lesson
        int[] nums6 = new int[] { -4, -1, 0, 3, 10 };
        int[] expected6 = new int[] { 0, 1, 9, 16, 100 };
        Assert.Equal(expected6, SortedSquares(nums6));

        //Test case 7 from the lesson
        int[] nums7 = new int[] { -7, -3, 2, 3, 11 };
        int[] expected7 = new int[] { 4, 9, 9, 49, 121 };
        Assert.Equal(expected7, SortedSquares(nums7));
    }
    [Fact]
    public void FindLength_Test()
    {
        int[] nums1 = { 1, 2, 3, 4, 5 };
        int k1 = 5;
        int expected1 = 2;
        int result1 = FindLength(nums1, k1);
        Assert.Equal(expected1, result1);

        int[] nums2 = { 1, 1, 1, 1, 1 };
        int k2 = 5;
        int expected2 = 5;
        int result2 = FindLength(nums2, k2);
        Assert.Equal(expected2, result2);

        int[] nums3 = { 6, 7, 8, 9, 10 };
        int k3 = 5;
        int expected3 = 0;
        int result3 = FindLength(nums3, k3);
        Assert.Equal(expected3, result3);

        int[] nums4 = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        int k4 = 11;
        int expected4 = 4;
        int result4 = FindLength(nums4, k4);
        Assert.Equal(expected4, result4);

        int[] nums5 = { 5 };
        int k5 = 5;
        int expected5 = 1;
        int result5 = FindLength(nums5, k5);
        Assert.Equal(expected5, result5);
    }
}