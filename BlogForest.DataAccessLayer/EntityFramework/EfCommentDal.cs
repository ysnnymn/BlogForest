using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DataAccessLayer.Context;
using BlogForest.DataAccessLayer.Repositories;
using BlogForest.DtoLayer.CommentDtos;
using BlogForest.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(BlogContext context) : base(context)
        {
        }


        public List<ResultCommentDto> GetCommentListByBlogId(int id)
        {
            var context = new BlogContext();

            var value = context.Comments.Where(y => y.BlogId == id).Select(x => new ResultCommentDto
            {

                CommentId = x.CommentId,
                BlogId = x.BlogId,
                CommentDate = x.CommentDate,
                CommentImageUrl = x.CommentImageUrl,
                Detail = x.Detail,
                NameSurname = x.NameSurname,
                Status = x.Status,
                CommentCount = context.Comments.Count(c => c.BlogId == id)


            }).ToList();
            return value;
        }


    }
}
