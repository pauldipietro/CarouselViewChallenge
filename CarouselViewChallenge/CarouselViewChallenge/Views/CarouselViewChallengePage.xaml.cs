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
        // https://theculturetrip.com/europe/portugal/articles/the-15-best-destinations-to-visit-in-portugal-in-2017/
        // https://www.lonelyplanet.com/portugal
        public CarouselViewChallengePageViewModel VM { get; set; }
        public CarouselViewChallengePage()
        {
            InitializeComponent();
            VM = new CarouselViewChallengePageViewModel();
            VM.LocationsOfInterest = new ObservableCollection<LocationOfInterest>
            {
                new LocationOfInterest
                {
                    Name = "Madeira",
                    ImageURL = "https://img.theculturetrip.com/1024x/smart/wp-content/uploads/2017/01/7798578766_d261bed3f9_b.jpg",
                    Content = "Start the year off right by waking up in Madeira. This subtropical island system has become one of the trendiest destinations in Portugal for hiking, spending warm days by the seaside as a winter sun retreat, and eating exotic food, plus, the capital Funchal offers one of the best New Year’s Eve parties in the world.",
                },
                new LocationOfInterest
                {
                    Name = "Porto",
                    ImageURL = "https://img.theculturetrip.com/1024x/smart/wp-content/uploads/2017/01/sctp0070-porto-and-douro-valley-porto-portugal-pelaez-10.jpg",
                    Content = "It may seem a lot like the capital since both are characterized by old, colorful buildings sprawled across hilly streets and they sit beside major rivers, but Porto is the yin to Lisbon’s yang. Where Lisbon is literally bright and sunny, Porto shines with culture."
                },
                new LocationOfInterest
                {
                    Name = "Lisbon",
                    ImageURL = "https://img.theculturetrip.com/1024x/smart/wp-content/uploads/2017/01/watson-lisbon-portugal-view-from-portas-do-sol.jpg",
                    Content = "The capital continues to sit at the top of travel itineraries, and visitors usually can’t wait to sink their teeth into authentic pasteis de nata, try one of the many bacalhau dishes, and explore the Portuguese calçadas (traditional mosaic walkways)."
                },
                new LocationOfInterest
                {
                    Name = "Ericeira",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/wave-1246560_1280.jpg",
                    Content = "Surfing is one of the main attractions in Portugal, and Ericeira is a small fishing village with a big reputation for catching waves."
                },
                new LocationOfInterest
                {
                    Name = "Algarve",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/9592377814_51b74c41c2_b.jpg",
                    Content = "Algarve is one of the best places to go to mix warm weather, hiking expeditions, trendy beaches, and even trendier social scenes."
                },
                new LocationOfInterest
                {
                    Name = "Alentejo",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/evora-226068_1280.jpg",
                    Content = "Break away from the crowds by visiting the Alentejo region. The area’s capital city, Évora, is another lovely spot with a rich history and a mysterious nature."
                },
                new LocationOfInterest
                {
                    Name = "Sintra",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/2855714424_ebf84ed69f_z.jpg",
                    Content = "Hans Christian Andersen, the most famous author of children’s fairy tales, once lived in a house in Sintra’s woods, and pleasantly-surprised visitors still stumble across the house while trekking downhill from the city’s many palaces and fortresses."
                },
                new LocationOfInterest
                {
                    Name = "Óbidos",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/obidos-469057_1280.jpg",
                    Content = "Speaking of castles, how about visiting a city located within castle walls? Charming, picturesque, and romantic, Óbidos is a great place to bring a camera or smartphone and make your Instagram account more colorful."
                },
                new LocationOfInterest
                {
                    Name = "Serra da Estrela",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/freerider-498473_1280.jpg",
                    Content = "This destination is a little harder to get to, but still well worth the effort. Portugal isn’t all beaches, and Serra da Estrela is home to the highest mountain peak in continental Portugal (the highest in all of Portugal being in Pico Island, Azores)."
                },
                new LocationOfInterest
                {
                    Name = "Coimbra",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2016/05/shutterstock_116938165.jpg",
                    Content = "In the country’s center is a city that attracts more visitors than most others in Portugal. Coimbra is home to a high number of Roman and medieval ruins and is another historical center, having once served as the capital of the country."
                },
                new LocationOfInterest
                {
                    Name = "São Miguel",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/lagoa_das_sete_cidades3.jpg",
                    Content = "Nearly halfway between the American and Portuguese coasts is the Azorean archipelago, and each island is worth a visit. The largest, São Miguel, is the easiest to reach by air, and there’s plenty to see in this rolling green oasis for a thoroughly Azorean experience."
                },
                new LocationOfInterest
                {
                    Name = "Monsanto",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/1024px-aldeia_velha_de_monsanto_-_casa_entre_as_pedras.jpg",
                    Content = "Want to travel back in time? For travelers after a real feel for old Portugal, it doesn’t get better than visiting the most Portuguese village in the country, which has barely changed over hundreds of years."
                },
                new LocationOfInterest
                {
                    Name = "Peneda-Gerês National Park",
                    ImageURL = "https://i1.wp.com/www.vortexmag.net/wp-content/uploads/2017/04/geres928492.jpg",
                    Content = "Portugal only has one national park and this is it. Located in Minho, a region known for its beauty, Peneda-Gerês National Park offers oak forests, a winding Roman road with ancient markers, bridges and waterfalls."
                },
                new LocationOfInterest
                {
                    Name = "Guimarães",
                    ImageURL = "https://img.theculturetrip.com/1440x/smart/wp-content/uploads/2017/01/6182674241_184e61a08f_b.jpg",
                    Content = "If you have extra time, use it to visit the country’s first capital. In the 12th century, Portugal’s first king, Afonso I, ruled from his birthplace, Guimarães."
                },
                new LocationOfInterest
                {
                    Name = "Braga",
                    ImageURL = "https://bragacool.com/sites/default/files/styles/flex-short_1920x1080/public/home_001.jpg",
                    Content = "Tying together old and new is Portugal’s fourth largest city, one of the oldest in the country with a strong, youthful following. In fact, it was labeled the European Youth Capital in 2012 and attracts students from the nearby University of Minho."
                }
            };
            BindingContext = VM;
        }
    }
}