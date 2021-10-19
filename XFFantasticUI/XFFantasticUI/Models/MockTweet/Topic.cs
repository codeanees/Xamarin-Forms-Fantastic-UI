using System.Collections.Generic;
using Xamarin.Forms;

namespace XFFantasticUI.Models.MockTweet
{
    public class Topic
    {
        public string MainCategoryName { get; set; }
        public List<SubCategory> SubCategories { get; set; }
        public bool ViewAllEnabled { get; set; }
    }
    public class SubCategory : BindableObject
    {
        public string Name { get; set; }


        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
    }
}
