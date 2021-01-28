using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IO_Ders_3___Template.Controllers
{
    using App_Classes;
    using System.Web.Security;

    [Authorize]
    public class MemberController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Kullanici k, string Remember)
        {
            bool result = Membership.ValidateUser(k.UserName,k.Password);
            if (result)
            {
                if (Remember == "on")
                    FormsAuthentication.RedirectFromLoginPage(k.UserName, true);
                else
                    FormsAuthentication.RedirectFromLoginPage(k.UserName, false);

                return RedirectToAction("Index","Home");
            }
            else
            {
                ViewBag.Message = "Kullanıcı Adı veya Parola Hatalı!";
                return View();
            }
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult ForgotMyPassword()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult ForgotMyPassword(Kullanici k)
        {
            MembershipUser mu = Membership.GetUser(k.UserName);
            if (mu.PasswordQuestion == k.SecretQuestion)
            {
                string pwd = mu.ResetPassword(k.SecretAnswer);
                mu.ChangePassword(pwd, k.Password);
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Message = "Girilen Bilgiler Hatalı!";
                return View();
            }
        }
    }
}