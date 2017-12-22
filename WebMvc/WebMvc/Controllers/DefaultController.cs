using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMvc.Common;

namespace WebMvc.Controllers
{
    
    public class DefaultController : Controller
    {
        [TrackExecutionTime]
        public string Index()
        {
            return "Index action invoked";
        }

        public string Welcome()
        {
            throw new Exception("Exception Occured");
        }

        public ActionResult About()
        {
            
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

    }
}
