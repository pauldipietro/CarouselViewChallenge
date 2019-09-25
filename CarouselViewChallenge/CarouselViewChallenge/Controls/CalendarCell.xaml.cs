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
        public string Date
        {
            get { return base.GetValue(DateTextProperty).ToString(); }
            set { base.SetValue(DateTextProperty, value); }
        }

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
            control.date.Text = newValue.ToString();
        }

        public Color BackGround
        {
            get { return (Color)base.GetValue(BackGroundProperty); }
            set { base.SetValue(BackGroundProperty, value); }
        }

        public static readonly BindableProperty BackGroundProperty = BindableProperty.Create(
                                                         propertyName: "BackGround",
                                                         returnType: typeof(Color),
                                                         declaringType: typeof(CalendarCell),
                                                         defaultValue: Color.Default,
                                                         defaultBindingMode: BindingMode.TwoWay,
                                                         propertyChanged: BackGroundPropertyChanged);

        private static void BackGroundPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CalendarCell)bindable;
            control.background.BackgroundColor = (Color)newValue;
        }




        public CalendarCell()
        {
            InitializeComponent();
        }
    }
}