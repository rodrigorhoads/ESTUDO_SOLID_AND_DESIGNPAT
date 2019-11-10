using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace AbstractFactoryStudt.Core
{
    public class OleDbFactory : IDataBaseFactory
    {
        public DbCommand GetCommand()
        {
            return new OleDbCommand();
        }

        public DbConnection GetConnection()
        {
            return new OleDbConnection();
        }

        public DbParameter GetParameter()
        {
            return new OleDbParameter();
        }
    }
}