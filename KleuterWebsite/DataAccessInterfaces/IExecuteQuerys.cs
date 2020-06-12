using System;
using System.Collections.Generic;

namespace DataAccessInterfaces
{
    public interface IExecuteQuerys
    {
        List<DtoCommand> GetCommands();
        string GetUsage();
    }
}
