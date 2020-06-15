using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DataAccessInterfaces;

namespace KleuterLogic
{
    public class Command : LogicInterfaces.ICommand
    {
        private readonly IExecuteQuerys _executeQuerys;

        public Command(IExecuteQuerys executequerys)
        {
            _executeQuerys = executequerys;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Usage { get; set; }

        public string Description { get; set; }


        public void UpdateCommand(int id, string name, string description, int usage)
        {
            DtoCommand command = new DtoCommand()
            {
                Id = id,
                Name = name,
                Description = description,
                Usage = usage
            };
            _executeQuerys.UpdateCommand(command);
        }

    }
}
