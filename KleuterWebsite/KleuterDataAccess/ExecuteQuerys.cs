using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Net;
using System.Text;
using DataAccessInterfaces;
using MySql.Data.MySqlClient;

namespace KleuterDataAccess
{
    public class ExecuteQuerys : IExecuteQuerys
    {
        private readonly string connectionstring =
            "Server=studmysql01.fhict.local;Uid=dbi433553;Database=dbi433553;Pwd=1qazxsw2;";

        /// <summary>
        /// Establishes connection to database.
        /// </summary>
        /// <returns></returns>
        public MySqlConnection Sqlconnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionstring);
                connection.Open();
                return connection;
            }
            catch (Exception e)
            {
                Trace.WriteLine(e);
                return null;
            }

        }

        /// <summary>
        /// Gets commands table from db.
        /// </summary>
        public List<DtoCommand> GetCommands()
        {
            List<DtoCommand> objList = new List<DtoCommand>();
            DtoCommand dtoCommand;
            string sql = "SELECT `id`, `name`, `usage`, `description` from commands";
            using (MySqlConnection conn = Sqlconnection())
            {
                using (MySqlCommand query = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = query.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dtoCommand = new DtoCommand()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Usage = reader.GetInt32(2),
                                Description = reader.GetString(3)
                            };

                            objList.Add(dtoCommand);
                        }

                        return objList;
                    }
                }
            }
        }

        public DtoStatus GetStatus()
        {
            DtoStatus dtostatus = null;
            string sql = "SELECT `status` from kleuterbot";
            using (MySqlConnection conn = Sqlconnection())
            {
                using (MySqlCommand command = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dtostatus = new DtoStatus()
                            {
                                Status = reader.GetString(0)
                            };
                        }
                        return dtostatus;
                    }

                }

            }
        }
        //public string GetUsage()
        //{
        //    using (MySqlConnection conn = Sqlconnection())
        //    {
        //        string sql = "SELECT `command_id`, `user_id`, `amount_used` from command_usage";
        //        using (MySqlCommand query = new MySqlCommand(sql, conn))
        //        {
        //            using (MySqlDataReader reader = query.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {

        //                }

        //                return null;
        //            }
        //        }
        //    }
        //}
    }
}
