using System;
using System.Collections.Generic;

namespace ResumeWebsite.Models.MainViewModels.BaseClass
{
    public class OtherInfo : IOtherInfo
    {
        protected List<string> _header;
        protected List<string> _info;
        protected string _topic;
        protected string _displayIcon;

        public string DisplayIcon
        {
            get
            {
                return this._displayIcon;
            }

            set
            {
                this._displayIcon = value;
            }
        }

        public List<string> Header
        {
            get
            {
                return this._header;
            }

            set
            {
                this._header = value;
            }
        }

        public List<string> Info
        {
            get
            {
                return this._info;
            }

            set
            {
                this._info = value;
            }
        }

        public string Topic
        {
            get
            {
                return this._topic;
            }

            set
            {
                this._topic = value;
            }
        }
    }
}