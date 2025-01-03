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
}