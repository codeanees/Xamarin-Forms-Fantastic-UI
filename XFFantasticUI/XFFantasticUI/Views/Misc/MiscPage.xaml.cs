using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFFantasticUI.Effects;

namespace XFFantasticUI.Views.Misc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiscPage : ContentPage
    {
        public MiscPage()
        {
            InitializeComponent();
        }

        private void MiscPage_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CountLabel")
            {
                clickMeButton.Effects.OfType<ParticleEffect>().First().RaiseEmit();
            }
        }
    }
}