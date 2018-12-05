using System;
using PackageTransportServices.PackageCreation;
using PackageTransportServices.PackageDetails;

namespace PackageTransportServices.PackageServices
{
    public class PackageShipment:IPackageShipment
    {
        private  IWeighingService WeighingService;
        private  IPricingService PricingService;
         private  IPackageService PackageService;
        private  IPackageFactory PackageFactory;
        
        /// <summary>
        /// This has been created for dependency injection
        /// </summary>
        /// <param name="weighingService"></param>
        /// <param name="pricingService"></param>
        /// <param name="packageService"></param>
        /// <param name="packageFactory"></param>
        public PackageShipment(IWeighingService weighingService, 
        IPricingService pricingService,IPackageService packageService,IPackageFactory packageFactory )
        {
            this.WeighingService = weighingService;
            this.PricingService = pricingService;
            this.PackageService=packageService;
            this.PackageFactory = packageFactory;
            
        }

        /// <summary>
        /// Calculatespackage shipment cost
        /// </summary>
        /// <param name="packageDm"></param>
        /// <returns></returns>
        public String PackageShipmentCosting(String[] packageDm)
        {
            try
            {
            Package package=PackageFactory.CreatePackage(packageDm);

            //verify if Package is overweight
            if(WeighingService.IsPackageOverWeight(package))
            {
                return "Package weighs higher than limit";
            }

            //Verify if package is Over size
            if(PricingService.IsPackageOverSize(package))
            {
                return "Size of package exceeds size limit";
            }

            //If none of above suffice
            //return package size with cost
            decimal cost=PricingService.CalculateCost(package);
            string size= PackageService.GetPackageType(package);
             return "Package Type is " + size +" Cost to ship parcel is $"+ cost;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
           
        }
    }
}