using System;
using PackageTransportServices.PackageDetails;
using System.Collections.Generic;
using System.Linq;

namespace PackageTransportServices.PackageServices
{
    public class PackageService:IPackageService
    {
        /// <summary>
        /// Gets Package Type based on supplied values
        /// </summary>
        /// <param name="packagesize"></param>
        /// <returns></returns>
        public String GetPackageType(Package packagesize)
        {
            List<PackageType> package= PackageTypes.GetExistingPackageSize();
           return (package.OrderBy(x=>x.Length).
           FirstOrDefault(ps=>(!(ps.Length<packagesize.Length || 
            ps.Breadth<packagesize.Breadth || ps.Height<packagesize.Height)))).Size;

        }
    }
}