using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
	public class JetSki : Vehicle, IAmphibious
	{
		public int Wheels { get; set; }
		public int Doors { get; set; }
		public int PassengerCapacity { get; set; }
		public bool Winged { get; set; }
		public string TransmissionType { get; set; }
		public double EngineVolume { get; set; }
		public double MaxWaterSpeed { get; set; }
		public double MaxLandSpeed { get; set; }
		public double MaxAirSpeed { get; set; }

		public void Drive()
		{
			Console.WriteLine("The jetski zips through the waves with the greatest of ease");
		}
	}
}