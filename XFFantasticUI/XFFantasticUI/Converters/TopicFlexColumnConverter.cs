using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;
using XFFantasticUI.Models.MockTweet;

namespace XFFantasticUI.Converters
{
    class TopicFlexColumnConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;

            if(value is List<SubCategory>)
            {
                var list  = (List<SubCategory>)value; 
                var totalCount = list.Count;
                if(totalCount <= 10)
                {
                    return new FlexBasis(1f, true);
                }
                else 
                {
                    return new FlexBasis(.25f, true);
                }
            }
            return new FlexBasis();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
