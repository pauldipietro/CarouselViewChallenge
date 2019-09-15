using System;
using System.Globalization;
using Xamarin.Forms;

namespace CarouselViewChallenge.Converters
{
    internal class NewsTopicToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return String.Empty;
            }
            string topic = ((string)value).Trim().ToLower();
            switch (topic)
            {
                case "unclassified":
                    return "resource://CarouselViewChallenge.Resources.galnet.orange.svg";
                case "aliens":
                    return "resource://CarouselViewChallenge.Resources.aliens-ufo1.svg";
                case "crime":
                    return "resource://CarouselViewChallenge.Resources.crime.svg";
                case "combat":
                    return "resource://CarouselViewChallenge.Resources.combat-fighter2.svg";
                case "culture":
                    return "resource://CarouselViewChallenge.Resources.theatre.svg";
                case "economy":
                    return "resource://CarouselViewChallenge.Resources.economy-chart.svg";
                case "exploration":
                    return "resource://CarouselViewChallenge.Resources.exploration-planet.svg";
                case "health":
                    return "resource://CarouselViewChallenge.Resources.health.svg";
                case "mining":
                    return "resource://CarouselViewChallenge.Resources.mining-pick.svg";
                case "mystery":
                    return "resource://CarouselViewChallenge.Resources.mystery.svg";
                case "politics":
                    return "resource://CarouselViewChallenge.Resources.politics.svg";
                case "religion":
                    return "resource://CarouselViewChallenge.Resources.religion-ankh.svg";
                case "science":
                    return "resource://CarouselViewChallenge.Resources.science-atom.svg";
                case "alliance":
                    return "resource://CarouselViewChallenge.Resources.alliance.green.svg";
                case "empire":
                    return "resource://CarouselViewChallenge.Resources.empire.blue.svg";
                case "federation":
                    return "resource://CarouselViewChallenge.Resources.federation.red.svg";
                case "ad":
                    return "resource://CarouselViewChallenge.Resources.aisling.logo.svg";
                case "delaine":
                    return "resource://CarouselViewChallenge.Resources.delaine.logo.svg";
                case "ald":
                    return "resource://CarouselViewChallenge.Resources.ald.logo.svg";
                case "patreus":
                    return "resource://CarouselViewChallenge.Resources.patreus.logo.svg";
                case "mahon":
                    return "resource://CarouselViewChallenge.Resources.mahon.logo.svg";
                case "winters":
                    return "resource://CarouselViewChallenge.Resources.winters.logo.svg";
                case "lyr":
                    return "resource://CarouselViewChallenge.Resources.lyr.logo.svg";
                case "antal":
                    return "resource://CarouselViewChallenge.Resources.antal.logo.svg";
                case "grom":
                    return "resource://CarouselViewChallenge.Resources.grom.logo.svg";
                case "hudson":
                    return "resource://CarouselViewChallenge.Resources.hudson.logo.svg";
                case "torval":
                    return "resource://CarouselViewChallenge.Resources.torval.logo.svg";
                case "turner":
                case "tarquin":
                case "dekker":
                case "vatermann":
                case "martuuk":
                case "dorn":
                case "farseer":
                case "tani":
                case "ishmaak":
                case "cheung":
                case "ryder":
                case "jameson":
                case "qwent":
                case "hicks":
                case "brandon":
                case "olmanova":
                case "palin":
                case "ram tah":
                case "jean":
                case "dweller":
                case "sarge":
                case "fortune":
                case "blaster":
                case "nemo":
                    return "resource://CarouselViewChallenge.Resources.engineer.orange.svg";
                default:
                    return "resource://CarouselViewChallenge.Resources.galnet.orange.svg";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
