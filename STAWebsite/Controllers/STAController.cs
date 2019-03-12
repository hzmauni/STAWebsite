using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STAWebsite.Controllers
{
    public class STAController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int numTimes =1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", your student ID is: " + numTimes);
        }
    }
}