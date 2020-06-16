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

        public Command(IDALClass dalClass, int id, string name, int usage, string description)
        {
            _dalClass = dalClass;
            this.Id = id;
            this.Name = name;
            this.Usage = usage;
            this.Description = description;
        }

        private int Id { get; }

        private string Name { get; }

        private int Usage { get; }

        private string Description { get; }

        // scherm props af en set ze in de constructor. zorg dat je begrijpt waarom je iets doet.
        // zorg dat alles een reden heeft en je t kan uitleggen.
        public void UpdateCommand()
        {
            DtoCommand command = new DtoCommand()
            {
                Id = this.Id,
                Name = this.Name,
                Description = this.Description,
                Usage = this.Usage
            };
            _dalClass.UpdateCommand(command);
        }

    }
}
