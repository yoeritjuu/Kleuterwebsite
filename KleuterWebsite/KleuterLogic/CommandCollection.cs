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
        private readonly IExecuteQuerys ExecuteQuerys;

        public CommandCollection(IExecuteQuerys executequerys)
        {
            ExecuteQuerys = executequerys;
        }

        public List<DtoCommand> LoadCommands()
        {
            List<DtoCommand> commandlist = ExecuteQuerys.GetCommands();
            return commandlist;
        }

        public DtoStatus GetStatus()
        {
            DtoStatus status = ExecuteQuerys.GetStatus();
            return status;
        }
    }
}
