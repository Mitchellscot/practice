using static DSA.DSA;

namespace DSATests;

public class DSATests
{
    [Fact]
    public void CheckIfPalidrome_works()
    {
        string s = "racecar";
        bool result = CheckIfPalidrome(s);
        Assert.True(result);
    }
    [Fact]
    public void CombineAndSort_Test()
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
}