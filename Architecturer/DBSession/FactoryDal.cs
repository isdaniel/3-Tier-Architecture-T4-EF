using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Common;
using System.Reflection;

namespace DALRepository
{
    public class FactoryDal : IDAL.IFactoryDal
    {

        /// <summary>
        /// 利用抽象工廠模式返回實作的DbSession
        /// 可任意切換要使用的資料庫
        /// </summary>
        /// <returns></returns>
        public IDBSession GetDbSession()
        {
            string DalFactory=ConfigHelper.GetConfig("DalFactory");
            string AssemblyName = ConfigHelper.GetConfig("DalAssemblyName");
            string ClassName = AssemblyName + "."+DalFactory;
            return Assembly.Load(AssemblyName).CreateInstance(ClassName) as IDBSession;
        }
    }
}
