using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{

	public interface IFly
	{
		bool Winged { get; set; }
		double MaxLandSpeed { get; set; }
		double MaxAirSpeed { get; set; }
		void Fly();
	}
}