using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {        
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
                Test = "Test ValVal."
            });
        }
        [HttpPost]
        public ActionResult Login(AuthLogin formData)
        {
            if (!ModelState.IsValid)
            {
                if (formData.userName != "Mahmut")
                {
                    ModelState.AddModelError("userName", "Username must be 'Mahmut'");
                }
                return View(formData);
            }
            if(formData.userName != "Mahmut")
            {
                ModelState.AddModelError("userName","Username must be 'Mahmut'");
                return View(formData);
            }
            formData.Test = "Second ValVal.";
            return Content("This form is valid.");
        }
    }
}