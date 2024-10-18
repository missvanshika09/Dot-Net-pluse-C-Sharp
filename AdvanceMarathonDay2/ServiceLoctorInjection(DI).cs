//Service Interface implementation for Claim Service
public class ClaimService:IService 
{
    public string ServiceMethod()
    {
        return "ClaimService is running";
    }
}

//Service Interface implementation for Adjudication Service
public class AdjudicationService:IService
{
    public string ServiceMethod()
    {
        return "AdjudicationService is running";
    }
}

 //Service Interface implementation for Payment Service
public class PaymentService:IService
{
   public string ServiceMethod()
    {
        return "PaymentService is running";
    }
}
using System;
//Code Implementation Constructor Injection //Service Interface 
public interface IService
{
    string ServiceMethod();
}

/*Service Locator Injection is also known as Dependency Absorption. It is used to replacement of new operator. It hides the class dependency by invoking methods directly (without creating object). The following code sample illustrates the concept, in the consumption setService method is invoked by class name BusinessLogicImplementation without creating object.
*/
//Service Locator  Injection Implementation for all services
public class BusinessLogicImplementation
    {
        private static IService _clientLocator;

        public static IService getService()
        {
            return _clientLocator;
        }

        public static void setService(IService clientSL)
        {
            _clientLocator = clientSL;
        }
    }
class program
    {
        static void Main()
        {
            BusinessLogicImplementation.setService(new PaymentService());
            IService client2 = BusinessLogicImplementation.getService();
            Console.WriteLine("Service Locator => Current Service : {0}", client2.ServiceMethod());


        }
    }

/*
+---------------------+
|  BusinessLogicImpl  |
+---------------------+
| - _clientLocator    |<--- (Static Field)
| + getService()      |
| + setService()      |
+---------------------+
          |
          |
          v
+---------------------+
|       IService      |<--- Interface for services
+---------------------+
          ^
          |
          |
+---------------------+
|   PaymentService    |<--- Concrete implementation
+---------------------+
| + ServiceMethod()   |
+---------------------+
*/
