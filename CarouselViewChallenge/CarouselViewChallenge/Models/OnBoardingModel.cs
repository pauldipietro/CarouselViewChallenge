using System;
using System.ComponentModel;

namespace CarouselViewChallenge.Models
{
	public class OnBoardingModel : INotifyPropertyChanged
	{
		private string _icon;
		private string _description;
		private bool _playAnimation;
		private string _secondaryColor;

		public event PropertyChangedEventHandler PropertyChanged;

		public string Icon
		{
			get => _icon;
			set
			{
				_icon = value;
				OnPropertyChanged(nameof(Icon));
			}
		}

		public string Description
		{
			get => _description;
			set
			{
				_description = value;
				OnPropertyChanged(nameof(Description));
			}
		}

		public bool PlayAnimation
		{
			get => _playAnimation;
			set
			{
				_playAnimation = value;
				OnPropertyChanged(nameof(PlayAnimation));
			}
		}

		public string PrimaryColor { get; set; }

		public string SecondaryColor
		{
			get => _secondaryColor;
			set
			{
				_secondaryColor = value;
				OnPropertyChanged(nameof(SecondaryColor));
			}
		}

		public void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
