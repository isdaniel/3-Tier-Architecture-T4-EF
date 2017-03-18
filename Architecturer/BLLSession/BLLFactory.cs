using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Common;
using System.Reflection;

namespace ServiceRepository
{
    public class BLLFactory : IBLL.IBLLFactory
    {
        public IBLLSession GetBLLSession()
        {
            string DalFactory = ConfigHelper.GetConfig("BllFactory");
            string AssemblyName = ConfigHelper.GetConfig("BllAssemblyName");
            string ClassName = AssemblyName + "." + DalFactory;
            return Assembly.Load(AssemblyName).CreateInstance(ClassName) as IBLLSession;
        }
    }
}
