﻿using BlogForest.BusinessLayer.Abstract;
using BlogForest.DataAccessLayer.Abstract;
using BlogForest.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogForest.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TGetBlogsByAppUser(int id)
        {
            return _blogDal.GetBlogsByAppUser(id);
        }

        public List<Blog> TGetBlogsWithCategoryandUser()
        {
            return _blogDal.GetBlogsWithCategoryandUser();
        }

        public Blog TGetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> TGetLast2BlogByAppUser(int id)
        {
            return _blogDal.GetLast2BlogByAppUser(id);
        }

        public List<Blog> TGetListAll()
        {
          return  _blogDal.GetListAll();
        }

        public void TInsert(Blog entity)
        {
            _blogDal.Insert(entity);
        }

        public void TUpdate(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
