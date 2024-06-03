using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DataAccessLayer.Context;
using BlogForest.DataAccessLayer.Repositories;
using BlogForest.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccessLayer.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
       
        public EfBlogDal(BlogContext context) : base(context)
        {
        }

        public List<Blog> GetBlogsWithCategoryandUser()
        {
            var context = new BlogContext();
            var values = context.Blogs.Include(x => x.Category).Include(y => y.AppUser).ToList();
            return values;
        }

        public List<Blog> GetLast2BlogByAppUser(int id)
        {
            var context = new BlogContext();
            int appUserID = context.Blogs.Where(x => x.BlogId == id).Select(y => y.AppUserId).FirstOrDefault();
            var values = context.Blogs.Where(x => x.AppUserId == appUserID).OrderByDescending(y => y.BlogId).Take(2).ToList();
            return values;
        }
    }
}
