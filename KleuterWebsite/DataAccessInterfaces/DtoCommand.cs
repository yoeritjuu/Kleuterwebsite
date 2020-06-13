using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessInterfaces
{
    public class DtoCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Usage { get; set; }
        public string Description { get; set; }
    }
}
