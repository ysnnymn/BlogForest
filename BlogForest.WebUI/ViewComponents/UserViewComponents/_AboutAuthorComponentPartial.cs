using BlogForest.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.UserViewComponents
{
    public class _AboutAuthorComponentPartial:ViewComponent
    {
        private readonly IAppUserService _appUserService;

        public _AboutAuthorComponentPartial(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _appUserService.TGetAppUserDetail(id);
            return View(value);
        }
    }
}
