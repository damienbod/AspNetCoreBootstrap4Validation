using Microsoft.AspNetCore.Mvc;
using AspNetCoreBootstrap4Validation.ViewModels;

namespace AspNetCoreBootstrap4Validation.Controllers
{
    public class RemoteTestController : Controller
    {
        public IActionResult Index()
        {
            return View(new RemoteValidationModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(RemoteValidationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return Redirect("RemoteTest/Index");
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyNameAndAge(string name, int age)
        {
            if (age > 50)
            {
                return Json(data: $" {name} {age} must be less than 50.");
            }

            return Json(data: true);
        }
    }
}
