using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFFantasticUI.Views.RestaurantUI
{
    /// <summary>
    /// Reference: Full credits goes to https://github.com/devcrux/Beautiful-Restaurant-App-in-Xamarin-Forms
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
            Task.Run(RotateImage);
        }

        private async void RotateImage()
        {
            while (true)
            {
                await BannerImg.RelRotateTo(360, 10000, Easing.Linear);
            }
        }
    }
}