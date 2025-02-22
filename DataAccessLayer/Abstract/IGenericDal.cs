﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        List<T> GetListAll();
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        T GetById(int id);

        //For Linq overload GetLisAll
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}
