using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Areas.Test.Controllers;

[Area("Test")]
public class TestController : Controller
{
    public IActionResult Test1()
    {
        return View();
    }

    public IActionResult Test2()
    {
        return View();
    }

    public IActionResult Test3()
    {
        return View();
    }

    public IActionResult Test4()
    {
        return View();
    }
}
