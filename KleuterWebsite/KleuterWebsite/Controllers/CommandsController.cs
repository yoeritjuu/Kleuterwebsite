using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KleuterWebsite.Models;

namespace KleuterWebsite.Controllers
{
    public class CommandsController : Controller
    {
        /*SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:MySQLiteDB.s3db");
        conn.Open();

        SQLiteCommand cmd = new SQLiteCommand(conn);
        cmd.CommandText = "select * from Customer";

        SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read( ))
        {
            // do something
        }
        reader.Close( );

        cmd.CommandText = "delete from Customer where CustomerID = 33";
        cmd.ExecuteScalar( );

        conn.Close( );
        */


        // GET: Commands
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListCommands()
        {
            List<CommandModel> Commands = new List<CommandModel>();

            Commands.Add();

            return View();
        } 
    }
}