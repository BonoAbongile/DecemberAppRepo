using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecemberAppTask.ViewModels
{
    public class NavigationBarViewModel : ViewModelBase
    {

        private DelegateCommand _navigationCommand;
        public DelegateCommand NavigateCommand =>
            _navigationCommand ?? (_navigationCommand = new DelegateCommand(ExecuteCommandName));

        private async void ExecuteCommandName()
        {
            await NavigationService.NavigateAsync("NavigationBar/NavigationPage/LandingPage", useModalNavigation: true);
        }

        private DelegateCommand _landingPageCommand;
        public DelegateCommand LandingPageCommand =>
            _landingPageCommand ?? (_landingPageCommand = new DelegateCommand(ExecuteLandingPageCommand));

        private async void ExecuteLandingPageCommand()
        {
            await NavigationService.NavigateAsync("NavigationBar/NavigationPage/ProductsIntroPage", useModalNavigation: true);
        }

        private DelegateCommand _personalcare;
        public DelegateCommand ToPersonalCarePage =>
            _personalcare ?? (_personalcare = new DelegateCommand(ExecuteToPersonalCarePage));

        private async void ExecuteToPersonalCarePage()
        {   
            await NavigationService.NavigateAsync("PersonalCareProductsPage", useModalNavigation: false);
        }
        public NavigationBarViewModel(INavigationService navigationService)
              : base(navigationService)
        {
            
        }
    }
}
