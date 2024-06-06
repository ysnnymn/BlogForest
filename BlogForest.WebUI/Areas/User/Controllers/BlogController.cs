using AutoMapper;
using BlogForest.BusinessLayer.Abstract;
using BlogForest.DtoLayer.BlogDtos;
using BlogForest.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Areas.User.Controllers
{
    [Area("User")]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogController(UserManager<AppUser> userManager, IBlogService blogService, IMapper mapper)
        {
            _userManager = userManager;
            _blogService = blogService;
            _mapper = mapper;
        }

        public async Task< IActionResult> MyBlogList()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            var blogList = _blogService.TGetBlogsByAppUser(value.Id);
            return View(blogList);
        }
        [HttpGet]
        public IActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult> CreateBlog(CreateBlogDto createBlogDto)
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            createBlogDto.AppUserId = value.Id;
            createBlogDto.CreatedDate = DateTime.Now;
            createBlogDto.ViewCount = 0;
         var blogValues=   _mapper.Map<Blog>(createBlogDto);
            _blogService.TInsert(blogValues);

            return RedirectToAction("Index","Default");
        }
    }
}
