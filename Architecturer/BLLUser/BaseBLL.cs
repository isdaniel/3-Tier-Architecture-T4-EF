using DALRepository;
using IDAL;
using System.Linq;

namespace Service_A
{
    /// <summary>
    /// 提供一個BLL Base有基本CURD功能
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseBLL<T> : IBaseDAL<T>
        where T : class, new()
    {
        protected IBaseDAL<T> dal = null;
        public BaseBLL()
        {
            SetDAL();
        }
        /// <summary>
        /// 和IDALBase溝通
        /// </summary>
        private IDBProvider dbProvider = null;

        protected IDBProvider DBProvider
        {
            get {
                if (dbProvider == null)
                {
                    dbProvider = new FactoryDal().GetDbProvider();
                }
                return dbProvider;
            }
            set {
                dbProvider = value;
            }
        }
        public virtual void SetDAL() { }
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
    }
}
