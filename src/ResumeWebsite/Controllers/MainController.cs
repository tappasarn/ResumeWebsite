using Microsoft.AspNetCore.Mvc;
using ResumeWebsite.Services.Builders;

namespace ResumeWebsite.Controllers
{
    public class MainController : Controller
    {
        public IActionResult index(){
            var mainControllerViewModelBuilder = new MainControllerViewModelBuilder();
            
            var mainControllerViewModel = mainControllerViewModelBuilder.Build();

            return View(mainControllerViewModel);
        }
    }
}