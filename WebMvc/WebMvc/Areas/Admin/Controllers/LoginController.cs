using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMvc.Areas.Admin.Code;
using WebMvc.Areas.Admin.Models;

namespace WebMvc.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Admin/Login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModels model)
        {
            //var result = new DB_AccountModels().Login(model.Username, model.Password);
            if (Membership.ValidateUser(model.Username, model.Password) && ModelState.IsValid)
            {
                //SessionHelper.SetSession( new UserSession(){UserName=model.Username});
                FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("","User name or password is invaild");
            }
            return View(model);
        }

        //Test comment
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}
