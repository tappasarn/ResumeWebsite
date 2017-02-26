using System;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.TopicRepository
{
    public class SkillTopicRepository : ITopicRepository
    {
        private string _id = "skill";
        private string _displayIcon = "web";
        private string _topic = "Skills";
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