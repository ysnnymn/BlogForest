using BlogForest.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Controllers;

public class BlogController : Controller
{
    private readonly  IBlogService _blogService;

    public BlogController(IBlogService blogService)
    {
        _blogService = blogService;
    }


    public IActionResult BlogDetail(int id)
    {
        _blogService.TIncreaseBlogViewCount(id) ;
        ViewBag.i = id;
        return View();
    }
}