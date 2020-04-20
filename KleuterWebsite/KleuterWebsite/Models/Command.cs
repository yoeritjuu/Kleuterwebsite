using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KleuterWebsite.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Command(int id, string Name)
        {
            this.Id = id; 
            this.Name = Name;
        }

    }
}