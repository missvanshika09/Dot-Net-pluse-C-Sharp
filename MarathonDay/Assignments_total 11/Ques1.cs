/*Q1. Create class Customer with member variable Id, Name, MobileNo., Address.
Write only Getter setter for all member except Id, Id is auto increment. Use object initializer syntax to initialise member variable. Create Array of Customer class and store 5 object into it. Display all customer detail name wise ascending order.
*/
using System; // Importing the System namespace for basic functionalities

namespace Assignment_Q1
{
    // Define the Customer class
    internal class Customer
    {
        private int id; // Encapsulated member variable for Customer ID
        private static int autoId = 0; // Static counter for auto-incrementing ID (static members belong to the class itself)

        // Public properties with getters and setters for encapsulation
        public string Name { get; set; } // Customer name
        public int MobileNo { get; set; } // Customer mobile number
        public string Address { get; set; } // Customer address

        // Constructor to initialize Customer objects
        public Customer(string name, string address, int mobileNo)
        {
            id = ++autoId; // Auto-increment ID for each new Customer instance
            Name = name; // Set the Name property
            Address = address; // Set the Address property
            MobileNo = mobileNo; // Set the MobileNo property
        }

        // Override ToString method for easy display of Customer information
        public override string ToString() 
        {
            return $"ID: {id}, Name: {Name}, MobileNo: {MobileNo}, Address: {Address}";
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Customer objects using object initializer syntax
            Customer[] customers = new Customer[]
            {
                new Customer("Aditi", "House No 33, Delhi City", 65115620),
                new Customer("Vanshi", "House No 99, Mathura City", 96114965),
                new Customer("Aditya", "House No 7C, Floor 4", 90737484),
                new Customer("Diana", "Street 5, City", 12345678),
                new Customer("Ethan", "Street 10, City", 87654321)
            };

            // Sort customers by name using Bubble Sort (simple sorting algorithm)
            for (int i = 0; i < customers.Length - 1; i++)
            {
                for (int j = 0; j < customers.Length - 1 - i; j++)
                {
                    // Compare names and swap if out of order
                    if (string.Compare(customers[j].Name, customers[j + 1].Name) > 0)
                    {
                        // Swap customers
                        Customer temp = customers[j]; // Temporary variable to hold the current customer
                        customers[j] = customers[j + 1]; // Move the next customer to the current position
                        customers[j + 1] = temp; // Place the current customer in the next position
                    }
                }
            }

            // Display all customer details sorted by name
            Console.WriteLine("Customer Details (Sorted by Name):");
            foreach (var customer in customers) // Iterate through each customer in the sorted array
            {
                Console.WriteLine(customer); // Print the details of each customer using ToString
            }
        }
    }
}
