using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}