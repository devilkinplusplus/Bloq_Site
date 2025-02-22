﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer.Concreate;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetBlogsWithCategoryByWriter(int id);
        List<Blog> GetBlogsWithCategory();
        List<Blog> GetBlogByIdWithCategory(int id);
        List<Blog> GetOtherBlogsByWriter(int id);
    }
}
