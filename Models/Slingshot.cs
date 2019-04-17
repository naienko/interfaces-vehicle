using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
	public class Slingshot : Vehicle, IDrive
	{
		public double MaxLandSpeed { get; set; } = 120;

		public Slingshot()
		{
			Doors = 0;
			Wheels = 3;
			PassengerCapacity = 2;
			TransmissionType = "Manual";
			EngineVolume = 5.3;
		}
		public void Drive()
		{
			Console.WriteLine("The Slingshot screams down the highway");
		}
	}
}