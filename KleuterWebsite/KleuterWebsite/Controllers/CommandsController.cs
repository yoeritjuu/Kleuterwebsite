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
            List<string> CommandList = FactoryClass.GetConvertData().PutInList();

            List<CommandModel> Commands = new List<CommandModel>
            {
                new CommandModel { Id = Convert.ToInt32(CommandList[0]), Name = CommandList[1], Usage = Convert.ToInt32(CommandList[2])},
                new CommandModel { Id = 23, Name = "random", Usage = 55 },
                new CommandModel { Id = 33, Name = "random", Usage = 33 },
            };
            
            return View(Commands);
        }
    }
}