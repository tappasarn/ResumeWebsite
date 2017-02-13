using System;

namespace ResumeWebsite.Models.MainViewModels
{
    public class PersonalInformationViewModel : IPersonalInfo
    {
        private int _age = 0;
        private string _focus = "";
        private string _fullName = "";
        private string _displayIcon = "";
        private string _imgSrc = "";

        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }

        public string Focus
        {
            get
            {
                return this._focus;
            }

            set
            {
                this._focus = value;
            }
        }

        public string FullName
        {
            get
            {
                return this._fullName;
            }

            set
            {
                this._fullName = value;
            }
        }

        public string DisplayIcon
        {
            get
            {
                return this._displayIcon;
            }
            set
            {
                this._displayIcon = value;
            }
        }
        public string ImgSrc
        {
            get
            {
                return this._imgSrc;
            }
            set
            {
                this._imgSrc = value;
            }
        }
    }
}