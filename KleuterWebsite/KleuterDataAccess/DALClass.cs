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
    public class DALClass : IDALClass
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
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw new ApplicationException("connection failed");
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
                try
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
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }

        public DtoStatus GetStatus()
        {
            DtoStatus dtostatus = null;
            string sql = "SELECT `status` from kleuterbot";
            try
            {
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception(e.Message);
            }
        }

        public void UpdateCommand(DtoCommand dtocommand)
        {
            string sql =
                "UPDATE `commands` " +
                "SET `name`= @name,`usage`= @usage,`description`= @description " +
                "WHERE `id` = @id";
            using (MySqlConnection conn = Sqlconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@id", dtocommand.Id);
                        command.Parameters.AddWithValue("@name", dtocommand.Name);
                        command.Parameters.AddWithValue("@usage", dtocommand.Usage);
                        command.Parameters.AddWithValue("@description", dtocommand.Description);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }

        /// <summary>
        /// executes an 'insert into' query on to database
        /// </summary>
        /// <param name="dtocommand"></param>
        public void AddCommand(DtoCommand dtocommand)
        {
            string sql = "INSERT INTO `commands` (`name`, `usage`, `description`) " +
                         "VALUES (@name, @usage, @description)";
            using (MySqlConnection conn = Sqlconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@name", dtocommand.Name);
                        command.Parameters.AddWithValue("@usage", dtocommand.Usage);
                        command.Parameters.AddWithValue("@description", dtocommand.Description);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }

        /// <summary>
        /// executes a 'insert into' query on to database
        /// </summary>
        public void DeleteCommand(int id)
        {
            string sql = "DELETE FROM `commands` WHERE `commands`.`id` = @Id";
            using (MySqlConnection conn = Sqlconnection())
            {
                try
                {
                    using (MySqlCommand command = new MySqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw new Exception(e.Message);
                }
            }
        }
    }
}
