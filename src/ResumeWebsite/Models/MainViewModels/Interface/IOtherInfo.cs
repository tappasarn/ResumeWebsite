using System.Collections.Generic;

namespace ResumeWebsite.Models.MainViewModels
{
    public interface IOtherInfo
    {
         List<string> Header {get; set;}
         List<string> Info {get; set;}
         string DisplayIcon {get; set;}
         string Topic {get; set;}
    }
}