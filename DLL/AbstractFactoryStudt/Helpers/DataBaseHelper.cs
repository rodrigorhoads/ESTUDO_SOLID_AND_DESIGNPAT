using AbstractFactoryStudt.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace AbstractFactoryStudt.Helpers
{
    public class DataBaseHelper
    {

        public IDataBaseFactory dataBaseFactory;

        public DataBaseHelper(IDataBaseFactory pDataBaseFactory)
        {
            dataBaseFactory = pDataBaseFactory;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DbDataReader ExecuteSelect(string query)
        {
            DbConnection dbConnection = dataBaseFactory.GetConnection();
            dbConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            DbCommand command = dataBaseFactory.GetCommand();
            command.Connection = dbConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            dbConnection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DbDataReader ExecuteSelect(string query, DbParameter[] parameters)
        {
            DbConnection dbConnection = dataBaseFactory.GetConnection();
            dbConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            DbCommand command = dataBaseFactory.GetCommand();
            command.Connection = dbConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Parameters.AddRange(parameters);
            dbConnection.Open();
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int ExecuteAction(string query)
        {
            DbConnection dbConnection = dataBaseFactory.GetConnection();
            dbConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            DbCommand command = dataBaseFactory.GetCommand();
            command.Connection = dbConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;            
            dbConnection.Open();
            int ret = command.ExecuteNonQuery();
            dbConnection.Close();
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public int ExecuteAction(string query, DbParameter[] parameters)
        {
            DbConnection dbConnection = dataBaseFactory.GetConnection();
            dbConnection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            DbCommand command = dataBaseFactory.GetCommand();
            command.Connection = dbConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Parameters.AddRange(parameters);
            dbConnection.Open();
            int ret = command.ExecuteNonQuery();
            dbConnection.Close();
            return ret;
        }
    }
}