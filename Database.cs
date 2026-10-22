using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Trial1KayPro
{
    internal class Database
    {
        // Configure through environment variables instead of hard-coding a server:
        //   KAYPRO_DB_SERVER, KAYPRO_DB_USER, KAYPRO_DB_PASSWORD, KAYPRO_DB_NAME
        static readonly string server = Environment.GetEnvironmentVariable("KAYPRO_DB_SERVER") ?? "localhost";
        static readonly string user = Environment.GetEnvironmentVariable("KAYPRO_DB_USER") ?? "root";
        static readonly string password = Environment.GetEnvironmentVariable("KAYPRO_DB_PASSWORD") ?? "";
        static readonly string database = Environment.GetEnvironmentVariable("KAYPRO_DB_NAME") ?? "kaypro";
        static string connection_string = "server='" + server + "'; user='" + user + "'; database='" + database + "'; password='"+password+"'";
        public MySqlConnection mySqlConnection = new MySqlConnection(connection_string);
        public bool connect_db()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool close_db()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public int ExecuteNonQuery(string sql, Dictionary<string, object> parameters)
        {
            using (MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection))
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
