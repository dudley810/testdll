using TestDIDll;

namespace TestDll;
public class TestClass
{
    readonly MyDIClass obj;
    public TestClass(MyDIClass pobj)
    {
        this.obj = pobj;
        Console.Write(this.MyMethod(10,10));
    }
    public int MyMethod(int n1, int n2)
    {
        return this.obj.DoAdd(n1,n2);
    }
}