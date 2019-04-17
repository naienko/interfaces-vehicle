using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
	public class Cessna : Vehicle, IFly
	{
		public bool Winged { get; set; } = true;
		public double MaxAirSpeed { get; set; } = 309.0;

    public Cessna () {
      Doors = 3;
      Wheels = 3;
      PassengerCapacity = 113;
      TransmissionType = "None";
			EngineVolume = 31.1;
    }

		public void Fly()
		{
			Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
		}

	}

}