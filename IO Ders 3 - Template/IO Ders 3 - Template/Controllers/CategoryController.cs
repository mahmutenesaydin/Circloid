using IO_Ders_3___Template;
using IO_Ders_3___Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IO_Ders_3___Template.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        NorthwindEntiti model = new NorthwindEntiti();
        public ActionResult Index()
        {
            List<Category> ctg = model.Categories.ToList();
            return View(ctg);
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category ctg)
        {
            model.Categories.Add(ctg);
            model.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public void DeleteCategory(int id)
        {
            Category k = model.Categories.FirstOrDefault(c => c.CategoryID == id);
            model.Categories.Remove(k);
            model.SaveChanges();
        }
    }
}