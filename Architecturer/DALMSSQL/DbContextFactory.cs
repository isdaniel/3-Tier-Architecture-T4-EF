using DI;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DALMSSQL
{
    public partial class DbContextFactory
    {
        /// <summary>
        /// 創建EF對象,已存在就直接取,不存在就創建。
        /// </summary>
        public static DbContext Create()
        {
            DbContext dbContext = CallContext.GetData(typeof(DbContextFactory).Name) as DbContext;
            if (dbContext == null)
            {
                dbContext = new Model.Conn();
                CallContext.SetData(typeof(DbContextFactory).Name, dbContext);
            }
            return dbContext;
        }
    }
}
