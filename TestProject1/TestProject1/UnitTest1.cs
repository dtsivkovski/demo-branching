namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(2 + 2 == 4);
    }

    [Fact]
    public void AssertFalse()
    {
        Assert.False(false);
    }
    
    
}