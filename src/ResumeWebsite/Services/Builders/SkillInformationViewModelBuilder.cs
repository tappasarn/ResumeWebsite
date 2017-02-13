using ResumeWebsite.Data.Repositories.HeaderRepository;
using ResumeWebsite.Data.Repositories.InfoRepository;
using ResumeWebsite.Data.Repositories.Interfaces;
using ResumeWebsite.Data.Repositories.TopicRepository;
using ResumeWebsite.Models.MainViewModels;
using ResumeWebsite.Services.Builders.BaseClass;

namespace ResumeWebsite.Services.Builders
{
    public class SkillInformationViewModelBuilder : OtherInformationViewModelBuilder
    {
        private static readonly IHeaderRepository _skillInformationHeaderRepository = new SkillHeaderRepository();
        private static readonly IInfoRepository _skillInformationInfoRepository = new SkillInfoRepository();
        private static readonly ITopicRepository _skillInformationTopicRepository = new SkillTopicRepository();
        private static IOtherInfo _skillInformationViewModel = new SkillInformationViewModel();
        public SkillInformationViewModelBuilder() : base(_skillInformationHeaderRepository, 
            _skillInformationInfoRepository,
            _skillInformationTopicRepository, 
            _skillInformationViewModel)
        {

        }
    }
}