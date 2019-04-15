using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApiVersioningSwaggerDemo.Controllers
{
    /// <summary>
    /// Home Controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index view page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Swagger Redirect.
        /// </summary>
        /// <returns></returns>
        public ActionResult Swagger() =>
            Redirect("~/swagger/ui/index");
    }
}
