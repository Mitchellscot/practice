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
    [Fact]
    public void ReverseString_Test()
    {
        // Test case 1: Empty string
        char[] s = "".ToCharArray();
        char[] expected = "".ToCharArray();
        Assert.Equal(expected, ReverseString(s));

        // Test case 2: Single character
        s = "a".ToCharArray();
        expected = "a".ToCharArray();
        Assert.Equal(expected, ReverseString(s));

        // Test case 3: Palindrome string
        s = "racecar".ToCharArray();
        expected = "racecar".ToCharArray();
        Assert.Equal(expected, ReverseString(s));

        // Test case 4: Regular string
        s = "hello".ToCharArray();
        expected = "olleh".ToCharArray();
        Assert.Equal(expected, ReverseString(s));

        // Test case 5: String with spaces
        s = "hello world".ToCharArray();
        expected = "dlrow olleh".ToCharArray();
        Assert.Equal(expected, ReverseString(s));

        // Test case 6: String with special characters
        s = "a!b@c#".ToCharArray();
        expected = "#c@b!a".ToCharArray();
        Assert.Equal(expected, ReverseString(s));
    }
    [Fact]
    public void TestReverseStringInPlace()
    {
        // Test case 1: Normal string
        char[] input1 = { 'h', 'e', 'l', 'l', 'o' };
        char[] expected1 = { 'o', 'l', 'l', 'e', 'h' };
        ReverseStringInPlace(input1);
        Assert.Equal(expected1, input1);

        // Test case 2: Empty string
        char[] input2 = { };
        char[] expected2 = { };
        ReverseStringInPlace(input2);
        Assert.Equal(expected2, input2);

        // Test case 3: Single character string
        char[] input3 = { 'a' };
        char[] expected3 = { 'a' };
        ReverseStringInPlace(input3);
        Assert.Equal(expected3, input3);

        // Test case 4: Palindrome string
        char[] input4 = { 'm', 'a', 'd', 'a', 'm' };
        char[] expected4 = { 'm', 'a', 'd', 'a', 'm' };
        ReverseStringInPlace(input4);
        Assert.Equal(expected4, input4);
    }
}