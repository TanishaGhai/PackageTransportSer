using System;
using PackageTransportServices.PackageDetails;
using System.Collections.Generic;
using System.Linq;

namespace PackageTransportServices.PackageServices
{
    public class PricingService:IPricingService
    {
        /// <summary>
        /// Calculates package cost based on supplied values
        /// </summary>
        /// <param name="packagesize"></param>
        /// <returns></returns>
        public decimal CalculateCost(Package packagesize)
        {
            List<PackageType> package= PackageTypes.GetExistingPackageSize();
           return (package.OrderBy(x=>x.Length).
           FirstOrDefault(ps=>(!(ps.Length<packagesize.Length || 
            ps.Breadth<packagesize.Breadth || ps.Height<packagesize.Height)))).Cost;
            

        }
        /// <summary>
        /// Verifies if package is oversize
        /// </summary>
        /// <param name="package"></param>
        /// <returns></returns>
        public bool IsPackageOverSize(Package package)
        {
            PackageDimensions packagedm=GetMaxPackageDimensions();
            return 
            (package.Length>packagedm.Length || package.Breadth>packagedm.Breadth 
            || package.Height>packagedm.Height);
        }

        /// <summary>
        /// To verify if a package is oversize we need to get max size from our list
        /// This suffice that purpose
        /// </summary>
        /// <returns></returns>
        PackageDimensions GetMaxPackageDimensions()
        {
            return PackageTypes.GetExistingPackageSize().OrderByDescending(x=>x.Length).FirstOrDefault();
        }





         
    }
}