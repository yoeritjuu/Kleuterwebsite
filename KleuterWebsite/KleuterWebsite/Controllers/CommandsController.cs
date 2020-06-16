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
        private readonly ICommandCollection _commandCollection = FactoryClass.GetCommandCollection();

        public ActionResult Commands()
        {
            List<CommandModel> commands = new List<CommandModel>();
            var data = _commandCollection.GetCommands();
            DtoStatus dtoStatus = _commandCollection.GetStatus();
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

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null) return (HttpNotFound());
            List<CommandModel> commands = new List<CommandModel>();
            var cmd = _commandCollection.GetCommands().Where(s => s.Id == id);
            foreach (var row in cmd)
            {
                commands.Add(new CommandModel
                {
                    Id = row.Id,
                    Name = row.Name,
                    Usage = row.Usage,
                    Description = row.Description
                });
            }

            return View(commands[0]);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CommandModel cModel)
        {
            ICommand command = FactoryClass.GetCommand(cModel.Id, cModel.Name, cModel.Usage, cModel.Description);
            command.UpdateCommand();

            return RedirectToAction("Commands");
        }
    }
}