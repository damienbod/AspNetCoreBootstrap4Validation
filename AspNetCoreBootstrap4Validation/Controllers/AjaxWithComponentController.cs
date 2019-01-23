using Microsoft.AspNetCore.Mvc;
using AspNetCoreBootstrap4Validation.ViewModels;

namespace AspNetCoreBootstrap4Validation.Controllers
{
    public class AjaxWithComponentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimulationMinirail(MyComponentModel model)
        {
            return ViewComponent("MyComponent", model);
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

        public IActionResult Playground()
        {
            return View();
        }
    }
}
