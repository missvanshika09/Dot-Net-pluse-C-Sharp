using System;
//Code Implementation Constructor Injection //Service Interface 
public interface IService
{
    string ServiceMethod();
}

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
/*Getter and Setter Injection injects the dependency by using default public properties procedure such as Gettter(get(){}) and Setter(set(){}). 
The following code sample illustrates the concept, a public property Client has get and set properties of IService interface that accepts the reference of different services
*/

//Implementing Getter and Setter Injection
public  class BusinessLogicImplementation
{
private IService  _client;
   public IService  Client
   {   get { return _client; }
       set { _client = value; }
   }
   public void testSetterInj()
   {   
           Console.WriteLine("Getter and Setter Injection ==> rrent Service :{0}", Client.ServiceMethod()) ;//getter(read)
   }
}
//entry point
class program
    {              static void Main()
                    {       //Consuming Constructor Injection
                  
BusinessLogicImplementation ConInjBusinessLogic = new BusinessLogicImplementation();

                        ConInjBusinessLogic.Client = new ClaimService(); //setter

                        ConInjBusinessLogic.testSetterInj();
          }
 }
