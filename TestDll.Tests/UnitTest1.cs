namespace TestDll.Tests;

public class UnitTest1 : IClassFixture<Program>
{
    readonly TestClass tc;
    public UnitTest1(TestClass pobj)
    {
        this.tc = pobj;
    }

    [Fact]
    public void Test1()
    { 
        int answer = this.tc.MyMethod(10, 10);
        Assert.Equal(20, answer);

    }
}
