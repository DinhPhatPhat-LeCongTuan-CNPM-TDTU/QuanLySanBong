using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    internal class Connection
    {
        private static SqlConnection connection;
      
        public static void Connect() {
            string connectionString = @"Data Source=DESKTOP-70D2O9A;Initial Catalog=QuanLySanBong;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static void actionQuery(string sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string sql)
        {
            Connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
