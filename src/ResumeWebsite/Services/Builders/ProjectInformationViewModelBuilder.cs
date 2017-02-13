using ResumeWebsite.Data.Repositories.HeaderRepository;
using ResumeWebsite.Data.Repositories.InfoRepository;
using ResumeWebsite.Data.Repositories.Interfaces;
using ResumeWebsite.Data.Repositories.TopicRepository;
using ResumeWebsite.Models.MainViewModels;
using ResumeWebsite.Services.Builders.BaseClass;

namespace ResumeWebsite.Services.Builders
{
    public class ProjectInformationViewModelBuilder : OtherInformationViewModelBuilder
    {     
        private static readonly IHeaderRepository _projectInformationHeaderRepository = new ProjectHeaderRepository();
        private static readonly IInfoRepository _projectInformationInfoRepository = new ProjectInfoRepository();
        private static readonly ITopicRepository _projectInformationTopicRepository = new ProjectTopicRepository();
        private static IOtherInfo _projectInformationViewModel = new ProjectInformationViewModel();
        public ProjectInformationViewModelBuilder() : base(_projectInformationHeaderRepository, 
            _projectInformationInfoRepository,
            _projectInformationTopicRepository, 
            _projectInformationViewModel)
        {

        }
    }
}