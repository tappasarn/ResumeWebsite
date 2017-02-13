using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.HeaderRepository
{
    public class ExperienceHeaderRepository : IHeaderRepository
    {
        private List<string> _headerList = new List<string>(new string[] {"Intern", "Current Job", "Provious Jobs"});
        public List<string> HeaderList
        {
            get
            {
                return this._headerList;
            }
        }
    }
}