using System;
using System.Globalization;
using Xamarin.Forms;

namespace CarouselViewChallenge.Converters
{
    internal class StationPadToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return String.Empty;
            }

            string pad = ((string)value).Trim().ToLower();
            switch (pad)
            {
                case "large":
                case "station":
                    return "resource://CarouselViewChallenge.Resources.coriolis.orange.svg";
                case "large (planet)":
                case "large(planet)":
                case "planetary":
                    return "resource://CarouselViewChallenge.Resources.surface-port.orange.svg";
                case "medium":
                case "outpost":
                    return "resource://CarouselViewChallenge.Resources.outpost.orange.svg";
                default:
                    return String.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
