using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DataAccessLayer.Context;
using BlogForest.DataAccessLayer.Repositories;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccessLayer.EntityFramework
{
    public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
    {
        public EfAppUserDal(BlogContext context) : base(context)
        {
        }

        public AppUser GetAppUserDetail(int id)
        {
            var context = new BlogContext();
            var value = context.Blogs.Where(x => x.BlogId == id).Select(y => y.AppUser).FirstOrDefault();
            return value;
        }
    }
}
