using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{

	public interface IDrive
	{
		double MaxLandSpeed { get; set; }
		void Drive();
	}
}