using BlogForest.EntityLayer.Concrete;

namespace BlogForest.DataAccessLayer.Abstract;

public interface IBlogDal:IGenericDal<Blog>
{
    List<Blog> GetBlogsWithCategoryAndUser();
    List<Blog> GetLast2BlogByAppUser(int id);
    List<Blog> GetRecentPosts();
 

}