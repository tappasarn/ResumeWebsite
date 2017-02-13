using ResumeWebsite.Data.Repositories.HeaderRepository;
using ResumeWebsite.Data.Repositories.InfoRepository;
using ResumeWebsite.Data.Repositories.Interfaces;
using ResumeWebsite.Data.Repositories.TopicRepository;
using ResumeWebsite.Models.MainViewModels;
using ResumeWebsite.Services.Builders.BaseClass;

namespace ResumeWebsite.Services.Builders
{
    public class EducationInformationViewModelBuilder : OtherInformationViewModelBuilder
    {
        private static readonly IHeaderRepository _educationInformationHeaderRepository = new EducationHeaderRepositoy();
        private static readonly IInfoRepository _educationInformationInfoRepository = new EducationInfoRepository();
        private static readonly ITopicRepository _educationInformationTopicRepository = new EducationTopicRepository();
        private static IOtherInfo _educationInformationViewModel = new EducationInformationViewModel();
        public EducationInformationViewModelBuilder() : base(_educationInformationHeaderRepository, 
            _educationInformationInfoRepository,
            _educationInformationTopicRepository, 
            _educationInformationViewModel)
        {

        }
    }
}