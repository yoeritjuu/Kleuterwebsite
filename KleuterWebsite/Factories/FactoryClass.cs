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
        public static IConvertData GetConvertData()
        {
            //maak hier de DAL aan en geef mee
            IExecuteQuerys e = new ExecuteQuerys();
            return new ConvertData(e);
        }
    }
}
