using System;
using System.Globalization;
using Xamarin.Forms;

namespace CarouselViewChallenge.Converters
{
    public class WindDirectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var degrees = (int)value;
            var direction = string.Empty;

            if (degrees == 0 || degrees == 360)
                direction = "N";
            else if (degrees < 90)
                direction = "NE";
            else if (degrees == 90)
                direction = "E";
            else if (degrees < 180)
                direction = "SE";
            else if (degrees == 180)
                direction = "S";
            else if (degrees < 270)
                direction = "SW";
            else if (degrees == 270)
                direction = "W";
            else if (degrees < 360)
                direction = "NW";
            else
                direction = "N/A";

            return $"{direction} ({degrees:N0})°";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
