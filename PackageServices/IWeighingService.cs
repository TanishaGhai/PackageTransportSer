using System;
using PackageTransportServices.PackageDetails;

namespace PackageTransportServices.PackageServices
{
    public interface IWeighingService
    {
        bool IsPackageOverWeight(Package package);
    }
}