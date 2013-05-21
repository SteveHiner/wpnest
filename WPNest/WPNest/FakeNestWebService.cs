using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPNest.Services;

namespace WPNest {

	public class FakeNestWebService : INestWebService {

		public async Task<WebServiceResult> LoginAsync(string userName, string password) {
			var result = new WebServiceResult();
			return await TaskEx.FromResult(result);
		}

		public async Task<GetStatusResult> GetFullStatusAsync() {
			var structure = new Structure("s1");
			var thermostat1 = new Thermostat("t1") {
				CurrentTemperature = 34.0d,
				HvacMode = HvacMode.HeatOnly,
				TargetTemperature = 55.0d
			};
			var thermostat2 = new Thermostat("t2") {
				CurrentTemperature = 45.0d,
				HvacMode = HvacMode.HeatOnly,
				TargetTemperature = 50.0d
			};
			structure.Thermostats.Add(thermostat1);
			structure.Thermostats.Add(thermostat2);
			var result = new GetStatusResult(new[] { structure });
			return await TaskEx.FromResult(result);
		}

		public async Task<WebServiceResult> ChangeTemperatureAsync(Thermostat thermostat, double desiredTemperature, TemperatureMode temperatureMode) {
			var result = new WebServiceResult();
			return await TaskEx.FromResult(result);
		}

		public async Task<GetThermostatStatusResult> GetThermostatStatusAsync(Thermostat thermostat) {
			var result = new GetThermostatStatusResult(thermostat);
			return await TaskEx.FromResult(result);
		}

		public async Task<WebServiceResult> SetFanModeAsync(Thermostat thermostat, FanMode fanMode) {
			var result = new WebServiceResult();
			return await TaskEx.FromResult(result);
		}

		public async Task<WebServiceResult> SetHvacModeAsync(Thermostat thermostat, HvacMode hvacMode) {
			var result = new WebServiceResult();
			return await TaskEx.FromResult(result);
		}

		public async Task<WebServiceResult> SetAwayMode(Structure structure, bool isAway) {
			var result = new WebServiceResult();
			return await TaskEx.FromResult(result);
		}

		public async Task<WebServiceResult> UpdateTransportUrlAsync() {
			var result = new WebServiceResult();
			return await TaskEx.FromResult(result);
		}

		public async Task<GetStatusResult> GetStructureAndDeviceStatusAsync(Structure structure) {
			var result = new GetStatusResult(new[] { structure });
			return await TaskEx.FromResult(result);
		}
	}
}
