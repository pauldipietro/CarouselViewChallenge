using CarouselViewChallenge.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarouselViewChallenge.ViewModels
{
	class CarouselViewChallengeViewModel : INotifyPropertyChanged
	{
		private int _position;
		private string _currentColor;
		private string _nextColor;
		private string _previousColor;

		public event PropertyChangedEventHandler PropertyChanged;

		public CarouselViewChallengeViewModel()
		{
			NextCommand = new Command(NextCommandHandler);
			Items = new List<OnBoardingModel>
			{
				new OnBoardingModel
				{
					Icon = "newspaper_spinner.json",
					Description = "Local news stories",
					PrimaryColor = "#1447C9",
					SecondaryColor = "#103DA5"
				},
				new OnBoardingModel
				{
					Icon = "newspaper_spinner.json",
					Description = "Choose your interests",
					PrimaryColor = "#F5C3DC",
					SecondaryColor = "#6F599A"
				},
				new OnBoardingModel
				{
					Icon = "list.json",
					Description = "Drag and Drop to move",
					PrimaryColor = "#FFFFFF",
					SecondaryColor = "#F5C3DC"
				}
			};

			CurrentColor = Items[Position].PrimaryColor;
			PreviousColor = Items[Position - 1 >= 0 ? Position - 1 : 0].PrimaryColor;
			NextColor = Items[Position + 1 < 3 ? Position + 1 : 0].PrimaryColor;
		}

		private void NextCommandHandler()
		{
			SetNextPosition();
			CurrentColor = Items[Position].PrimaryColor;
			PreviousColor = Items[Position - 1 >= 0 ? Position - 1 : 0].PrimaryColor;
			NextColor = Items[Position + 1 < 3 ? Position + 1 : 0].PrimaryColor;
		}

		private void SetNextPosition()
		{
			if (Position == 2)
			{
				Position = 0;
				return;
			}
			Position++;
		}

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public int Position
		{
			get => _position;
			set
			{
				_position = value;
				OnPropertyChanged(nameof(Position));
			}
		}

		public string CurrentColor
		{
			get => _currentColor;
			set
			{
				_currentColor = value;
				OnPropertyChanged(nameof(CurrentColor));
			}
		}

		public string NextColor
		{
			get => _nextColor;
			set
			{
				_nextColor = value;
				OnPropertyChanged(nameof(NextColor));
			}
		}

		public string PreviousColor
		{
			get => _previousColor;
			set
			{
				_previousColor = value;
				OnPropertyChanged(nameof(PreviousColor));
			}
		}

		public ICommand NextCommand { get; }
		public List<OnBoardingModel> Items { get; }
	}
}
