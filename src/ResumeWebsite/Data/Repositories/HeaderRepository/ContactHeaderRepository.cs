using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.HeaderRepository
{
    public class ContactHeaderRepository : IHeaderRepository
    {
        private List<string> _headerList = new List<string>(new string[] {"Mobile", "Email", "Address"});

        public List<string> HeaderList
        {
            get
            {
                return this._headerList;
            }
        }
    }
}