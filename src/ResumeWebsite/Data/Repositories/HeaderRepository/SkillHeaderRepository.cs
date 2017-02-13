using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.HeaderRepository
{
    public class SkillHeaderRepository : IHeaderRepository
    {
        private List<string> _headerList = new List<string>(new string[]{"ASP.NET / ASP.NET CORE Framework", "Mobile Application", "Programming Languages", "Source Control", "Object Oriented Design Pattern", "Software Testing", "Database", "ETC..."});
        public List<string> HeaderList
        {
            get
            {
                return this._headerList;
            }
        }
    }
}