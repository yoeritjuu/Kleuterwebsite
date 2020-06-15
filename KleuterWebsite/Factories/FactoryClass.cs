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
        //logica aanmaken
        public static ICommandCollection GetCommandProcess()
        {
            //maak hier de DAL aan en geef mee
            IExecuteQuerys dal = new ExecuteQuerys();
            return new CommandCollection(dal);
        }
    }
}
