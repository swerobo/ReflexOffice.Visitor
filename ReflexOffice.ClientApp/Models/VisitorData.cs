using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;
using ReflexOffice.Shared.Models;

namespace ReflexOffic.App.Models
{
    public class VisitorData
    {
        public List<Visitor> GetAll(int total = 2)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            using (IDbConnection connection = new MySqlConnection(ConnectionString))
            {
                string sql = $"Select * from visitor LIMIT " + total;
                var output = connection.Query<Visitor>(sql).ToList();
                return output;
            }
        }
    }
}