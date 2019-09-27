using CarouselViewChallenge.ViewModels;
using System;
using System.Collections.Generic;
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
		private CarouselViewChallengeViewModel _viewModel;
		public CarouselViewChallengePage()
		{
			_viewModel = new CarouselViewChallengeViewModel();
			InitializeComponent();

			BindingContext = _viewModel;
		}

		public async void NextEventHandler(object sender, EventArgs ea)
		{
			await button.ScaleTo(50, 100);
			button.ScaleTo(1, 100);
			_viewModel.NextCommand.Execute(null);
		}
	}
}