﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concreate;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetBlogsWithCategoryByWriter(int id);
        List<Blog> GetBlogsWithCategory();
        List<Blog> GetBlogByIdWithCategory(int id);
        List<Blog> GetOtherBlogsByWriter(int id);
    }
}
