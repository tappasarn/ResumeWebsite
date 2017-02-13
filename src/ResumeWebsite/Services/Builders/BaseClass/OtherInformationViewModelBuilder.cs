using System;
using ResumeWebsite.Data.Repositories.Interfaces;
using ResumeWebsite.Models.MainViewModels;
using ResumeWebsite.Services.Builders.Interfaces;

namespace ResumeWebsite.Services.Builders.BaseClass
{
    public class OtherInformationViewModelBuilder : IOtherInformationViewModelBuilder
    {
        private readonly IHeaderRepository _headerRepository;
        private readonly IInfoRepository _infoRepository;
        private readonly ITopicRepository _topicRepository;
        private IOtherInfo _otherInfoViewModel;
        public OtherInformationViewModelBuilder(IHeaderRepository _headerRepository, 
            IInfoRepository _infoRepository, 
            ITopicRepository _topicRepository, 
            IOtherInfo _otherInfoViewModel)
        {
            this._headerRepository = _headerRepository;
            this._infoRepository = _infoRepository;
            this._topicRepository = _topicRepository;
            this._otherInfoViewModel = _otherInfoViewModel;
        }
        public IOtherInfo Build()
        {
            this._otherInfoViewModel.Topic = this._topicRepository.Topic;
            this._otherInfoViewModel.DisplayIcon = this._topicRepository.DisplayIcon;

            this._otherInfoViewModel.Header = this._headerRepository.HeaderList;
            
            this._otherInfoViewModel.Info = this._infoRepository.InfoList;

            return this._otherInfoViewModel;
        }
    }
}