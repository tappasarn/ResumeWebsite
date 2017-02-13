using ResumeWebsite.Data.Repositories.HeaderRepository;
using ResumeWebsite.Data.Repositories.InfoRepository;
using ResumeWebsite.Data.Repositories.Interfaces;
using ResumeWebsite.Data.Repositories.TopicRepository;
using ResumeWebsite.Models.MainViewModels;
using ResumeWebsite.Services.Builders.BaseClass;

namespace ResumeWebsite.Services.Builders
{
    public class ExperienceInformationViewModelBuilder : OtherInformationViewModelBuilder
    {
        private static readonly IHeaderRepository _experienceInformationHeaderRepository = new ExperienceHeaderRepository();
        private static readonly IInfoRepository _experienceInformationInfoRepository = new ExperienceInfoRepository();
        private static readonly ITopicRepository _experienceInformationTopicRepository = new ExperienceTopicRepository();
        private static IOtherInfo _experienceInformationViewModel = new ExperienceInformationViewModel();
        public ExperienceInformationViewModelBuilder() : base(
                _experienceInformationHeaderRepository, 
                _experienceInformationInfoRepository, 
                _experienceInformationTopicRepository, 
                _experienceInformationViewModel)
        {
        }
    }
}