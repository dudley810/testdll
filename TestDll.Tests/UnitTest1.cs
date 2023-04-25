namespace TestDll.Tests;

public class UnitTest1 : IClassFixture<TestFactory<Program>>
{
    readonly TestClass tc;
    readonly HttpClient c;

    public UnitTest1(TestFactory<Program> f)
    {
        this.tc = (TestClass)f.Services.GetService(typeof(TestClass));
        this.c = f.CreateClient();
    }

    [Fact]
    public void Test1()
    { 
        int answer = this.tc.MyMethod(10, 10);
        Assert.Equal(20, answer);
    }

    [Fact]
    public async Task Test2()
    {
        string x = await c.GetStringAsync("test/gettc?n1=15&n2=30");
        Assert.Equal("45", x);
    }

}
