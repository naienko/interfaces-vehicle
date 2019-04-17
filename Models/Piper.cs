using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
	public class Piper : Vehicle, IFly
	{
		public bool Winged { get; set; } = true;
		public double MaxAirSpeed { get; set; } = 395.0;

		public Piper()
		{
			Doors = 2;
			Wheels = 3;
			PassengerCapacity = 6;
			TransmissionType = "None";
			EngineVolume = 25.1;
		}

		public void Fly()
		{
			Console.WriteLine("The Piper effortlessly glides through the clouds like a gleaming god of the Sun");
		}
	}
}