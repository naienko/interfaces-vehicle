using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
	public class Catamaran : Vehicle, IAmphibious
	{
		public double MaxWaterSpeed { get; set; } = 50;

		public Catamaran()
		{
			Doors = 0;
			Wheels = 0;
			PassengerCapacity = 10;
			TransmissionType = "None";
			EngineVolume = 0;
		}

		public void Drive()
		{
			Console.WriteLine("The catamaran is wind powered");
		}
	}
}