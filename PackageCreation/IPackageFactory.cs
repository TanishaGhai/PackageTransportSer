using System;
using PackageTransportServices.PackageDetails;

namespace PackageTransportServices.PackageCreation
{
    public interface IPackageFactory
    {
        Package CreatePackage(String[] packageDmAndWeight  );
    }
}