using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using DataAccessInterfaces;
using LogicInterfaces;

namespace KleuterLogic
{
    public class CommandCollection : ICommandCollection
    {
        private readonly IDALClass _dalClass;

        public CommandCollection(IDALClass executequerys)
        {
            _dalClass = executequerys;
        }

        public List<DtoCommand> GetCommands()
        {
            List<DtoCommand> commandlist = _dalClass.GetCommands();
            return commandlist;
        }

        public void Update(ICommand model)
        {
            DtoCommand DALobj = new DtoCommand()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Usage = model.Usage
            };
            _dalClass.UpdateCommand(DALobj);
        }

        public void AddCommand(ICommand model)
        {
            DtoCommand DALobj = new DtoCommand()
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Usage = model.Usage
            };
            _dalClass.AddCommand(DALobj);
        }

        public void DeleteCommand(int id)
        {
            _dalClass.DeleteCommand(id);
        }

        public DtoStatus GetStatus()
        {
            DtoStatus status = _dalClass.GetStatus();
            return status;
        }
    }
}
