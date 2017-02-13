using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.HeaderRepository
{
    public class EducationHeaderRepositoy : IHeaderRepository
    {
        private List<string> _headerList = new List<string>(new string[] {"Graduated", "Degree", "CUM GPA"});
        public List<string> HeaderList
        {
            get
            {
                return this._headerList;
            }
        }
    }
}