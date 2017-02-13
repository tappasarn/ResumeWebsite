using System.Collections.Generic;
using ResumeWebsite.Models.MainViewModels;
using ResumeWebsite.Models.MainViewModels.Interface;
using ResumeWebsite.Services.Builders.Interfaces;

namespace ResumeWebsite.Services.Builders
{
    public class MainControllerViewModelBuilder : IMainControllerViewModelBuilder
    {
        private IMainControllerViewModel _mainControllerViewModel = new MainControllerViewModel();
        public IMainControllerViewModel Build()
        {
            // Build Personal Info
            var personalInformationViewModelBuilder = new PersonalInformationViewModelBuilder();          
            var personalInformationViewModel = personalInformationViewModelBuilder.Build();

            // Build Contact Info
            var contactInformationViewModelBuilder = new ContactInformationViewModelBuilder();
            var contactInformationViewModel = contactInformationViewModelBuilder.Build();

            // Build Education Info
            var educationViewModelBuilder = new EducationInformationViewModelBuilder();
            var educationViewModel = educationViewModelBuilder.Build();

            // Build Skill Info
            var skillViewModelBuilder = new SkillInformationViewModelBuilder();
            var skillViewModel = skillViewModelBuilder.Build();

            // Build Experience Info
            var experienceViewModelBuilder = new ExperienceInformationViewModelBuilder();
            var experienceViewModel = experienceViewModelBuilder.Build();

            // Build Project Info
            var projectViewModelBuilder = new ProjectInformationViewModelBuilder();
            var projectViewModel = projectViewModelBuilder.Build();

            // Set up value for main controller view model
            this._mainControllerViewModel.PersonalInfo = personalInformationViewModel;

            var otherInfoList = new List<IOtherInfo>();
            otherInfoList.Add(contactInformationViewModel);
            otherInfoList.Add(educationViewModel);
            otherInfoList.Add(skillViewModel);
            otherInfoList.Add(experienceViewModel);
            otherInfoList.Add(projectViewModel);

            this._mainControllerViewModel.OtherInfo = otherInfoList;

            return this._mainControllerViewModel;
        }
    }
}