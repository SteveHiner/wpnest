﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using WPNest.Services;

namespace WPNest {

	public class NestSampleViewModel : INotifyPropertyChanged {

		public NestSampleViewModel() {
			IsLoggedIn = true;

			var firstThermostat = new ThermostatSampleViewModel(new Thermostat(""));
			var secondThermostat = new ThermostatSampleViewModel(new Thermostat(""));

			Thermostats.Add(firstThermostat);
			Thermostats.Add(secondThermostat);

			SelectedThermostat = firstThermostat;
		}

		private bool _isLoggingIn;
		public bool IsLoggingIn {
			get { return _isLoggingIn; }
			set {
				_isLoggingIn = value;
				OnPropertyChanged("IsLoggingIn");
			}
		}

		private bool _isLoggedIn;
		public bool IsLoggedIn {
			get { return _isLoggedIn; }
			set {
				_isLoggedIn = value;
				OnPropertyChanged("IsLoggedIn");
			}
		}

		private string _userName = "";
		public string UserName {
			get { return _userName; }
			set {
				_userName = value;
				OnPropertyChanged("UserName");
			}
		}

		private string _password = "";
		public string Password {
			get { return _password; }
			set {
				_password = value;
				OnPropertyChanged("Password");
			}
		}

		private ThermostatSampleViewModel _selectedThermostat;
		public ThermostatSampleViewModel SelectedThermostat {
			get { return _selectedThermostat; }
			set {
				_selectedThermostat = value;
				OnPropertyChanged("SelectedThermostat");
			}
		}

		private WebServiceError _currentError = WebServiceError.None;
		public WebServiceError CurrentError {
			get { return _currentError; }
			set {
				_currentError = value;
				OnPropertyChanged("CurrentError");
			}
		}

		private readonly ObservableCollection<ThermostatSampleViewModel> _thermostats = new ObservableCollection<ThermostatSampleViewModel>();
		public ObservableCollection<ThermostatSampleViewModel> Thermostats {
			get { return _thermostats; }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName) {
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}

		public async Task InitializeAsync() {
#if WP7
			await TaskEx.Delay(0);
#elif WP8
			await Task.Delay(0);
#endif
		}
	}
}
