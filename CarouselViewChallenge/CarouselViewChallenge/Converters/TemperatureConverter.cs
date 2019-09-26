using System;
using System.Globalization;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CarouselViewChallenge.Converters
{
    public class TemperatureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var temp = UnitConverters.KelvinToCelsius((double)value);
            return $"{temp:N2} °C";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
