using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.HeaderRepository
{
    public class ProjectHeaderRepository : IHeaderRepository
    {
        private List<string> _headerList = new List<string>(new string[]{"ACM ICPC", "Authorship", "Distributed System", "Pattern Recognition"});
        public List<string> HeaderList
        {
            get
            {
                return this._headerList;
            }
        }
    }
}