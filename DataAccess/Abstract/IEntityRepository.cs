﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        //List<T> GetByBrandId(Expression<Func<T,bool>> filter=null);

        T GetById(Expression<Func<T,bool>> filter);

        //List<T> GetByColorId(Expression<Func<T, bool>> filter=null);
    }
}
