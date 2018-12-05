using System;
using PackageTransportServices.PackageServices;
using PackageTransportServices.PackageCreation;

namespace PackageTransportServices
{
    class Program
    {
        static void Main(string[] args)
        {
           //packageshipment calculates cost
           //other classes that support this calculation are supplied as parameters.
           IPackageShipment package= new PackageShipment(new WeighingService(),
           new PricingService(), new PackageService(), new PackageFactory());
           String output = package.PackageShipmentCosting(args);
           //Write provided output to console
           Console.WriteLine(output);
        }
    }
}
