using System.Collections.ObjectModel;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengeViewModel VM { get; set; }
        public CarouselViewChallengePage()
        {
            InitializeComponent();
            VM = new CarouselViewChallengeViewModel();
            VM.Pokedex = new ObservableCollection<Pokedex>
            {
                new Pokedex
                {
                    TypeBackgroudColor = Color.FromHex("7AC74C"),
                    ImagePokemon = "https://github.com/fanzeyi/pokemon.json/blob/master/images/001.png?raw=true",
                    Name = "Bulbasaur",
                    Number = "#001",
                    HP= 45,
                    Attack= 49,
                    Defense= 49,
                    SpAttack= 65,
                    SpDefense= 65,
                    Speed= 45
                },
                new Pokedex
                {
                    TypeBackgroudColor = Color.FromHex("EE8130"),
                    ImagePokemon = "https://github.com/fanzeyi/pokemon.json/blob/master/images/004.png?raw=true",
                    Name = "Charmander",
                    Number = "#004",
                    HP= 39,
                    Attack= 52,
                    Defense= 43,
                    SpAttack= 60,
                    SpDefense= 50,
                    Speed= 65
                },
                new Pokedex
                {
                    TypeBackgroudColor = Color.FromHex("6390F0"),
                    ImagePokemon = "https://github.com/fanzeyi/pokemon.json/blob/master/images/007.png?raw=true",
                    Name = "Squirtle",
                    Number = "#007",
                    HP= 44,
                    Attack= 48,
                    Defense= 65,
                    SpAttack= 50,
                    SpDefense= 64,
                    Speed= 43
                }
            };
            BindingContext = VM;
        }
    }
}