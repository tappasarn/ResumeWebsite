namespace ResumeWebsite.Models.MainViewModels
{
    public interface IPersonalInfo
    {
        string DisplayIcon {get; set;}
        string FullName {get; set;}
        int Age{get; set;}
        string Focus {get; set;}
        string ImgSrc {get; set;}
    }
}