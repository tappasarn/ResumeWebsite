using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.InfoRepository
{
    public class ExperienceInfoRepository : IInfoRepository
    {
        private List<string> _infoList = new List<string>(new string[] {"ESRI Thailand", "Software Engineer (full stack) at AGODA.COM", "Teacher Assistance at Mahidol University International College for EGCI 111 Computer Programming (using C)"});
        public List<string> InfoList
        {
            get
            {
                return this._infoList;
            }
        }
    }
}