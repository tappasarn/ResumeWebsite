using System.Collections.Generic;

namespace ResumeWebsite.Models.MainViewModels.Interface
{
    public interface IMainControllerViewModel
    {
         IPersonalInfo PersonalInfo {get; set;}
         List<IOtherInfo> OtherInfo {get; set;}
    }
}