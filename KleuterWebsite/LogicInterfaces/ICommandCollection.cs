using DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInterfaces
{
    public interface ICommandCollection
    { 
        List<DtoCommand> LoadCommands();
        DtoStatus GetStatus();
    }
}
