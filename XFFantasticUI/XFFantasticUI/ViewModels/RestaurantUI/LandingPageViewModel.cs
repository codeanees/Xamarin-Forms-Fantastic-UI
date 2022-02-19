using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using XFFantasticUI.Views.RestaurantUI;

namespace XFFantasticUI.ViewModels.RestaurantUI
{
    public class LandingPageViewModel : BaseViewModel
    {
        public LandingPageViewModel()
        {
            Picks = GetPicks();
        }

        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));

        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title = "Breakfast", Image = "IMG01.png",
                    Description = "Order our healthy and warm breakfast menu for a great morning" },
                new Pick { Title = "Lunch", Image = "IMG03.png",
                    Description = "Delicious lunch to keep your day sweet and smooth" }
            };
        }
    }

    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}