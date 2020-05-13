using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using ReflexOffice.Shared.Models;

namespace ReflexOffice.Database.Models
{
    public class VisitorData
    {
        public async Task<List<Visitor>> GetAll()
        {
            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("Database")))
            {
                var output = await connection.QueryAsync<Visitor>($"Select * from visitor");
                return output.ToList();
            }
        }

        public Task Update(Visitor item)
        {
            string enddate = String.Format("{0:yyyy-MM-dd}", item.End_Date);
            string startdate = String.Format("{0:yyyy-MM-dd}", item.Start_Date);
            string creationdate = String.Format("{0:yyyy-MM-dd}", item.Created_Date);
            string updated = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
            string sql = $"UPDATE visitor set description='{item.Description}',first_name='{item.first_name}', last_name='{item.last_name}', " +
                         $"assigned_to='{item.Assigned_To}',end_date = '{enddate}', module_id={item.Module_Id},Id='{item.Id}'," +
                         $"start_date='{startdate}',updated_date='{updated}',comment='{item.Comment}', alarm={item.Alarm}, rfid='{item.rfid}'," +
                         $" completed={item.Completed}, category_id='{item.Category_Id}', image='{item.Image}' where visitor_id={item.Id}";

            using (IDbConnection connection = new MySqlConnection(Helper.CnnVal("Database")))
            {
                var output = connection.QueryAsync<Visitor>(sql);
                return output;
            }
        }
    }
}