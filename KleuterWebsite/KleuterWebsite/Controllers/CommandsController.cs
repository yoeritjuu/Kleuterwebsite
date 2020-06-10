using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessInterfaces;
using Factories;
using KleuterWebsite.Models;
using LogicInterfaces;

namespace KleuterWebsite.Controllers
{
    public class CommandsController : Controller
    {
        // GET: Commands
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListCommands()
        {
            List<List<string>> CommandList = FactoryClass.GetConvertData().PutInList();

            List<CommandModel> Commands;

            for (int i = 0; i < 3; i++)
            {
                Commands = new CommandModel { Id = Convert.ToInt32(CommandList[0][0]), Name = CommandList[0][1], Usage = Convert.ToInt32(CommandList[0][2]) };
            }
            return View(Commands);
        }
    }
}