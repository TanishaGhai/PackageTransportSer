
using System;
using PackageTransportServices.PackageDetails;

namespace PackageTransportServices.PackageCreation
{

    public class PackageFactory:IPackageFactory
    {
       /// <summary>
       /// Create Package using arguments supplied
       /// </summary>
       /// <param name="packageDmAndWeight"></param>
       /// <returns></returns>  
       public  Package CreatePackage(String[] packageDmAndWeight )
        {
            bool isValidData=true;

            if(packageDmAndWeight.Length<4)
            {
                throw new InvalidArguments("Please provide valid arguments");
            }

            //Verify if each parameter is decimal or not
            //and is greater than 0
            foreach(string data in packageDmAndWeight)
            {
                if( ValidatePackageDm(data)==0)
                    isValidData=false;
                
            }
            if(isValidData)
            {
                return new Package(Convert.ToDecimal(packageDmAndWeight[0]),
                Convert.ToDecimal(packageDmAndWeight[1]),
                Convert.ToDecimal(packageDmAndWeight[2]),
                Convert.ToDecimal(packageDmAndWeight[3]));
            }

            return null;
        }

        /// <summary>
        /// Validates if supplied values are correct
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public decimal ValidatePackageDm(String data)
        {
            decimal parsedVal;
            try
            {
            
            if (!Decimal.TryParse(data,out parsedVal))
            {
               throw new InvalidArguments("Please provide a numeric value ");
            }

            if (!(parsedVal>0.0M))
            {
               throw new InvalidArguments("Please provide positive value for all arguments");
            }
            
            } 
            catch(Exception ex)
            {
                 throw new InvalidArguments("Please provide positive value for all arguments" + ex.Message);
            }
            
                return parsedVal;

        }
    }
    

    /// <summary>
    /// Exception Handling
    /// </summary>
    public class InvalidArguments:Exception
    {
        public InvalidArguments(String message): base(message)
        {

        }
    }
}