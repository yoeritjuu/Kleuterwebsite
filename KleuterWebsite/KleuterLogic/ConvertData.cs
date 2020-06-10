using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DataAccessInterfaces;
using LogicInterfaces;

namespace KleuterLogic
{
    public class ConvertData : IConvertData
    {
        private readonly IExecuteQuerys ExecuteQuerys;
        private readonly List<string> command = new List<string>();

        public ConvertData(IExecuteQuerys executequerys)
        {
            ExecuteQuerys = executequerys;
        }

        public List<string> PutInList()
        {
            string info = ExecuteQuerys.GetCommands();
            string[] words = info.Split(',');

            foreach (var word in words)
            {
                command.Add(word);
            }

            return command;
        }

    }
}
