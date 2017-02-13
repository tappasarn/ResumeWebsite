using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.InfoRepository
{
    public class EducationInfoRepository : IInfoRepository
    {
        private List<string> _infoList = new List<string>(new string[] {"Mahidol University International College","Bachelor of Engineering", "3.58"});
        public List<string> InfoList
        {
            get
            {
                return this._infoList;
            }
        }
    }
}