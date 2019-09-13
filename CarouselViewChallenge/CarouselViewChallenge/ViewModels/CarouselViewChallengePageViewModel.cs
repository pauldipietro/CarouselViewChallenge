using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CarouselViewChallenge.Models;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengePageViewModel : INotifyPropertyChanged
    {
        public CarouselViewChallengePageViewModel(){
           
            Places = new ObservableCollection<Place>()
            {
                new Place(){HasSpecial=true, Special=new PromotionInfo(){ Price=20,Title="Resort 2 x 1 in the caribbean", Image="https://static.wixstatic.com/media/e28979_c7c66c9ae404417199d77b5e10f9c702~mv2.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at est"},
                            HasActivity=true, Activity=new PromotionInfo(){  Image="https://data.schwabenorthamerica.com/feelalive/images/Coupon-3Dollar.png"},
                            HasFreeActivity=true, FreeActivity=new PromotionInfo(){Price=10, Title="2 hours horse walk", Image="https://media-cdn.tripadvisor.com/media/photo-s/04/07/f0/44/the-horse-resort.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at est"},},

                new Place(){HasSpecial=true, Special=new PromotionInfo(){Price=10, Title="Go to the beach", Image="https://www.usnews.com/dims4/USNEWS/399cc03/2147483647/thumbnail/640x420/quality/85/?url=http%3A%2F%2Fcom-usnews-beam-media.s3.amazonaws.com%2F17%2F5c%2Fe08bd2a347be848e3dd4e98d88d9%2F2-30.%20San%20Francisco-Getty.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at est"},
                             FreeActivity=new PromotionInfo(){Price=10, Title="Go to the beach", Image="https://static.wixstatic.com/media/e28979_c7c66c9ae404417199d77b5e10f9c702~mv2.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at est"},},

                new Place(){ HasActivity=true, Activity=new PromotionInfo(){  Image="https://data.schwabenorthamerica.com/feelalive/images/Coupon-3Dollar.png"},
                           HasFreeActivity =true, FreeActivity=new PromotionInfo(){Price=10, Title="Go to the beach", Image="http://www.transindiatravels.com/wp-content/uploads/the-taj-mahal-agra.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at est"},},

                new Place(){HasFreeActivity=true, FreeActivity=new PromotionInfo(){ Price=200, Title ="Paris 2 x 1 ", Image="https://www.pandotrip.com/wp-content/uploads/2018/06/Eiffel-Tower-Paris-France.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at est"},},

                 new Place(){HasSpecial=true, Special=new PromotionInfo(){Price=240, Title="Delih", Image="https://www.thelalit.com/wp-content/uploads/2017/01/City-Attraction1-New-Delhi-e1493635162496-760-320.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at est"},
                   HasActivity=true, Activity=new PromotionInfo(){  Image="https://data.schwabenorthamerica.com/feelalive/images/Coupon-3Dollar.png"},

                     HasFreeActivity =true,FreeActivity=new PromotionInfo(){Price=10, Title="what are you waiting for?", Image="https://www.roadaffair.com/wp-content/uploads/2019/03/woman-red-dress-santorini-greece-shutterstock_1048935941-1024x683.jpg", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at est"},},


            };
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Place> _sections;
        public ObservableCollection<Place> Places
        {
            get
            {
                return _sections;
            }
            set
            {
                if (_sections != value)
                {
                    _sections = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Places"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }

}
