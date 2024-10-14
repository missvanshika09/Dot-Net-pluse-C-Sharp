using System;
namespace ConsoleApplicationdemo
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee e1=new  Employee("Raj",50000 );
           e1.display();
        }
    }
    class Employee
    {
        double salary;
        string name;

        public Employee(string name ,double salary)
        {
            salary = salary;
            name = name;
        }
        public void display()
        {
            Console.WriteLine("{0}{1}", name, salary);
        }
       
    
     }
}
/*C# code has a small issue with the constructor of the Employee class. The parameters name and salary in the constructor are shadowing the instance variables of the same name. To fix this, you can use the this keyword to distinguish between the instance variables and the parameters. */
