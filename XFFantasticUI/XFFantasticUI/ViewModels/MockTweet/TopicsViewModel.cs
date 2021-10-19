using System.Collections.ObjectModel;
using Xamarin.Forms;
using XFFantasticUI.Models.MockTweet;
using XFFantasticUI.Services;

namespace XFFantasticUI.ViewModels.MockTweet
{
    public class TopicsViewModel
    {
        public ObservableCollection<Topic> MyTopicCollection { get; set; }
        public Command<SubCategory> TopicSelectedCommand { get; }


        public TopicsViewModel()
        {
            var data = MockTweetDataStore.GetTopicsAsync().Result;
            MyTopicCollection = new ObservableCollection<Topic>(data);
            TopicSelectedCommand = new Command<SubCategory>(OnItemSelected);
        }
        async void OnItemSelected(SubCategory item)
        {
            if (item == null)
                return;
            item.IsSelected = !item.IsSelected;
        }
    }
}

