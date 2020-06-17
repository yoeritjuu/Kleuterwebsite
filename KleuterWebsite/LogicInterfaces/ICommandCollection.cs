using DataAccessInterfaces;
using KleuterLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicInterfaces
{
    public interface ICommandCollection
    { 
        List<DtoCommand> GetCommands();
        void Update(ICommand model);
        void AddCommand(ICommand command);
        void DeleteCommand(int id);
        DtoStatus GetStatus();
    }
}
