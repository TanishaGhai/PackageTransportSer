using System;
using PackageTransportServices.PackageDetails;
using System.Collections.Generic;
using System.Linq;

namespace PackageTransportServices.PackageServices
{
    
    public class WeighingService:IWeighingService
    {
        private const decimal MaxWeight = 25.0M;
        public bool IsPackageOverWeight(Package package)
            {
                return package.Weight > MaxWeight;
            }
        
    }
}