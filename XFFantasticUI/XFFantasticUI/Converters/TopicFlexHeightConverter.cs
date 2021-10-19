using System;
using System.Globalization;
using Xamarin.Forms;
using XFFantasticUI.Models.MockTweet;

namespace XFFantasticUI.Converters
{
    class TopicFlexHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            if (value is Topic)
            {
                var bindingObject = (Topic)value;
                var totalCount = bindingObject.SubCategories.Count;
                if (totalCount <= 10)
                {
                    return 50;
                }
                else
                {
                    return 200;
                }
            }
            return 50;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
