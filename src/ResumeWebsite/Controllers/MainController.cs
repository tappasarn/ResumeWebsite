using Microsoft.AspNetCore.Mvc;
using ResumeWebsite.Models.MainViewModels;

namespace ResumeWebsite.Controllers
{
    public class MainController : Controller
    {
        public IActionResult index(){
            var myInformationViewModel = new PersonalInformationViewModel();
            myInformationViewModel.FirstName = "Tappasarn";
            myInformationViewModel.LastName = "Aramboonpong";
            myInformationViewModel.FullName = myInformationViewModel.FirstName + " " + myInformationViewModel.LastName;
            myInformationViewModel.Age = 24;
            myInformationViewModel.Address = "31 Onnut 17 (yak 5) Sukumvit 77 Rd. Suanluang District Bangkok 10250";

            return View(myInformationViewModel);
        }
    }
}