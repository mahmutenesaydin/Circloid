using IO_Ders_3___Template.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IO_Ders_3___Template.Controllers
{
    [Authorize]
    public class KullaniciController : Controller
    {

        public ActionResult Index()
        {
            MembershipUserCollection users = Membership.GetAllUsers();
            return View(users);
        }

        [AllowAnonymous]
        public ActionResult AddUser()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult AddUser(Kullanici k)
        {
            MembershipCreateStatus durum;
            Membership.CreateUser(k.UserName, k.Password, k.Email, k.SecretQuestion, k.SecretAnswer, true, out durum);
            string message = "";
            switch (durum)
            {
                case MembershipCreateStatus.Success:
                    break;
                case MembershipCreateStatus.InvalidUserName:
                    message += "Geçersiz kullanıcı adı";
                    break;
                case MembershipCreateStatus.InvalidPassword:
                    message += "Geçersiz parola";
                    break;
                case MembershipCreateStatus.InvalidQuestion:
                    message += "Geçersiz Gizli soru";
                    break;
                case MembershipCreateStatus.InvalidAnswer:
                    break;
                case MembershipCreateStatus.InvalidEmail:
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    message += "Kullanılmış kullanıcı adı";
                    break;
                case MembershipCreateStatus.DuplicateEmail:
                    message += "Bu mail adresini başkası kullanıyor.";
                    break;
                case MembershipCreateStatus.UserRejected:
                    message += "Kullanıcı engel hatası";
                    break;
                case MembershipCreateStatus.InvalidProviderUserKey:
                    message += "Geçersiz Kullanıcı key hatası";
                    break;
                case MembershipCreateStatus.DuplicateProviderUserKey:
                    message += "Kullanılmıiş key hatası";
                    break;
                case MembershipCreateStatus.ProviderError:
                    message += "Üye Yönetimi Sağlayıcı hatası";
                    break;
                default:
                    break;
            }

            ViewBag.Message = message;
            if (durum == MembershipCreateStatus.Success)
                return RedirectToAction("Index");
            else
                return View();
        }

        [Authorize(Roles = "Admin")]    //[Authorize(Users="admin")]  admin adındaki kullanıcı(lar) rol atayabilir
        public ActionResult AssignRole()
        {
            ViewBag.Roles = Roles.GetAllRoles().ToList();
            ViewBag.Users = Membership.GetAllUsers();
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult AssignRole(string UserName, string RoleName)
        {
            Roles.AddUserToRole(UserName, RoleName);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public string UserRoles(string userName)
        {
            List<string> roles = Roles.GetRolesForUser(userName).ToList();
            string role = "";
            foreach (string r in roles)
            {
                role += r + "-";
            }
            role = role.Remove(role.Length - 1, 1);
            return role;
        }
    }
}