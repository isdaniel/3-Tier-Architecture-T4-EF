using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    /// <summary>
    /// 提供基本的CRUD方法，讓各個BLL子類實現
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseBLL<T>
    {
        //定義方法
        void Create(T model);

        void Delete(T Id);
        
        IQueryable<T> GetList();

        void UpdateById(T Id);
        int SaveChanges();
    }
}
