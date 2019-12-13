using DecemberAppTask.Models;
using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DecemberAppTask.ViewModels
{
    public class PersonalCareProductsPageViewModel : ViewModelBase
    {
        public PersonalCareProductsPageViewModel(INavigationService navigationService)
             : base(navigationService)
        {
            
        } 
    }
}
