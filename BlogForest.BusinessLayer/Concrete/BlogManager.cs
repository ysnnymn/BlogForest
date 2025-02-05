using BlogForest.BusinessLayer.Abstract;
using BlogForest.DataAccessLayer.Abstract;
using BlogForest.EntityLayer.Concrete;

namespace BlogForest.BusinessLayer.Concrete;

public class BlogManager:IBlogService
{
    private readonly IBlogDal _blogDal;

    public BlogManager(IBlogDal blogDal)
    {
        _blogDal = blogDal;
    }

    public void TInsert(Blog entity)
    {
        _blogDal.Insert(entity);
    }

    public void TUpdate(Blog entity)
    {
        _blogDal.Update(entity);
    }

    public void TDelete(int id)
    {
        _blogDal.Delete(id);
    }

    public Blog TGetById(int id)
    {
        return _blogDal.GetById(id);
    }

    public List<Blog> TGetListAll()
    {
        return _blogDal.GetListAll();
    }

    public List<Blog> TGetBlogsWithCategoryAndUser()
    {
        return _blogDal.GetBlogsWithCategoryAndUser();
    }

    public List<Blog> TGetLast2BlogByAppUser(int id)
    {
        return _blogDal.GetLast2BlogByAppUser(id);
    }

    public List<Blog> TGetRecentPosts()
    {
       return _blogDal.GetRecentPosts();
    }

    public List<Blog> TGetBlogssByAppUser(int id)
    {
        return _blogDal.GetBlogssByAppUser(id);
    }

    public void TIncreaseBlogViewCount(int id)
    {
        _blogDal.IncreaseBlogViewCount(id);
    }
}