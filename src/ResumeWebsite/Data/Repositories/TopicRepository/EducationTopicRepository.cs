using System;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.TopicRepository
{
    public class EducationTopicRepository : ITopicRepository
    {
        private string _id = "education";
        private string _displayIcon = "school";
        private string _topic = "Education Profile";
        public string DisplayIcon
        {
            get
            {
                return this._displayIcon;
            }
        }

        public string Id
        {
            get
            {
                return this._id;
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