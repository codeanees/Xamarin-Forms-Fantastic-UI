using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFFantasticUI.Views.RestaurantUI
{
    /// <summary>
    /// Reference: Full credits goes to https://github.com/devcrux/Beautiful-Restaurant-App-in-Xamarin-Forms
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void CarouselPositionChanged(object sender, PositionChangedEventArgs e)
        {
            var carousel = sender as CarouselView;
            var views = carousel.VisibleViews;

            if (views.Count > 0)
            {
                foreach (var view in views)
                {
                    var img = view.FindByName<Image>("MenuImg");
                    ViewExtensions.CancelAnimations(img);

                    Task.Run(async () => await img.RelRotateTo(360, 5000, Easing.BounceOut));
                }
            }
        }
    }
}