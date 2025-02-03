using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DataAccessLayer.Context;
using BlogForest.DataAccessLayer.Repositories;
using BlogForest.DtoLayer.CategoryDtos;
using BlogForest.EntityLayer.Concrete;

namespace BlogForest.DataAccessLayer.EntityFramework;

public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    
{
    public EfCategoryDal(BlogContext context) : base(context)
    {
        
    }

    public List<ResultCategoryWithCountDto> GetCategoryWithCount()
    {
        var context=new BlogContext();
        var categoryBlogCount = context.Categories.Select(c => new ResultCategoryWithCountDto
        {
            CategoryName = c.CategoryName,
            CategoryCount = c.Blogs.Count,
        }).ToList();
        return categoryBlogCount;
    }
} 

