using System.ComponentModel;
using Xamarin.Forms;
using XFFantasticUI.ViewModels;

namespace XFFantasticUI.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}