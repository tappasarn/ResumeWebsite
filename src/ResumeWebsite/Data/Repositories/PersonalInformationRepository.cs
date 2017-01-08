using System;

namespace ResumeWebsite.Data.Repositories
{
    public class PersonalInformationRepository
    {
        public string DisplayIcon = "face";
        public string FirstName = "Tappasarn";
        public string LastName = "Aramboonpong";
        public string AgeHeader = "Ago";
        public DateTime DateOfBirth = new DateTime(1992, 6, 9);
        public String[] Interest = new string[3] {"Computer Enineer", "Software Engineer", "Programmer"};
    }
}