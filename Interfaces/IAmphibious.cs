using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{

	public interface IAmphibious
	{
		double MaxWaterSpeed { get; set; }
		void Drive();
	}
}