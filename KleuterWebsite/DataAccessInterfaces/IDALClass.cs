using System;
using System.Collections.Generic;

namespace DataAccessInterfaces
{
    public interface IDALClass
    {
        List<DtoCommand> GetCommands();
        DtoStatus GetStatus();

        void UpdateCommand(DtoCommand dtocommand);
        //string GetUsage();
    }
}
