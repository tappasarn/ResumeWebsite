using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.InfoRepository
{
    public class ContactInfoRepository : IInfoRepository
    {
        private List<string> _infoList = new List<string>(new string[] {"+668 9 484 9658", "time723@gmail.com", "31 Onnut 17 (yak 5) Sukumvit 77 Rd. Suanluang District Bangkok 10250"});
        public List<string> InfoList
        {
            get
            {
                return this._infoList;
            }
        }
    }
}