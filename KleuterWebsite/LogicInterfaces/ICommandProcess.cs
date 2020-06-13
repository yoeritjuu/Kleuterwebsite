using DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInterfaces
{
    public interface ICommandProcess
    { 
        List<DtoCommand> LoadCommands();
        DtoStatus GetStatus();
    }
}
