using System;
using PackageTransportServices.PackageDetails;

namespace PackageTransportServices.PackageServices
{
    public interface IPricingService
    {
        decimal CalculateCost(Package package);
        bool IsPackageOverSize(Package package);
    
    }
}