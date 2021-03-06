﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALMSSQL
{
    /// <summary>
    /// 提供一個DAL父類 有基本CURD
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseDAL<T> : IDAL.IBaseDAL<T> where T : class, new()
    {
        private DbContext dbContext = DbContextFactory.Create();
        public void Create(T model)
        {
            dbContext.Set<T>().Add(model);
            dbContext.SaveChanges();
        }

        public void Delete(T model)
        {
            dbContext.Set<T>().AddOrUpdate(model);
            dbContext.SaveChanges();
        }

        public IQueryable<T> GetList()
        {
            return dbContext.Set<T>().Select(o=>o);         
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public void UpdateById(T model)
        {
            dbContext.Set<T>().AddOrUpdate(model);
            dbContext.SaveChanges();
        }
    }
}
