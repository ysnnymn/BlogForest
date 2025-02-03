using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers;
[Authorize]
public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}