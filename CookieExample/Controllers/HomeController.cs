using CookieExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookieExample.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            var model = new Account();
            //CookieCheck.CookieDelete("username");
            if (CookieCheck.CookieGet("username") != null)
            {
                model.Username = CookieCheck.CookieGet("username").Value;



            }
            else
            {
            }




            return View("Login", model);



        }
        private string CheckLoginCookie()
        {
            if (Request.Cookies.Get("username") != null)
            {
                return Request.Cookies["username"].Value;
            }
            return string.Empty;
        }
        [HttpPost]
        public ActionResult Login(Account account)

        {

            if (account.RememberMe)
            {
                CookieCheck.CookieCreate("username", account.Username);

            }



            return View();
        }


    }
}