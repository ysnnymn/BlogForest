using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.DtoLayer.CommentDtos
{
    public class ResultCommentDto
    {
        public int CommentId { get; set; }
        public string NameSurname { get; set; }
        public string Detail { get; set; }
        public DateTime CommentDate { get; set; }
        public bool Status { get; set; }
        public int BlogId { get; set; }
        public int CommentCount { get; set; }
        public string CommentImageUrl { get; set; }
    }
}
