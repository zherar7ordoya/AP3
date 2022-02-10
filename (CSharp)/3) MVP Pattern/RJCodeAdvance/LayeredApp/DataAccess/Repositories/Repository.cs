﻿using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public abstract class Repository
    {
        private readonly string connectionString;
        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["connMyCompany"].ToString();
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
