using System;
using System.Collections.Generic;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.InfoRepository
{
    public class AchivementsInfoRepository : IInfoRepository
    {
        private List<string> _infoList = new List<string>(new string[] {"Asia Thailand National On-site", 
            "Assistance Researcher on Attribution Analysis of Thai Online Messages Project", 
            "Using Command line Hadoop with 4 mac mini to compute string matching on big data : https://github.com/tappasarn/hadoop-tappasarn", 
            "Using knn algorithm to crack captcha number format of a website and Using Collaborative Filtering, Linear Regression, and Gradient Descent to implement recommender system : https://github.com/tappasarn/popcorn-"});    
        public List<string> InfoList
        {
            get
            {
                return this._infoList;
            }
        }
    }
}