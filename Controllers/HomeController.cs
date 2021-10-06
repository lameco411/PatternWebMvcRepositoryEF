using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models.Class;

namespace WebApp.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            app.Category.Add(obj);
            return Redirect("/category");
        }
        public IActionResult Edit(int id)
        {
            return View(app.Category.GetCategoryById(id));
        }
        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            app.Category.Edit(obj);
            return Redirect("/category");
        }
        public IActionResult Delete(int id)
        {
            app.Category.Delete(id);
            return Redirect("/category");
        }
    }
}
