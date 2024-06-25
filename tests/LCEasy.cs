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
        public void TwoSum_Test_0(int[] arg1, int arg2, int[] expected)
        {
            Assert.Equal(expected, TwoSum_0(arg1, arg2));

        }
        [Theory]
        [InlineData(new int[]{2,7,11,15}, 9, new int[]{0,1})]
        [InlineData(new int[]{3,2,4}, 6, new int[]{1,2})]
        [InlineData(new int[]{3,3}, 6, new int[]{0,1})]
        [InlineData(new int[]{3,2,3}, 6, new int[]{0,2})]
        public void TwoSum_Test_1(int[] arg1, int arg2, int[] expected)
        {
            Assert.Equal(expected, TwoSum_1(arg1, arg2));
        }
    }
}