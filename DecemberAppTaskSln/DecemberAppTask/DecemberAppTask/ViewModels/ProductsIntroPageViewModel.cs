using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecemberAppTask.ViewModels
{
    public class ProductsIntroPageViewModel : ViewModelBase
    {
        public ProductsIntroPageViewModel(INavigationService navigationService)
              : base(navigationService)
        {
            
        }
    }
}
