using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

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
        if (n < 0 || (n % 10 == 0 && n != 0))
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
    /// <summary>
    /// Given a roman numeral, convert it to an integer. Assume always valid input.
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static int RomanToInt_0(string s)
    {
        var array = s.ToCharArray();
        var sum = 0;
        foreach (var c in array)
        {
            switch (c)
            {
                case 'I':
                    sum += 1;
                    break;
                case 'V':
                    sum += 5;
                    break;
                case 'X':
                    sum += 10;
                    break;
                case 'L':
                    sum += 50;
                    break;
                case 'C':
                    sum += 100;
                    break;
                case 'D':
                    sum += 500;
                    break;
                case 'M':
                    sum += 1000;
                    break;
                default:
                    break;
            }
        }
        if (s.Contains("IV") || s.Contains("IX"))
            sum -= 2;
        if (s.Contains("XL") || s.Contains("XC"))
            sum -= 20;
        if (s.Contains("CD") || s.Contains("CM"))
            sum -= 200;
        return sum;
    }
    //LC solution provided
    public static int RomanToInt_1(string s)
    {

        Dictionary<char, int> values =
        new Dictionary<char, int>() { { 'I', 1 },   { 'V', 5 },   { 'X', 10 },
                                      { 'L', 50 },  { 'C', 100 }, { 'D', 500 },
                                      { 'M', 1000 } };
        int total = 0;
        int i = 0;
        while (i < s.Length)
        {
            // If this is the subtractive case.
            char currentSymbol = s[i];
            int currentValue = values[currentSymbol];
            int nextValue = 0;
            if (i + 1 < s.Length)
            {
                char nextSymbol = s[i + 1];
                nextValue = values[nextSymbol];
            }

            if (currentValue < nextValue)
            {
                total += (nextValue - currentValue);
                i += 2;
            }
            // else this is NOT the subtractive case.
            else
            {
                total += currentValue;
                i += 1;
            }
        }
        return total;
    }
    //variation on the above, just including the dobule digits and then checking if each section
    //is a double digit or not.
    public static int RomanToInt_2(string s)
    {
        Dictionary<string, int> values = new Dictionary<string, int> {
        { "I", 1 },   { "V", 5 },    { "X", 10 },  { "L", 50 }, { "C", 100 },
        { "D", 500 }, { "M", 1000 }, { "IV", 4 },  { "IX", 9 }, { "XL", 40 },
        { "XC", 90 }, { "CD", 400 }, { "CM", 900 }
        };
        int sum = 0;
        int i = 0;
        while (i < s.Length)
        {
            if (i < s.Length - 1)
            {
                string doubleSymbol = s.Substring(i, 2);
                if (values.ContainsKey(doubleSymbol))
                {
                    sum += values[doubleSymbol];
                    i += 2;
                    continue;
                }
            }

            string singleSymbol = s.Substring(i, 1);
            sum += values[singleSymbol];
            i += 1;
        }

        return sum;
    }
    //with linq
    public static string LongestCommonPrefix_0(string[] stringArray)
    {
        string answer = string.Empty;
        if (stringArray.Length == 0)
            return answer;
        if (stringArray[0].Length == 0)
            return answer;
        char firstChar = stringArray[0].ToCharArray()[0];
        foreach (var ch in stringArray[0])
        {
            if (answer == string.Empty)
            {
                if (stringArray.All(x => x.StartsWith(ch)))
                    answer += ch;
                else return answer;
            }
            else
            {
                if (stringArray.All(x => x.StartsWith($"{answer}{ch}")))
                    answer += ch;
                else return answer;
            }
        }
        return answer;
    }
    //without linq
    public static string LongestCommonPrefix_1(string[] strs)
    {
        string answer = string.Empty;
        if (strs.Length == 0)
            return answer;
        if (strs[0].Length == 0)
            return answer;

        foreach (var ch in strs[0])
        {
            if (answer == string.Empty)
            {
                foreach (var str in strs)
                {
                    if (str.StartsWith(ch))
                        continue;
                    else return answer;
                }
                answer += ch;
            }
            else
            {
                var match = $"{answer}{ch}";
                foreach (var str in strs)
                {
                    if (str.StartsWith(match))
                        continue;
                    else return answer;
                }
                answer = match;
            }
        }
        return answer;
    }
    //provided
    public static string LongestCommonPrefix_2(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        //get the whole first word
        string prefix = strs[0];
        //loop through the other words one at a time
        for (int i = 1; i < strs.Length; i++)
            //while the prefix is not the same as the first word
            while (strs[i].IndexOf(prefix) != 0)
            {
                //remove the last letter from the prefix
                //and try again
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix == "")
                    return "";
            }

        return prefix;
    }
    //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    public static bool ValidParentheses_0(string s)
    {
        if(s.Length == 0)
            return false;
        Stack<char> chars = new();
        for (int i = 0; i < s.Length; i++)
        {
            var current = s[i];
            var next = i == s.Length - 1 ? ' ' : s[i + 1];

            switch (current)
            {
                case '(':
                    if (next == ')')
                        i++;
                    else 
                        chars.Push(current);
                    break;
                case '{':
                    if (next == '}')
                        i++;
                    else 
                        chars.Push(current);
                    break;
                case '[':
                    if (next == ']')
                        i++;
                    else 
                        chars.Push(current);
                    break;
                case ')':
                    if(chars.Count == 0 || chars.Peek() != '(')
                        return false;
                    else 
                        chars.Pop();
                    break;
                case ']':
                    if(chars.Count == 0 || chars.Peek() != '[')
                        return false;
                    else 
                        chars.Pop();
                    break;
                case '}':
                    if(chars.Count == 0 || chars.Peek() != '{')
                        return false;
                    else 
                        chars.Pop();
                    break;
            }
        }
        return chars.Count == 0;
    }
    //Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
    public static int RemoveDuplicates_0(int[] nums) {
        return nums.Distinct().Count();
    }
    public static int RemoveDuplicates_1(int[] nums) {
        return nums.Distinct().Count();
    }

}
