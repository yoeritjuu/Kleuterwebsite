using System;
using System.Collections.Generic;
using System.Text;
using DataAccessInterfaces;

namespace LogicInterfaces
{
    public interface ICommand
    {
        int Id { get; set; }
        string Name { get; set; }
        int Usage { get; set; }
        string Description { get; set; }
        void UpdateCommand(int id, string name, string description, int usage);

    }
}
