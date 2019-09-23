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
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "Your feedback is highly valuable for helping to drive CarouselView's development and highlight functionality you need most." + Environment.NewLine + Environment.NewLine
                            },
                            new Span
                            {
                                Text = "(This is a CarouselView, so swipe to the left to keep reading!)",
                                FontAttributes = FontAttributes.Italic
                            }
                        }
                    }
                },
                new LocationOfInterest
                {
                    Name = "Porto",
                    ImageURL = "https://img.theculturetrip.com/1024x/smart/wp-content/uploads/2017/01/sctp0070-porto-and-douro-valley-porto-portugal-pelaez-10.jpg",
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "Pick an app and reproduce a part of it where you can use the CarouselView." + Environment.NewLine + Environment.NewLine
                            },
                            new Span
                            {
                                Text = "This could be part of an app you've developed using Xamarin.Forms, or anything you'd like. Your choice!"
                            }
                        }
                    }
                },
                new LocationOfInterest
                {
                    Name = "Lisbon",
                    ImageURL = "https://img.theculturetrip.com/1024x/smart/wp-content/uploads/2017/01/watson-lisbon-portugal-view-from-portas-do-sol.jpg",
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "When you're finished, open a PR with your work, and feel free to share screenshots." + Environment.NewLine + Environment.NewLine
                            },
                            new Span
                            {
                                Text = "If you participated in the CollectionView Challenge, you'll be familiar with the feedback we'd like you to provide:"
                            }
                        }
                    }
                },
                new LocationOfInterest
                {
                    Name = "1. What went well?",
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "Was the CarouselView easy to use? Were you able to accomplish what you set out to?" + Environment.NewLine + Environment.NewLine
                            }
                        }
                    }
                },
                new LocationOfInterest
                {
                    Name = "2. What didn't go well?",
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "Be as honest and detailed as possible." + Environment.NewLine + Environment.NewLine
                            }
                        }
                    }
                },
                new LocationOfInterest
                {
                    Name = "3. What's missing?",
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "Let us know about any functionality you didn't have access to and its impact on you, or anything else you'd like to see." + Environment.NewLine + Environment.NewLine
                            }
                        }
                    }
                },
            };
            BindingContext = VM;
        }
    }
}