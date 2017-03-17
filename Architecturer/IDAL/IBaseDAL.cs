using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    /// <summary>
    /// 提供基本的CRUD方法，讓各個DAL子類實現
    /// </summary>
    public interface IBaseDAL<T> where T:class,new ()
    {

        //1.0新增 CURD方法
        IQueryable<T> GetList();
        void Create(T model);
        void UpdateById(T model);
        void Delete(T model);

        int SaveChanges();
    }
}
