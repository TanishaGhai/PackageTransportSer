using System;

namespace PackageTransportServices.PackageDetails
{
    /// <summary>
    /// Creates package 
    /// with weight i.e. all values supplied from UI
    /// </summary>
    public class Package:PackageDimensions
    {

       public decimal Weight;

      public Package(decimal length,decimal breadth,decimal height,decimal weight):
      base(length,breadth,height)
       {
           Weight=weight;

       }

       

    }
}
