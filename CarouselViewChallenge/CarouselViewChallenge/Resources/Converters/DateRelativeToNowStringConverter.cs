using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Resources.Converters
{
    public class DateRelativeToNowStringConverter : IValueConverter, IMarkupExtension
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                throw new ArgumentException("Input can not be null");
            }

            if (!DateTime.TryParse(value.ToString(), out var dateInput))
            {
                throw new ArgumentException("Input needs to be of type DateTime");
            }

            var now = DateTime.Now;
            var remaining = Math.Round((dateInput - now).TotalDays);
            var format = "{0} day";
            if (remaining > 1)
            {
                format += "(s)";
            }
            return remaining == 0 ? "Today" : $"{string.Format(format, remaining.ToString())}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}