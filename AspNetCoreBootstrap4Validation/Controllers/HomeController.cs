using Microsoft.AspNetCore.Mvc;
using AspNetCoreBootstrap4Validation.ViewModels;

namespace AspNetCoreBootstrap4Validation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(StandardValidationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Redirect("Home/Index");
        }
    }
}
