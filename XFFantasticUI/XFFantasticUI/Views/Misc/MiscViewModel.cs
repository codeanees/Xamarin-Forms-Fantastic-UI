using MvvmHelpers;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;

namespace XFFantasticUI.Views.Misc
{
    public class MiscViewModel : BaseViewModel
    {
        public ICommand SingleExecutionAsyncCommand { get; }

        private int _clickCount;

        private string _countLabel;
        public string CountLabel
        {
            get => _countLabel;
            set => SetProperty(ref _countLabel, value);
        }

        public MiscViewModel()
        {
            CountLabel = "How Allow Multiple Execution property works with XCT AsyncCommand";
            SingleExecutionAsyncCommand = new AsyncCommand(ExecuteAsync, allowsMultipleExecutions: false);
        }

        private async Task ExecuteAsync()
        {
            _clickCount++;
            CountLabel = $"Total Click {_clickCount}";

            //Assume some long running operation executing here.  Example: Login API takes 5 seconds!
            await Task.Delay(5000);
        }
    }
}
