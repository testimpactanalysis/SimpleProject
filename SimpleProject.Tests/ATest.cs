namespace SimpleProject.Tests;

public class ATest
{
    [Fact]
    public void FooTest()
    {
        A a = new A();
        Assert.Equal(1, a.Foo());
    }
}