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
        public static IExecuteQuerys GetExecuteQuery()
        {
            return new ExecuteQuerys();
        }

        public static IConvertData GetConvertData()
        {
            return new ConvertData();
        }
    }
}
