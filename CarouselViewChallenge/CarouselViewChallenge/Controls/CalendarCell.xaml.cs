using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarCell : ContentView
    {
        public string Date { get; set; }
        public static readonly BindableProperty DateTextProperty = BindableProperty.Create(
                                                         propertyName: "Date",
                                                         returnType: typeof(string),
                                                         declaringType: typeof(CalendarCell),
                                                         defaultValue: "",
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: DateTextPropertyChanged);

        private static void DateTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CalendarCell)bindable;
            control.Date = newValue.ToString();
        }

        public CalendarCell()
        {
            InitializeComponent();
        }
    }
}