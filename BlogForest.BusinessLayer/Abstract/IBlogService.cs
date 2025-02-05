using BlogForest.EntityLayer.Concrete;

namespace BlogForest.BusinessLayer.Abstract;

public interface IBlogService:IGenericService<Blog>
{
   public List<Blog> TGetBlogsWithCategoryAndUser();
   List<Blog> TGetLast2BlogByAppUser(int id);
  public List<Blog> TGetRecentPosts();
  List<Blog> TGetBlogssByAppUser(int id);
  public void TIncreaseBlogViewCount(int id);


}