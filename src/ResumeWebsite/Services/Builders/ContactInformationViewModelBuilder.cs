using ResumeWebsite.Data.Repositories.HeaderRepository;
using ResumeWebsite.Data.Repositories.InfoRepository;
using ResumeWebsite.Data.Repositories.Interfaces;
using ResumeWebsite.Data.Repositories.TopicRepository;
using ResumeWebsite.Models.MainViewModels;
using ResumeWebsite.Services.Builders.BaseClass;

namespace ResumeWebsite.Services.Builders
{
    public class ContactInformationViewModelBuilder : OtherInformationViewModelBuilder
    {
        private static readonly IHeaderRepository _contactInformationHeaderRepository = new ContactHeaderRepository();
        private static readonly IInfoRepository _contactInformationInfoRepository = new ContactInfoRepository();
        private static readonly ITopicRepository _contactInformationTopicRepository = new ContactTopicRepository();
        private static IOtherInfo _contactInformationViewModel = new ContactInformationViewModel();
        public ContactInformationViewModelBuilder() : base(_contactInformationHeaderRepository, 
            _contactInformationInfoRepository, 
            _contactInformationTopicRepository, 
            _contactInformationViewModel)
        {

        }
    }
}