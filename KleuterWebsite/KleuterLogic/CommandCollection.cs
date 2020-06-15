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
        private readonly IExecuteQuerys _executeQuerys;

        public CommandCollection(IExecuteQuerys executequerys)
        {
            _executeQuerys = executequerys;
        }

        public List<DtoCommand> GetCommands()
        {
            List<DtoCommand> commandlist = _executeQuerys.GetCommands();
            return commandlist;
        }

        public DtoCommand AddCommand()
        {
            return null;
        }

        public DtoCommand DeleteCommand()
        {
            return null;
        }

        public DtoStatus GetStatus()
        {
            DtoStatus status = _executeQuerys.GetStatus();
            return status;
        }
    }
}
