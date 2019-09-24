using CarouselViewChallenge.Models;
using CarouselViewChallenge.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengePage()
        {
            InitializeComponent();

            var vm = new CarouselViewChallengePageViewModel();
            vm.StoryCards = new ObservableCollection<StoryCard>
            {
                new StoryCard{Name = "Adicionar ao story", IsUserStory = true, StoryImage="User.jpg"},
                new StoryCard{Name = "Luciano Hulk", IsUserStory = false, ProfileImage = "LucianoHulkProfile.jpg", StoryImage = "LucianoHulkStory.jpg"},
                new StoryCard{Name = "Neymar Junior", IsUserStory = false, ProfileImage = "NeymarProfile.jpg", StoryImage = "NeymarStory.jpg" },
                new StoryCard{Name = "Keanu Reeves", IsUserStory = false, ProfileImage = "KeanuProfile.jpg", StoryImage = "KeanuStory.jpg" },
                new StoryCard{Name = "Leonardo DiCaprio", IsUserStory = false, ProfileImage = "LeonardoProfile.jpg", StoryImage = "LeonardoStory.jpg" },
                new StoryCard{Name = "Brad Pitt", IsUserStory = false, ProfileImage = "BradProfile.jpg", StoryImage = "BradStory.jpg" },
                new StoryCard{Name = "Tom Brady", IsUserStory = false, ProfileImage = "TomProfile.jpg", StoryImage = "TomStory.jpg" },
                new StoryCard{Name = "Lebron James", IsUserStory = false, ProfileImage = "LebronProfile.jpg", StoryImage = "LebronStory.jpg" },
                new StoryCard{Name = "Khalil Mack", IsUserStory = false, ProfileImage = "MackProfile.jpg", StoryImage = "MackStory.jpg" },
            };

            BindingContext = vm;
        }
    }
}