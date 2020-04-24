using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KleuterWebsite.Models
{
    public class CommandModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Owner { get; set; }
        public int Usage { get; set; }

    }
}