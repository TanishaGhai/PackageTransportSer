using System;
using System.Collections.Generic;

namespace PackageTransportServices.PackageDetails
{
    public static class PackageTypes
    {

        /// <summary>
        /// Create a list of package
        /// If a new package is added, it can be simply added here
        /// </summary>
        /// <returns></returns>
       public static List<PackageType> GetExistingPackageSize()
       {
            List<PackageType> PackageTypes =new List<PackageType>();

           PackageTypes.Add(new PackageType(400,600,250,0,8.50M,"Large"));
           PackageTypes.Add(new PackageType(300,400,200,0,7.50M,"Medium"));
           PackageTypes.Add(new PackageType(200,300,150,0,5.00M,"Small"));

           return PackageTypes;

       } 
    }
}