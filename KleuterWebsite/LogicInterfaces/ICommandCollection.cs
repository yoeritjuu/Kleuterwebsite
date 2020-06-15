using DataAccessInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInterfaces
{
    public interface ICommandCollection
    { 
        List<DtoCommand> GetCommands();
        DtoCommand AddCommand();
        DtoCommand DeleteCommand();
        DtoStatus GetStatus();

    }
}
