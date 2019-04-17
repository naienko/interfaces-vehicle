using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
	public class Motorcycle : Vehicle, IDrive
	{
		public double MaxLandSpeed { get; set; } = 160.4;

		public Motorcycle()
		{
			Doors = 0;
			Wheels = 2;
			PassengerCapacity = 2;
			TransmissionType = "Manual";
			EngineVolume = 1.3;
		}
		public void Drive()
		{
			Console.WriteLine("The motorcycle screams down the highway");
		}
	}
}