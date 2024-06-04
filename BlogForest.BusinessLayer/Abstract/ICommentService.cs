using BlogForest.DtoLayer.CommentDtos;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
      public  List<ResultCommentDto> GetCommentListByBlogId(int id);
    }
}
