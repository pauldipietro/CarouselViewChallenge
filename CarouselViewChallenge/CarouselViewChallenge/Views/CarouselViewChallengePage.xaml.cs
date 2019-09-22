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
        public RickAndMorthyViewModel VM { get; set; }
        public CarouselViewChallengePage()
        {

            InitializeComponent();
            VM = new RickAndMorthyViewModel();

            VM.Characters = new ObservableCollection<Character>
            {
                new Character
                {
                    image = "https://rickandmortyapi.com/api/character/avatar/1.jpeg",
                    name = "Rick Sanchez",
                    species = "Human",
                    status = "Alive",
                    gender = "Male"
                },
                new Character
                {
                    image = "https://rickandmortyapi.com/api/character/avatar/2.jpeg",
                    name = "Morty Smith",
                    species = "Human",
                    status = "Alive",
                    gender = "Male"
                },
                new Character
                {
                    image = "https://rickandmortyapi.com/api/character/avatar/212.jpeg",
                    name = "Magma-Q",
                    species = "Alien, Alphabetrian",
                    status = "Dead",
                    gender = "Male"
                },
                new Character
                {
                    image = "https://rickandmortyapi.com/api/character/avatar/4.jpeg",
                    name = "Beth Smith",
                    species = "Human",
                    status = "Alive",
                    gender = "Female"
                },
                new Character
                {
                    image = "https://rickandmortyapi.com/api/character/avatar/376.jpeg",
                    name = "Veronica Ann Bennet",
                    species = "Alien, Gazorpian",
                    status = "Alive",
                    gender = "Female"
                }


            };
            BindingContext = VM;

        }
    }
}