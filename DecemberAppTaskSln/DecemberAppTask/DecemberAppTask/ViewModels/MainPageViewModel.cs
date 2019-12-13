using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecemberAppTask.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _productsPageTaker;
        public DelegateCommand GoToProductPageCommand =>
            _productsPageTaker ?? (_productsPageTaker = new DelegateCommand(ExecuteGoToLAndingPageCommand));

        private async void ExecuteGoToLAndingPageCommand()
        {
            await NavigationService.NavigateAsync("NavigationBar/NavigationPage/ProductsIntroPage", useModalNavigation: true);
        }

        private DelegateCommand _registerSender;
        public DelegateCommand SendToRegister =>
            _registerSender ?? (_registerSender = new DelegateCommand(ExecuteSendToRegister));

        private async void ExecuteSendToRegister()
        {
            await NavigationService.NavigateAsync("Register");
        }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            listview = "Login Page";
        }

       
    }
}
