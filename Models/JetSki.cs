using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
	public class JetSki : Vehicle, IAmphibious
	{
		public double MaxWaterSpeed { get; set; } = 25;

		public JetSki()
		{
			Doors = 0;
			Wheels = 0;
			PassengerCapacity = 2;
			TransmissionType = "None";
			EngineVolume = 31.1;
		}

		public void Drive()
		{
			Console.WriteLine("The jetski zips through the waves with the greatest of ease");
		}
	}
}