using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPNest.Annotations;
using WPNest.Services;

namespace WPNest {

	public class ThermostatSampleViewModel : INotifyPropertyChanged {

		public ThermostatSampleViewModel() {
			CurrentTemperature = 62;
			TargetTemperature = 70;
		}

		public ThermostatSampleViewModel(Thermostat thermostat) : this() {
		}

		private bool _isAway;
		public bool IsAway {
			get { return _isAway; }
			set {
				_isAway = value;
				OnPropertyChanged();
			}
		}

		private double _targetTemperature;
		public double TargetTemperature {
			get { return _targetTemperature; }
			set {
				_targetTemperature = value;
				OnPropertyChanged();
			}
		}

		private double _targetTemperatureLow;
		public double TargetTemperatureLow {
			get { return _targetTemperatureLow; }
			set {
				_targetTemperatureLow = value;
				OnPropertyChanged();
			}
		}

		private double _targetTemperatureHigh;
		public double TargetTemperatureHigh {
			get { return _targetTemperatureHigh; }
			set {
				_targetTemperatureHigh = value;
				OnPropertyChanged();
			}
		}

		private double _currentTemperature;
		public double CurrentTemperature {
			get { return _currentTemperature; }
			set {
				_currentTemperature = value;
				OnPropertyChanged();
			}
		}

		private bool _isHeating;
		public bool IsHeating {
			get { return _isHeating; }
			set {
				_isHeating = value;
				OnPropertyChanged();
			}
		}

		private bool _isCooling;
		public bool IsCooling {
			get { return _isCooling; }
			set {
				_isCooling = value;
				OnPropertyChanged();
			}
		}

		private FanMode _fanMode;
		public FanMode FanMode {
			get { return _fanMode; }
			set {
				if (value != _fanMode) {
					_fanMode = value;
					OnPropertyChanged();
				}
			}
		}

		private HvacMode _hvacMode;
		public HvacMode HvacMode {
			get { return _hvacMode; }
			set {
				if (value != _hvacMode) {
					_hvacMode = value;
					OnPropertyChanged();
				}
			}
		}

		private bool _isLeafOn;
		public bool IsLeafOn {
			get { return _isLeafOn; }
			set {
				_isLeafOn = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
