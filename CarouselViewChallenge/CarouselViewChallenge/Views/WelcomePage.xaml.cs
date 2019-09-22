using CarouselViewChallenge.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarouselViewChallenge.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePageViewModel VM { get; set; }
        public WelcomePage()
        {
            InitializeComponent();
            VM = new WelcomePageViewModel();
            VM.Sections = new ObservableCollection<Section>
            {
                new Section
                {
                    Header = "Thank you for participating in the CarouselView Challenge!",
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
                new Section
                {
                    Header = "What to Do",
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
                new Section
                {
                    Header = "Create a PR and Give Feedback",
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
                new Section
                {
                    Header = "1. What went well?",
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "Was the CarouselView easy to use? Were you able to accomplish what you set out to?" + Environment.NewLine + Environment.NewLine
                            }
                        }
                    },
                    Emoji = "😀"
                },
                new Section
                {
                    Header = "2. What didn't go well?",
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "Be as honest and detailed as possible." + Environment.NewLine + Environment.NewLine
                            }
                        }
                    },
                    Emoji = "🙁"
                },
                new Section
                {
                    Header = "3. What's missing?",
                    Content = new FormattedString
                    {
                        Spans =
                        {
                            new Span
                            {
                                Text = "Let us know about any functionality you didn't have access to and its impact on you, or anything else you'd like to see." + Environment.NewLine + Environment.NewLine
                            }
                        }
                    },
                    Emoji = "🤔"
                },
            };
            BindingContext = VM;
        }
    }
}