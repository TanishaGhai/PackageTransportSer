using System;

namespace PackageTransportServices.PackageDetails
{
    /// <summary>
    /// Create package based on dimensions 
    /// Since dimesnions does not include weight a sperate class is created to hold weight
    /// </summary>
    public class PackageDimensions
    {
        public decimal Length{get;}
        public decimal Breadth{get;}
        public decimal Height{get;}

        public  PackageDimensions(decimal length,decimal breadth,decimal height)
       {
           this.Length=length;
           this.Breadth=breadth;
           this.Height=height;
       }
    }
}