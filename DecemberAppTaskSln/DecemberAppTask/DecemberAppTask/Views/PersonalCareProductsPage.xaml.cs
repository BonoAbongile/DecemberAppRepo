using DecemberAppTask.Models;
using DecemberAppTask.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DecemberAppTask.Views
{
    public partial class PersonalCareProductsPage : ContentPage
    {
        //  private PersonalCareProductsPageViewModel productsPage;
        public ObservableCollection<Product> Products { get; set; }

        
        public PersonalCareProductsPage()
        {
            InitializeComponent();
           
        }
        public async Task<ObservableCollection<Product>> ExecuteShowData()
        {
            var client = new HttpClient();
            string results = await client.GetStringAsync("http://10.0.2.2:5000/api/Test");
            var personalProdsList = JsonConvert.DeserializeObject<ObservableCollection<Product>>(results);

            return personalProdsList;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Products = await ExecuteShowData();

            BindingContext = this;
        }

    }
}
