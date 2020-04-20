using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using KleuterWebsite.Models;

namespace KleuterWebsite.Controllers
{
    public class KleuterBotController : Controller
    {
        // GET: KleuterBot
        public ActionResult Stats()
        {
            var command = new Command() {Name = "8Ball"};

            return View(command);
        }
    }
}