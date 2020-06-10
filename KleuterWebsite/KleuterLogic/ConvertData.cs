using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

        public List<List<string>> PutInList()
        {
            List<List<string>> rows = new List<List<string>>();
            string info = ExecuteQuerys.GetCommands();

            string[] words = info.Split(';');
            foreach (var row in words)
            {
               rows.Add(MakeRow(row));
            }
            return rows;
        }

        public List<string> MakeRow(string row)
        {
            string[] words = row.Split(',');
            return words.ToList<string>();
        }
    }
}
