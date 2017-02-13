using System;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.TopicRepository
{
    public class ExperienceTopicRepository : ITopicRepository
    {
        private string _displayIcon = "computer";
        private string _topic = "Working Experience";
        public string DisplayIcon
        {
            get
            {
                return this._displayIcon;
            }
        }

        public string Topic
        {
            get
            {
                return this._topic;
            }
        }
    }
}