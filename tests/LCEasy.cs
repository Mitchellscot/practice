using static LeetCode.Easy;

namespace LCEasy
{
    public class LeetCodeTests
    {
        [Theory]
        [InlineData(new int[]{2,7,11,15}, 9, new int[]{0,1})]
        [InlineData(new int[]{3,2,4}, 6, new int[]{1,2})]
        [InlineData(new int[]{3,3}, 6, new int[]{0,1})]
        [InlineData(new int[]{3,2,3}, 6, new int[]{0,2})]
        [InlineData(new int[]{1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1}, 11, new int[]{5,11})]
        public void TwoSum_Test_0(int[] arg1, int arg2, int[] expected)
        {
            Assert.Equal(expected, TwoSum_0(arg1, arg2));

        }
        [Theory]
        [InlineData(new int[]{2,7,11,15}, 9, new int[]{0,1})]
        [InlineData(new int[]{3,2,4}, 6, new int[]{1,2})]
        [InlineData(new int[]{3,3}, 6, new int[]{0,1})]
        [InlineData(new int[]{3,2,3}, 6, new int[]{0,2})]
        [InlineData(new int[]{1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1}, 11, new int[]{5,11})]
        public void TwoSum_Test_1(int[] arg1, int arg2, int[] expected)
        {
            Assert.Equal(expected, TwoSum_1(arg1, arg2));
        }
        // *** //
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(-101, false)]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(11, true)]
        [InlineData(111, true)]
        [InlineData(1111, true)]
        public void IsPalindrome_Test_0(int num, bool expected)
        {
            var ans = IsPalindrome_0(num);
            Assert.Equal(expected, ans);
        }
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(-101, false)]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(11, true)]
        [InlineData(111, true)]
        [InlineData(1111, true)]
        public void IsPalindrome_Test_1(int num, bool expected)
        {
            var ans = IsPalindrome_1(num);
            Assert.Equal(expected, ans);
        }
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("DCXXI", 621)]
        public void RomanToInt_Test_0(string numeral, int expected)
        {
            var ans = RomanToInt_0(numeral);
            Assert.Equal(expected, ans);
        }
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("DCXXI", 621)]
        public void RomanToInt_Test_1(string numeral, int expected)
        {
            var ans = RomanToInt_1(numeral);
            Assert.Equal(expected, ans);
        }
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("DCXXI", 621)]
        public void RomanToInt_Test_2(string numeral, int expected)
        {
            var ans = RomanToInt_1(numeral);
            Assert.Equal(expected, ans);
        }
        [Theory]
        [InlineData(new string[] {"flower","flow","flight"}, "fl")]
        [InlineData(new string[] {"dog","racecar","car"}, "")]
        public void LongestCommonPrefix_Test_0(string[] strs, string expected)
        {
            var ans = LongestCommonPrefix_0(strs);
            Assert.Equal(expected, ans);
        }
        [Theory]
        [InlineData(new string[] {"flower","flow","flight"}, "fl")]
        [InlineData(new string[] {"dog","racecar","car"}, "")]
        public void LongestCommonPrefix_Test_1(string[] strs, string expected)
        {
            var ans = LongestCommonPrefix_1(strs);
            Assert.Equal(expected, ans);
        }
        [Theory]
        [InlineData(new string[] {"flower","flow","flight"}, "fl")]
        [InlineData(new string[] {"dog","racecar","car"}, "")]
        public void LongestCommonPrefix_Test_2(string[] strs, string expected)
        {
            var ans = LongestCommonPrefix_2(strs);
            Assert.Equal(expected, ans);
        }
        [Theory]
        // [InlineData("()", true)]
        // [InlineData("()[]{}", true)]
        // [InlineData("(]", false)]
        // [InlineData("([)]", false)]
        // [InlineData("{[]}", true)]
        // [InlineData("]", false)]
        // [InlineData("((", false)]
        [InlineData("(){}}{", false)]
        public void ValidParentheses_Test_0(string s, bool expected)
        {
            var ans = ValidParentheses_0(s);
            Assert.Equal(expected, ans);
        }

    }
}