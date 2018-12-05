using System;

namespace PackageTransportServices.PackageServices
{
    public interface IPackageShipment
    {
        String PackageShipmentCosting(String[] packageDm);
    }
}