using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CarouselViewChallenge.Models;
namespace CarouselViewChallenge.ViewModels
{
    public class CarouselPageViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<BirdsModel> _birds;
        private ObservableCollection<string> _numbers;
        private string _pageTitle;
        public CarouselPageViewModel()
        {
            _pageTitle = "CarouselViewChallege";
            _birds = new ObservableCollection<BirdsModel>();
            _birds.Add(new BirdsModel { Title = "Asian Paradise Flycatcher", ImagePath = "Asian-Paradise-Flycatcher.jpg" });
            _birds.Add(new BirdsModel { Title = "Sarus Crane", ImagePath = "Sarus-Crane.jpg" });
            _birds.Add(new BirdsModel { Title = "Himalayan Monal", ImagePath = "Himalayan-Monal.jpg" });
            _birds.Add(new BirdsModel { Title = "Indian Peafowl", ImagePath = "Indian-Peafowl.jpg" });
            _birds.Add(new BirdsModel { Title = "Mrs. Gould’s Sunbird", ImagePath = "Mrs.-Gould’s-Sunbird.jpg" });
            _birds.Add(new BirdsModel { Title = "Oriental Dwarf Kingfisher", ImagePath = "Oriental-Dwarf-Kingfisher.jpg" });
            _birds.Add(new BirdsModel { Title = "Red Headed Trogon", ImagePath = "Red-Headed-Trogon.jpg" });


            _numbers = new ObservableCollection<string>();
            _numbers.Add("One");
            _numbers.Add("Two");
            _numbers.Add("Three");
            _numbers.Add("Four");
            _numbers.Add("Five");
            _numbers.Add("Six");
            _numbers.Add("Seven");
            _numbers.Add("Eight");
            _numbers.Add("Nighn");
            _numbers.Add("Ten");
        }

        public ObservableCollection<BirdsModel> Birds
        {
            get
            {
                return _birds;
            }
            set
            {
                if (_birds != value)
                {
                    _birds = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Birds"));
                }
            }
        }

        public ObservableCollection<string> Numbers
        {
            get
            {
                return _numbers;
            }
            set
            {
                if (_numbers != value)
                {
                    _numbers = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Numbers"));
                }
            }
        }
        public string Title
        {
            get
            {
                return _pageTitle;
            }
            set
            {
                if (_pageTitle != value)
                {
                    _pageTitle = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Title"));
                }
            }
        }
        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }

}
