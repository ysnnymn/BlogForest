using BlogForest.DtoLayer.CommentDtos;
using BlogForest.EntityLayer.Concrete;

namespace BlogForest.DataAccessLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        List<ResultCommentDto> GetCommentListByBlogId(int id);
    }
}
