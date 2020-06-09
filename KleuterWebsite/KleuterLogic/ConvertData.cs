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

        public ConvertData(IExecuteQuerys executequerys)
        {
            ExecuteQuerys = executequerys;
        }

        public void PutInArray()
        {
            string info = ExecuteQuerys.GetCommands();
            string[] words = info.Split(',');

            foreach (var word in words)
            {
                Trace.WriteLine(word);
            }

        }

    }
}
