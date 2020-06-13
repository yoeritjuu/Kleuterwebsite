using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DataAccessInterfaces;
using Factories;
using KleuterWebsite.Models;
using LogicInterfaces;

namespace KleuterWebsite.Controllers
{
    public class CommandsController : Controller
    {
        private readonly ICommandProcess _commandProcess = FactoryClass.GetCommandProcess();
        // GET: Commands
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListCommands()
        {
            List<CommandModel> commands = new List<CommandModel>();
            var data = _commandProcess.LoadCommands();
            DtoStatus dtoStatus = _commandProcess.GetStatus();
            StatusModel statusObject = new StatusModel()
            {
                Status = dtoStatus.Status
            };
            ViewBag.Status = statusObject.Status;

            foreach (var row in data)
            {
                commands.Add(new CommandModel
                {
                    Id = row.Id,
                    Name = row.Name,
                    Usage = row.Usage,
                    Description = row.Description
                });
            }

            return View(commands);
        }
    }
}