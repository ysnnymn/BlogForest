using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DataAccessLayer.Context;
using BlogForest.DataAccessLayer.Repositories;
using BlogForest.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogForest.DataAccessLayer.EntityFramework;

public class EfBlogDal:GenericRepository<Blog>,IBlogDal
{
    public EfBlogDal(BlogContext context) : base(context)
    {
        
    }

    public List<Blog> GetBlogsWithCategoryAndUser()
    {
        var context=new BlogContext();
        var values=context.Blogs.Include(x=>x.Category).Include(y=>y.AppUser).ToList();
        return values;
    }

    public List<Blog> GetLast2BlogByAppUser(int id)
    {
var context=new BlogContext();
int appUserID=context.Blogs.Where(x=>x.BlogId==id).Select(y=>y.AppUserId).FirstOrDefault();
var values=context.Blogs.Where(x=>x.AppUserId==appUserID).OrderByDescending(x=>x.BlogId).Take(2).ToList();
return values;
    }
    public List<Blog> GetRecentPosts()
    {
        using (var context = new BlogContext())
        {
            var recentPosts = context.Blogs
                .OrderByDescending(blog => blog.CreatedDate)  // En yeni yazılar en üstte
                .Take(3)  // Son 3 yazıyı getirir
                .Include(blog => blog.Category)  // İlişkili veriler, örneğin kategori bilgisi
                .Include(blog => blog.AppUser)     // İlişkili veriler, örneğin yazar bilgisi
                .ToList();

            return recentPosts;
        }
    }

    public List<Blog> GetBlogssByAppUser(int id)
    {
        var context=new BlogContext();
        var values=context.Blogs.Where(x=>x.AppUserId==id).Include(y=>y.Category).ToList();
        return values;
    }

    public void IncreaseBlogViewCount(int id)
    {
        var context=new BlogContext();
        var value=context.Blogs.Where(x=>x.BlogId==id).FirstOrDefault();
        value.ViewCount++;
        context.Blogs.Update(value);
        context.SaveChanges();
    }
}