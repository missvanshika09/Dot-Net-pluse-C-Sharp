//runtime passs will get execute //and syntax maintain become zero
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
/*
Interface Injection is similar to Getter and Setter DI, the Getter and Setter DI uses default getter and setter but Interface Injection uses support interface a kind of explicit getter and setter which sets the interface property. The following code sample illustrates the concept, ISetService is a support interface which has method setServiceRunService which set the interface property.

*/
interface ISetService //interface 
    {
        void setServiceRunService(IService client)//method od interface;
    }

    public class BusinessLogicImplementationInterfaceDI : ISetService
   {
   IService _client1;
      public void setServiceRunService(IService client)
     {
       _client1 = client;
Console.WriteLine("Interface Injection ==>Current Service:{0}", _client1.ServiceMethod() );
      }//calling interface ‘s   //method definition of Iservice client 
  }

class program
    {
        static void Main()
        {      
            BusinessLogicImplementationInterfaceDI objInterfaceDI = 
              new BusinessLogicImplementationInterfaceDI();
           ClaimService     serviceObj = new ClaimService();
          objInterfaceDI.setServiceRunService(serviceObj);

        }
    }
/*

                +---------------------+
                |    ISetService      |
                +---------------------+
                | + setServiceRunService(IService) |
                +---------------------+
                         ^
                         |
                         |
                +-----------------------------+
                | BusinessLogicImplementationInterfaceDI |
                +-----------------------------+
                | - IService _client1         |
                | + setServiceRunService()    |
                +-----------------------------+
                         |
                         |
                 +--------------------+
                 |    IService        |
                 +--------------------+
                 | + ServiceMethod()   |
                 +--------------------+
                  /        |          \
                 /         |           \
                /          |            \
 +----------------+  +----------------+  +-----------------+
 |  ClaimService  |  | AdjudicationService | | PaymentService |
 +----------------+  +----------------+  +-----------------+
 | + ServiceMethod()|  | + ServiceMethod() | | + ServiceMethod() |
 +----------------+  +----------------+  +-----------------+
*/
