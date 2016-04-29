using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServerSite1.Models.Pages;
using EPiServerSite1.Models.Repositories;

namespace EPiServerSite1.Controllers
{
    public class AdminController : PageController<AdminPage>
    {
        public StudentContext studentContext { get; set; }
        public ActionResult Index(AdminPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}