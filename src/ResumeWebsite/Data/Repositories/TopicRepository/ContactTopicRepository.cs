using System;
using ResumeWebsite.Data.Repositories.Interfaces;

namespace ResumeWebsite.Data.Repositories.TopicRepository
{
    public class ContactTopicRepository : ITopicRepository
    {
        private string _id = "contact";
        private string _displayIcon = "email";
        private string _topic = "Contact";

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