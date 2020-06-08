using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using DataAccessInterfaces;

namespace KleuterDataAccess
{
    class ExecuteQuerys : IExecuteQuerys
    {
        
        private string[] Command;
        private readonly string Connectionstring = "Server=studmysql01.fhict.local;Uid=dbi433553;Database=dbi433553;Pwd=yourPassword;";

        public void Sqlconnection()
        {

        }

        public void GetCommands()
        {

        }

        public void GetUsage()
        {

        }
    }
}
