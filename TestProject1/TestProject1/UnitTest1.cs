namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(6 + 6 == 12);
    }

    [Fact]
    public void Test2() {
        Assert.Equals(true, false);
        Assert.True(false);
    }
}
