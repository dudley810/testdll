using Microsoft.AspNetCore.Mvc;
using TestDll;

namespace TestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    readonly TestClass tc;
    public TestController(TestClass pobj)
    {
        this.tc = pobj;
    }

    [HttpGet(Name = "GetTC")]
    public ActionResult Get(int n1,int n2)
    {
        return Ok(tc.MyMethod(n1, n2));
    }
}

