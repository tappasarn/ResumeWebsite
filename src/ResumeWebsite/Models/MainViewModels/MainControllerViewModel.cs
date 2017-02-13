using System;
using System.Collections.Generic;
using ResumeWebsite.Models.MainViewModels.Interface;

namespace ResumeWebsite.Models.MainViewModels
{
    public class MainControllerViewModel : IMainControllerViewModel
    {
        private  IPersonalInfo _personalInfo;
        private List<IOtherInfo> _otherInfoList;

        public IPersonalInfo PersonalInfo
        {
            get
            {
                return this._personalInfo;
            }

            set
            {
                this._personalInfo = value;
            }
        }

        public List<IOtherInfo> OtherInfo
        {
            get
            {
                return this._otherInfoList;
            }

            set
            {
                this._otherInfoList = value;
            }
        }
    }
}