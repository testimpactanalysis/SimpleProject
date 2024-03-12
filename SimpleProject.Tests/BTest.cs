namespace SimpleProject.Tests;

public class BTest
{
    [Fact]
    public void BarTest()
    {
        B b = new B();
        Assert.Equal(2, b.Bar());
    }
}