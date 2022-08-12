﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class BlogManager:GenericManager<Blog>,IBlogService
    {
        IBlogDal _blogDal;
        public BlogManager(IGenericDal<Blog> genericDal) : base(genericDal)
        {
            _blogDal = (IBlogDal)genericDal;
        }

        public List<Blog> GetBlogsWithCategoryByWriter(int id)
        {
            return _blogDal.GetBlogsWithCategoryByWriter(id);
        }
    }
}
