using BlogForest.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.CategoryViewComponents
{
    public class _PopularCategoryComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _PopularCategoryComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _categoryService.TGetCategoryWithCount();
            return View(value);
        }
    }
}
