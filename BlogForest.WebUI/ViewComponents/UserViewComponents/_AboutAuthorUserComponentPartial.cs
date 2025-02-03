using BlogForest.BusinessLayer.Abstract;
using BlogForest.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.UserViewComponents;

public class _AboutAuthorUserComponentPartial:ViewComponent
{
    private readonly IAppUserService  _appUserService;

    public _AboutAuthorUserComponentPartial(IAppUserService appUserService)
    {
        _appUserService = appUserService;
    }


    public IViewComponentResult Invoke(int id)
    {
        var value = _appUserService.TGetAppUserDetail(id);
        return View(value);
    }
}