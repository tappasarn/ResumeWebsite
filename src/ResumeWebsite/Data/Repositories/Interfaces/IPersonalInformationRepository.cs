using System;

namespace ResumeWebsite.Data.Repositories.Interfaces
{
    public interface IPersonalInformationRepository
    {
        string DisplayIcon {get;}
        string FirstName {get;}
        string LastName {get;}
        int YearOfBirth {get;}
        int MonthOfBirth {get;}
        int DateOfBirth {get;}
        string[] Interest {get;}
        string ImgSrc {get;}
    }
}