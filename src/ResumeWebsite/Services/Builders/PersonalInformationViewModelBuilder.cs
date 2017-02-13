using System;
using ResumeWebsite.Data.Repositories;
using ResumeWebsite.Data.Repositories.Interfaces;
using ResumeWebsite.Models.MainViewModels;
using ResumeWebsite.Services.Builders.Interfaces;

namespace ResumeWebsite.Services.Builders
{
    public class PersonalInformationViewModelBuilder : IPersonalInformationViewModelBuilder
    {
        private readonly IPersonalInformationRepository _personalInformationRepository;
        private IPersonalInfo _personalInformationViewModel;
        public PersonalInformationViewModelBuilder(){
            // TODO: DI ? 
            this._personalInformationRepository = new PersonalInformationRepository();
            this._personalInformationViewModel = new PersonalInformationViewModel();
        }
        public IPersonalInfo Build()
        {
            this._personalInformationViewModel.FullName = this._personalInformationRepository.FirstName + " " + this._personalInformationRepository.LastName;
            
            this._personalInformationViewModel.DisplayIcon = this._personalInformationRepository.DisplayIcon;

            this._personalInformationViewModel.Focus = this.InterestListBuilder(this._personalInformationRepository.Interest);

            this._personalInformationViewModel.Age = this.AgeBuilder(this._personalInformationRepository.DateOfBirth, this._personalInformationRepository.MonthOfBirth, this._personalInformationRepository.YearOfBirth);

            this._personalInformationViewModel.ImgSrc = this._personalInformationRepository.ImgSrc;

            return this._personalInformationViewModel; 
        }

        private string InterestListBuilder(string[] interestList){
                    
            string _separator = " - ";
            return String.Join(_separator, interestList);           
        }

        private int AgeBuilder(int _dateOfBirth, int _monthOfBirth, int _yearOfBirth)
        {
            // TODO: improve this to be excat date 
            var today = DateTime.Today;
            var age = today.Year - _yearOfBirth; 
            return age;
        }
    }
}