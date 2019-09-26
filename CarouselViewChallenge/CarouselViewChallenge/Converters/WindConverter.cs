using System;
using System.Globalization;
using Xamarin.Forms;

namespace CarouselViewChallenge.Converters
{
    public class WindConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"Wind: {value} m/s";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
