using AutoMapper;
using BlogForest.BusinessLayer.Abstract;
using BlogForest.BusinessLayer.Concrete;
using BlogForest.DtoLayer.BlogDtos;
using BlogForest.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.Areas.User.Controllers;

[Area("User")]
public class BlogController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IBlogService _blogService;
    private readonly IMapper _mapper;

    public BlogController(UserManager<AppUser> userManager, IBlogService blogService, IMapper mapper)
    {
        _blogService = blogService;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task< IActionResult> MyBlogList()
    {
        var values=await _userManager.FindByNameAsync(User.Identity.Name);
        var blogList=_blogService.TGetBlogssByAppUser(values.Id);
        return View(blogList);
    }

    [HttpGet]
    public IActionResult CreateBlog()
    {
        return View();
    }

    [HttpPost]
    public  async Task<IActionResult> CreateBlog(CreateBlogDto createBlogDto)
    {
        var values=await _userManager.FindByNameAsync(User.Identity.Name);

        createBlogDto.AppUserId = values.Id;
        createBlogDto.CreatedDate = DateTime.Now;
        createBlogDto.ViewCount = 0;
        var blogvalues=_mapper.Map<Blog>(createBlogDto);
        _blogService.TInsert(blogvalues);
        return RedirectToAction("Index","Default");
     
    }

    public   IActionResult DeleteBlog(int id)
    {
        var values = _blogService.TGetById(id);
        _blogService.TDelete(values.BlogId);
        
        return RedirectToAction("MyBlogList", "Blog", new { area = "User" });

    }

    [HttpGet]
    public IActionResult UpdateBlog(int id)
    {
        var values = _blogService.TGetById(id);
        var blogdto=_mapper.Map<UpdateBlogDto>(values);
        return View(blogdto);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateBlog(UpdateBlogDto updateBlogDto)
    {
        var value=await _userManager.FindByNameAsync(User.Identity.Name);
        updateBlogDto.AppUserId = value.Id;
        updateBlogDto.CreatedDate = DateTime.Now;
        updateBlogDto.ViewCount = 0;
        var values=_mapper.Map<Blog>(updateBlogDto);
        _blogService.TUpdate(values);
        return RedirectToAction("Index","Default");

    }
}