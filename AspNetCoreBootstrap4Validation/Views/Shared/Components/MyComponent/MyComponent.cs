using AspNetCoreBootstrap4Validation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EvaluationTool.Views.Simulation.SimulationMinirail
{
    public class MyComponent : ViewComponent
    {
        public MyComponent() {}

        public IViewComponentResult Invoke(MyComponentModel model)
        {
            return View(model);
        }
    }
}
