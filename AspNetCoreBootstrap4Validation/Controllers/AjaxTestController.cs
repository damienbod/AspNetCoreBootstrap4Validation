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
                return PartialView("_partialAjaxForm", model);
            }

            // the client could validate this, but allowed for testing server errors
            if(model.Name.Length < 3)
            {
                ModelState.AddModelError("name", "Name should be longer than 2 chars");
                return PartialView("_partialAjaxForm", model);
            }

            ModelState.Clear();
            return PartialView("_partialAjaxForm");
        }
    }
}
