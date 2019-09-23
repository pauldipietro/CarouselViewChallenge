using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage, INotifyPropertyChanged
    {
        private ObservableCollection<string> _images = new ObservableCollection<string>();
        public ObservableCollection<string> Images
        {
            get => _images;
            set
            {
                _images = value;
                OnPropertyChanged(nameof(Images));
            }
        }

        public CarouselViewChallengePage()
        {
            InitializeComponent();

            p1.BackgroundColor = Color.FromRgba(255, 255, 255, 0.7);
            p2.BackgroundColor = Color.FromRgba(255, 255, 255, 0.7);

            Images.Add("le_00.jpg");
            Images.Add("le_01.jpg");
            BindingContext = this;
        }
    }
}