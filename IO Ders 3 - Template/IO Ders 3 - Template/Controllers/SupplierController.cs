using IO_Ders_3___Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IO_Ders_3___Template.Controllers
{
    public class SupplierController : Controller
    {
        // GET: Supplier
        // NorthwindContext db = new NorthwindContext();
        NorthwindEntiti db = new NorthwindEntiti();
        public ActionResult Index()
        {
            List<Supplier> sup = db.Suppliers.ToList();
            return View(sup);
        }

        [HttpPost]
        public string Delete(int id)
        {
            Supplier sup = db.Suppliers.SingleOrDefault(s => s.SupplierID == id);
            db.Suppliers.Remove(sup);
            try
            {
                db.SaveChanges();
                return "başarılı";
            }
            catch (Exception)
            {
                return "hata";
            }
        }
    }
}