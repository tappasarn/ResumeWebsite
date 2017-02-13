using System;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories
{
    public class PersonalInformationRepository : IPersonalInformationRepository
    {
        private string _displayIcon = "face";
        private string _firstName = "Tappasarn";
        private string _lastName = "Aramboonpong";
        private int _monthOfBirth = 6;
        private int _dateOfBirth = 9;
        private int _yearOfBirth = 1992;
        private string[] _interest = new string[3] { "Computer Engineer", "Software Engineer", "Programmer" };
        private string _imgSrc = "~/images/11053628_10153308249619597_2672511713719356150_o.jpg";

        public int YearOfBirth
        {
            get
            {
                return this._yearOfBirth;;
            }
        }

        public int MonthOfBirth
        {
            get
            {
                return this._monthOfBirth;
            }
        }

        public string DisplayIcon
        {
            get
            {
                return _displayIcon;
            }
        }

        public string FirstName
        {
            get
            {
                return this._firstName;
            }
        }

        public string LastName
        {
            get
            {
                return this._lastName;
            }
        }

        public int DateOfBirth
        {
            get
            {
                return this._dateOfBirth;
            }
        }

        public string[] Interest
        {
            get
            {
                return this._interest;
            }
        }

        public string ImgSrc
        {
            get
            {
                return this._imgSrc;
            }
        }
    }
}