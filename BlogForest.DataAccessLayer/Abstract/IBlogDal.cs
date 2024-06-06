using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetBlogsWithCategoryandUser();
        List<Blog> GetLast2BlogByAppUser(int id);
        List<Blog> GetBlogsByAppUser(int id);
    }
}
