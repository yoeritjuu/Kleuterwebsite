using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using KleuterWebsite.Models;

namespace KleuterWebsite.Controllers
{
    public class KleuterBotController : Controller
    {
        // GET: Command/Stats
        public ActionResult Stats()
        {
            var command = new Command(1, "8Ball");

            return View(command);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // commands
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}