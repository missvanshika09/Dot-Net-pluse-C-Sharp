using System;
//Code Implementation Constructor Injection //Service Interface 
public interface IService
{
    string ServiceMethod();
}
//Constructor Injection Implementation for all services
// all other remain the sam just this code snipe changes every time
public  class BusinessLogicImplementation
{  
   private IService client; //2
   public BusinessLogicImplementation(IService client)
   {
       this.client = client; //4
       Console.WriteLine("Constructor Injection Injection ==>  Current Service : {0}",client.ServiceMethod());
      
   } 
}
 

//Service Interface implementation for Claim Service
public class ClaimService:IService 
{
    public string ServiceMethod()//3
    {
        return "ClaimService is running";
    }
}

//Service Interface implementation for Adjudication Service
public class AdjudicationService:IService
{
    public string ServiceMethod() //5
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
 // entry point  
  class program
    {              static void Main()
                    {       //Consuming Constructor Injection //1 step
BusinessLogicImplementation  ConInjBusinessLogic = 
                      new BusinessLogicImplementation(new ClaimService());
     
          }
 }

/*
C# code example, you're demonstrating dependency injection (DI) using constructor injection, which is a common practice in software development to enhance modularity, testability, and maintainability. Let’s break down the key points and answer your questions.

Why Use an Interface Instead of a Class?
Abstraction: An interface (IService) provides a contract that different service implementations (like ClaimService, AdjudicationService, and PaymentService) can adhere to. This abstraction allows you to decouple the code that uses the service from the specific implementations.

Flexibility: By programming to an interface, you can easily swap out different implementations without changing the code that uses them. This makes your code more adaptable to changes.

Testability: When unit testing, you can create mock implementations of the IService interface to simulate different behaviors without relying on actual service implementations.

Why Not Instantiate a Class Directly?
Decoupling: By not instantiating the ClaimService directly within BusinessLogicImplementation, you keep the business logic decoupled from the service's specific implementation. This allows you to change or replace the service without modifying the BusinessLogicImplementation class.

Single Responsibility Principle: Each class should have one reason to change. By relying on an interface, you separate the responsibilities of service execution from the business logic, adhering to this principle.

Scalability: If you later need to add more services or change existing ones, you can do so without impacting the business logic, making the system easier to scale and maintain.
*/
