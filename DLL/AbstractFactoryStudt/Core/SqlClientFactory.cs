using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AbstractFactoryStudt.Core
{
    public class SqlClientFactory : IDataBaseFactory
    {
        public DbCommand GetCommand()
        {
            return new SqlCommand();
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection();
        }

        public DbParameter GetParameter()
        {
            return new SqlParameter();
        }
    }
}