using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.InfoRepository
{
    
    public class SkillInfoRepository : IInfoRepository
    {
        private List<string> _infoList = new List<string>(new string[] {"Web Application and Web API", 
            "Android (Java) and Xamarin (C# cross-platform)",
            "Java, C, C++, C#, JavaScript, TypeScript, Python, html5, SCSS, and Octave", 
            "Git (GitLab and GitHub)",
            "S.O.L.I.D", 
            "NUnit Framework for unit testing and Selenium test / JavaScript Test / Database Testing", 
            "MsSQL and SQLite", 
            "Agile software developemnt, Distributed System, Machine Learning"});
        public List<string> InfoList
        {
            get
            {
                return this._infoList;
            }
        }
    }
}