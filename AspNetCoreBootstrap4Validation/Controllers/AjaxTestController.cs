using Microsoft.AspNetCore.Mvc;
using AspNetCoreBootstrap4Validation.ViewModels;

namespace AspNetCoreBootstrap4Validation.Controllers
{
    public class AjaxTestController : Controller
    {
        public IActionResult Index()
        {
            return View(new AjaxValidationModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AjaxValidationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Redirect("AjaxTest/Index");
        }
    }
}
