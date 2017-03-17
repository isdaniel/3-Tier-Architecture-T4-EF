using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_A
{
    public abstract class BaseBLL<T> : IBaseDAL<T> 
        where T : class, new()
    {
        protected IDAL.IBaseDAL<T> dal = null;
        public BaseBLL()
        {
            SetDAL();
        }
        /// <summary>
        /// 和IDALBase溝通
        /// </summary>
        public IDBSession dbSession = null;
        public abstract void SetDAL();
        public void Create(T model) {
            dal.Create(model);
        }

        public void Delete(T Id) {
             dal.Create(Id);
        }

        public IQueryable<T> GetList() {
            return dal.GetList();
        }

        public void UpdateById(T Id) {
            dal.UpdateById(Id);
        }

        public int SaveChanges()
        {

           return dal.SaveChanges();
        }
    }
}
