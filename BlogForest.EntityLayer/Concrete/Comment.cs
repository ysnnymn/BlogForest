﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string NameSurname { get; set; }
        public string Detail { get; set; }
        public DateTime CommentDate { get; set; }
        public bool Status { get; set; }
        public int BlogId { get; set; }
        public List<Blog> Blogs { get; set; }
        public string CommentImageUrl { get; set; }

    }
}
