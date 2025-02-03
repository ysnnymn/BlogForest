using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DataAccessLayer.Context;
using BlogForest.DataAccessLayer.Repositories;
using BlogForest.EntityLayer.Concrete;

namespace BlogForest.DataAccessLayer.EntityFramework;

public class EfCommentDal:GenericRepository<Comment>,ICommentDal
{
    public EfCommentDal(BlogContext context) : base(context)
    {
    }
}