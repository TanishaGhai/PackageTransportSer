using System;
using PackageTransportServices.PackageDetails;


namespace PackageTransportServices.PackageServices
{
    public interface IPackageService
    {
         String GetPackageType(Package package);
    
    }
}