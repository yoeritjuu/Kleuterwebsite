using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DataAccessInterfaces;
using MySql.Data.MySqlClient;

namespace KleuterDataAccess
{
    public class ExecuteQuerys : IExecuteQuerys
    {
        public string command;
        private string usage;
        private readonly string connectionstring = "Server=studmysql01.fhict.local;Uid=dbi433553;Database=dbi433553;Pwd=yourPassword;";

        /// <summary>
        /// Establishes connection to database.
        /// </summary>
        /// <returns></returns>
        public MySqlConnection Sqlconnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            return connection;
        }

        /// <summary>
        /// Gets commands from db.
        /// </summary>
        public string GetCommands()
        {
            using (MySqlConnection conn = Sqlconnection())
            {
                string sql = "SELECT * from commands";
                using (MySqlCommand query = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            command = $"{reader.GetInt32(0)} {reader.GetString(1)}  {reader.GetInt32(2)}";
                        }

                        return command;
                    }
                }
            }
        }

        public string GetUsage()
        {
            using (MySqlConnection conn = Sqlconnection())
            {
                string sql = "SELECT * from command_usage";
                using (MySqlCommand query = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usage = reader.GetInt32(0) + reader.GetInt32(1) + reader.GetInt32(2).ToString();
                        }

                        return usage;
                    }
                }
            }
        }
    }
}
