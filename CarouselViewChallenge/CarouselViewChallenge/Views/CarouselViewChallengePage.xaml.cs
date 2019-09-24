using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CarouselViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewChallenge.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselViewChallengePage : ContentPage
    {
        public CarouselViewChallengeViewModel _viewModel { get; set; }
        public CarouselViewChallengePage()
        {
            InitializeComponent();
            _viewModel = new CarouselViewChallengeViewModel();

            SetUpData();

            BindingContext = _viewModel;
        }

        private void SetUpData()
        {
            _viewModel.Cards = new ObservableCollection<LsrHeader>
            {
                new LsrHeader()
                {
                    Header = "Working Responsibly",
                    CardDetails = new List<LsrDetails>
                    {
                        new LsrDetails
                        {
                            Description =
                                "Always be sure the required plans and permits are in place, before you start a job or go on or near the line.",
                            Icon = "Safety_logo_icons1.jpg"
                        },
                        new LsrDetails
                        {
                            Description = "Always use equipment that is fit for its intended purpose.",
                            Icon = "Safety_logo_icons2.jpg"
                        },
                        new LsrDetails
                        {
                            Description = "Never undertake any job unless you have been trained and assessed as competent.",
                            Icon = "Safety_logo_icons3.jpg"
                        },
                        new LsrDetails
                        {
                            Description = "Never work or drive while under the influence of drugs or alcohol.",
                            Icon = "Safety_logo_icons4.jpg"
                        },

                    }
                },
                new LsrHeader()
                {
                    Header = "Driving",
                    CardDetails = new List<LsrDetails>
                    {
                        new LsrDetails
                        {
                            Description =
                                "Never use a hand-held or hands-free phone, or programme any other mobile device, while driving.",
                            Icon = "Safety_logo_icons5.jpg"
                        },
                        new LsrDetails
                        {
                            Description = "Always obey the speed limit and wear a seat belt.",
                            Icon = "Safety_logo_icons6.jpg"
                        }
                    }
                },
                new LsrHeader
                {
                    Header = "Working with Electricity",
                    CardDetails = new List<LsrDetails>
                    {
                        new LsrDetails
                        {
                            Description = "Always test before applying earths or straps.",
                            Icon = "Safety_logo_icons7.jpg"
                        },
                        new LsrDetails
                        {
                            Description = "Never assume equipment is isolated – always test before touch. ",
                            Icon = "Safety_logo_icons8.jpg"
                        }
                    }
                },
                new LsrHeader
                {
                    Header = "Working at height",
                    CardDetails = new List<LsrDetails>
                    {
                        new LsrDetails
                        {
                            Description = "Always use a safety harness when working at height, unless other protection is in place.",
                            Icon = "Safety_logo_icons9.jpg"
                        }
                    }
                },
                new LsrHeader
                {
                    Header = "Working with moving equipment",
                    CardDetails = new List<LsrDetails>
                    {
                        new LsrDetails
                        {
                            Description = "Never enter the agreed exclusion zone, unless directed to by the person in charge.",
                            Icon = "Safety_logo_icons10.jpg"
                        }
                    }
                }
            };
        }

    }


}