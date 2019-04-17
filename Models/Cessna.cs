using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
	public class Cessna : Vehicle, IFly
	{
		public override int Wheels { get; set; } = 3;
		public int PassengerCapacity { get; set; } = 113;
		public bool Winged { get; set; } = true;
		public string TransmissionType { get; set; } = "None";
		public double EngineVolume { get; set; } = 31.1;
		public double MaxWaterSpeed { get; set; }
		public double MaxLandSpeed { get; set; }
		public double MaxAirSpeed { get; set; } = 309.0;

    public Cessna () {
      Doors = 3;
      Wheels = 3;
      PassengerCapacity = 113;
      Winged = true;
      TransmissionType = "None";
    }

		public void Fly()
		{
			Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
		}

	}

}