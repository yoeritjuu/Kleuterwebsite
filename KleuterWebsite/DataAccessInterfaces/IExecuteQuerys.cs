using System;
using System.Collections.Generic;

namespace DataAccessInterfaces
{
    public interface IExecuteQuerys
    {
        List<DtoCommand> GetCommands();
        DtoStatus GetStatus();
        //string GetUsage();
    }
}
