using System;
using System.Collections.Generic;
using System.Text;
using DataAccessInterfaces;
using KleuterDataAccess;
using LogicInterfaces;
using KleuterLogic;

namespace Factories
{
    public static class FactoryClass
    {
        public static ICommandCollection GetCommandCollection()
        {
            //maak hier de DAL aan en geef mee
            IDALClass dal = new DALClass();
            return new CommandCollection(dal);
        }

        public static ICommand GetCommand()
        {
            IDALClass dal = new DALClass();
            return new Command(dal);
        }
    }
}
