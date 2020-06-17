using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DataAccessInterfaces;

namespace KleuterLogic
{
    public class Command : LogicInterfaces.ICommand
    {
        private readonly IDALClass _dalClass;

        public Command(IDALClass dalClass)
        {
            _dalClass = dalClass;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Usage { get; set; }

        public string Description { get; set; }

        
    }
}
