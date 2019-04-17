using System;
using System.Linq;
using System.Collections.Generic;

namespace Garage
{
    public class Program
{

    public static void Main() {

        Cessna fxs = new Cessna();
        Piper b540 = new Piper();

        // Build a collection of all vehicles that fly
        List<IFly> planes = new List<IFly>() {
            fxs, b540
        };
        // With a single `foreach`, have each vehicle Fly()
        foreach (IFly plane in planes)
        {
            plane.Fly();
        }

        Motorcycle honda = new Motorcycle();
        Slingshot slr = new Slingshot();
        // Build a collection of all vehicles that operate on roads
        List<IDrive> bikes = new List<IDrive>() {
            honda, slr
        };
        // With a single `foreach`, have each road vehicle Drive()
        foreach (IDrive bike in bikes)
        {
            bike.Drive();
        }

        JetSki kawasaki = new JetSki();
        Catamaran catana = new Catamaran();
        // Build a collection of all vehicles that operate on water
        List<IAmphibious> boats = new List<IAmphibious>() {
            kawasaki, catana
        };
        // With a single `foreach`, have each water vehicle Drive()
        foreach (IAmphibious boat in boats)
        {
            boat.Drive();
        }
    }

}
}