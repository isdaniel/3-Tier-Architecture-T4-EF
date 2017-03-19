using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALFakeData
{
    public class FakeBaseDAL<T> : IDAL.IBaseDAL<T> where T : class, new()
    {
        IList<T> dataList = new List<T>();
        public void Create(T model)
        {
            dataList.Add(model);
        }

        public void Delete(T model)
        {
            dataList.Remove(model);
        }

        public IQueryable<T> GetList()
        {
            return dataList.AsQueryable();
        }

        public void UpdateById(T model)
        {
            
        }
    }
}
