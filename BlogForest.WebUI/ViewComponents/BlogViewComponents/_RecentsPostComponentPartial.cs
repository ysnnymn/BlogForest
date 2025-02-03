using BlogForest.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.BlogViewComponents;

public class _RecentsPostComponentPartial:ViewComponent
{
    private readonly IBlogService _blogService;

    public _RecentsPostComponentPartial(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public  IViewComponentResult Invoke()
    {
        var values =  _blogService.TGetRecentPosts();
        return View(values);
        
    }
}