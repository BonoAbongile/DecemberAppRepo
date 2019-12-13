using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecemberAppTask.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {

        public RegisterViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title2 = "Register Page";
        }

        private DelegateCommand _taketoRegister;
        public DelegateCommand GoToLAndingPageCommand =>
            _taketoRegister ?? (_taketoRegister = new DelegateCommand(ExecuteGoToLAndingPageCommand));

        public async void ExecuteGoToLAndingPageCommand()
        {
            await NavigationService.NavigateAsync("MainPage");
        }
    }
}
