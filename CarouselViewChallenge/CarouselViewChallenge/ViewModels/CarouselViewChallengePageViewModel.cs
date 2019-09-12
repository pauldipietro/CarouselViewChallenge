using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CarouselViewChallenge.Models;
using CarouselViewChallenge.Networking;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
    public class CarouselViewChallengePageViewModel : BindableObject
    {
        private ObservableCollection<ConsultancyModel> _consultancyModels;

        public ObservableCollection<ConsultancyModel> ConsultancyModels
        {
            get { return _consultancyModels; }
            set
            {
                _consultancyModels = value;
                OnPropertyChanged();
            }
        }

        public CarouselViewChallengePageViewModel()
        {
            LoadConsultancyList();
        }

        private void LoadConsultancyList()
        {
            var getposts = ServiceClient.ServiceClientInstance.GetConsultancyInformationPosts();

            ConsultancyModels = new ObservableCollection<ConsultancyModel>(getposts);
  
        }

    }
}
