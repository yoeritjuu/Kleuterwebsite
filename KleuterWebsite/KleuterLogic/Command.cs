using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DataAccessInterfaces;

namespace KleuterLogic
{
    class Command : LogicInterfaces.ICommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Usage { get; set; }
        public string Description { get; set; }

        public DtoCommand UpdateCommand()
        {
            
        }
    }
}
