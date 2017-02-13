using System;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.TopicRepository
{
    public class ProjectTopicRepository : ITopicRepository
    {
        private string _displayIcon = "assignment";
        private string _topic = "Projects and Achivements";
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