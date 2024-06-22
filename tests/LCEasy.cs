using static LeetCode.Easy;

namespace LCEasy
{
    public class LeetCodeTests
    {
        [Fact]
        public void TwoSum_Test()
        {
            int[] exp = [0,1];
            int[] actual = TwoSum([2,7,11,15], 9);
            Assert.Equal(exp, actual);
        }
    }
}