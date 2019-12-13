using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DecemberAppTask.Views
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-33.933329, 18.6333308), Distance.FromMiles(10)));
        }
    }
}
