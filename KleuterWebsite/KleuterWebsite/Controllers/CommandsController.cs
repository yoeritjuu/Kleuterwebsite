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
            FactoryClass.GetConvertData().PutInArray();
            
            List<CommandModel> Commands = new List<CommandModel>
            {
                new CommandModel { Id = 1, Name = "8ball", Owner = 1, Usage = 2 },
                new CommandModel { Id = 2, Name = "ping", Owner = 0, Usage = 5 },
                new CommandModel { Id = 3, Name = "help", Owner = 0, Usage = 3 },
            };
            
            return View(Commands);
        }
    }
}