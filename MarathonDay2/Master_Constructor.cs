/*Explanation of Master Constructor Concept
Master Constructor: This term is used to describe a primary constructor that handles the initialization logic for the class, while other constructors delegate to it. In your case, the third constructor (the one with three parameters) serves as the master constructor.*/
using System;

namespace ConsoleApplicationThis
{
    class Customer
    {
        public string FirstName, LastName, MiddleName;

        // Constructor with one parameter
        public Customer(string fnm) : this(fnm, "", "")// Uses : this(fnm, "", "") to call the second constructor. This prevents code duplication and centralizes the initialization logic.
        {
            Console.WriteLine("1");
        }

        // Constructor with two parameters
        public Customer(string fnm, string lnm) : this(fnm, lnm, "")//Initializes a customer with a first name and a last name, leaving the middle name empty.
        {
            Console.WriteLine("2");
        }

        // Constructor with three parameters
        public Customer(string fnm, string lnm, string mnm)
        {
            if (fnm.Length <= 6)
            {
                throw new Exception("First name must be longer than 6 characters.");
            }
            else
            {
                FirstName = fnm;
                LastName = lnm;
                MiddleName = mnm;
            }
        }

        // Method to display the customer's name
        public void Display() // Outputs the full name of the customer to the console in the format "FirstName LastName MiddleName".
        {
            Console.WriteLine($"{FirstName} {LastName} {MiddleName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer obj1 = new Customer("vita");
                obj1.Display();

                Customer obj2 = new Customer("vidyasagar", "Nidhi");
                obj2.Display();

                Customer obj3 = new Customer("Cdac", "2016", "Juhu");
                obj3.Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
