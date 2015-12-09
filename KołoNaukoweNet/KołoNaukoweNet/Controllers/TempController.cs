using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KołoNaukoweNet.Controllers
{
    [RoutePrefix("PanelLogowania")]

    public class TempController : Controller
    {
        [Route("start")] 
        // GET: Temp 
        public ActionResult Index()
        {
            return Content("siemanko");
        }

        public ActionResult GetParameters(string input)
        {
            return Content(input);
        }
    }
}