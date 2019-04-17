using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{

	public class Vehicle
	{
		public int Wheels { get; set; }
		public int Doors { get; set; }
		public int PassengerCapacity { get; set; }
		public string TransmissionType { get; set; }
		public double EngineVolume { get; set; }
		public virtual void Start() {
			Console.WriteLine("The vehicle comes to life with a roar.");
		}
		public virtual void Stop() {
			Console.WriteLine("The vehicle gently comes to a stop.");
		}
	}
}