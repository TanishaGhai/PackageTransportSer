using System;

namespace PackageTransportServices.PackageDetails
{
    /// <summary>
    /// Completes the package with cost and size
    /// These both are not supplied via UI but calculated
    /// </summary>
    public class PackageType:Package
    
    {
        public decimal Cost;
        public String Size;

        public PackageType(decimal length,decimal breadth,decimal height,
        decimal weight,decimal cost,String size) :
        base(length,breadth,height,weight)
       {
           Cost=cost;
           Size=size;

       }

    }   
}