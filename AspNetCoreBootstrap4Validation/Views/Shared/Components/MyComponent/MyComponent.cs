using AspNetCoreBootstrap4Validation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationTool.Views.Simulation.SimulationMinirail
{
    public class MyComponent : ViewComponent
    {
        public MyComponent() {}

        public IViewComponentResult Invoke(MyComponentModel model)
        {
            model.ScreenWidth = "Read on the server:" + model.ScreenWidth;
            return View(model);
        }
    }
}
