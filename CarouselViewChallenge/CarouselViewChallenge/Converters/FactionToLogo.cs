using System;
using System.Globalization;
using Xamarin.Forms;

namespace CarouselViewChallenge.Converters
{
    internal class FactionToLogo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return String.Empty;
            }

            string faction = ((string)value).Trim().ToLower();
            switch (faction)
            {
                case "alliance":
                    return "resource://CarouselViewChallenge.Resources.alliance.green.svg";
                case "empire":
                    return "resource://CarouselViewChallenge.Resources.empire.blue.svg";
                case "federation":
                    return "resource://CarouselViewChallenge.Resources.federation.red.svg";
                case "independent":
                case "independant": // Uranius can't spell
                    return "resource://CarouselViewChallenge.Resources.independent.orange.svg";
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
