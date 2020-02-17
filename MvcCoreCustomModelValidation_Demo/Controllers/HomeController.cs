using Microsoft.AspNetCore.Mvc;
using MvcCoreCustomModelValidation_Demo.Models;

namespace MvcCoreCustomModelValidation_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult New(Student student)
        {
            if (ModelState.IsValid)
            {
                RedirectToAction("Index");
            }
            return View();
        }
    }
}
