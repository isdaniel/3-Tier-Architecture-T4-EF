using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace DI
{
    /// <summary>
    /// autofac容器
    /// </summary>
    /// <typeparam name="T1">介面</typeparam>
    /// <typeparam name="T2">實現介面之類別</typeparam>
    public class AutoFactoryHelper<T1,T2>
    {
        /// <summary>
        /// IOC 容器
        /// </summary>
        private static IContainer container = null;

        /// <summary>
        /// 取得IDAL對象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T1 Resolve()
        {
            try
            {
                if (container == null)
                {
                    Initialise();
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("IOC出错!" + ex.Message);
            }

            return container.Resolve<T1>();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Initialise()
        {
            var builder = new ContainerBuilder();
            //格式：builder.RegisterType<xxxx>().As<Ixxxx>().InstancePerLifetimeScope();
            //Active_RecordDal實現IActive_RecordDal介面
            builder.RegisterType<T1>().As<T2>().InstancePerLifetimeScope();
            container = builder.Build();
        }
    }
}
