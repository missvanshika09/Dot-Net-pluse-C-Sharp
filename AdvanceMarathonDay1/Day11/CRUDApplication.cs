//clss 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_List_current
{
    public enum Dept
    {
        HR,
        Payroll,
        IT
    }

    internal class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public Dept? Department { get; set; } // any givien vlaue of the givien set ie enum only otherwise compile time error


        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Id, Name, Email, Department);
        }
    }
}
//interface 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_List_current
{
    internal interface IEmpService
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();

    }
}



//class2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_List_current
{
    internal class EmployeeService : IEmpService
    {
        private static List<Employee> _employeeList; //

        public EmployeeService()
        {
            _employeeList = new List<Employee>(){
        new Employee { Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@CDACtech.com" },
        new Employee { Id = 2, Name = "John", Department = Dept.IT, Email = "john@CDACtech.com" },
        new Employee { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@CDACtech.com" },
              };
        }
        //public Employee Add(Employee employee)
        //{
        //    employee.Id = _employeeList.Max(e => e.Id) + 1;
        //    _employeeList.Add(employee);
        //    return employee;
        //}
        //public Employee Delete(int Id)
        //{
        //    // _employeeList.Find(e => e.Id == Id);
        //    Employee employee = _employeeList.FirstOrDefault(e => e.Id == Id);
        //    if (employee != null)
        //    {
        //        _employeeList.Remove(employee);
        //    }
        //    return employee;
        //}
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);//find is not extension method  but firstor default is first match ko return karo ya default me null .
        }

        //public IEnumerable<Employee> GetEmployee(string name)
        //{
        //    return _employeeList.FindAll(e => e.Name == name);
        //}
    }

}
//Main Entry
namespace Day11_List_current
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling class");
            IEmpService empService = new EmployeeService();//creating reference
            Employee e1 = empService.GetEmployee(1);
            Console.WriteLine($"record of {e1.Id}==>{e1}");

            var list = empService.GetAllEmployee();
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }


        }
    }
}
/*
class Program
{
    static void Main(string[] args)
    {
            IEmpService empService = new EmployeeService();
           Employee e1= empService.Add(new Employee { Name = "Sonam", Department = Dept.IT, Email = "som@CDACtech.com" });
            Console.WriteLine($"{e1} Added in cpllection");
            e1 = empService.Add(new Employee { Name = "Sonam", Department = Dept.HR , Email= "sonam@CDACtech.com" });
            Console.WriteLine($"{e1} Added in collection");
            e1 = empService.Delete(3);
            Console.WriteLine($"{e1} Deleted from n collection");

            e1 = empService.GetEmployee(1);
            Console.WriteLine($"record of {e1.Id}==>{e1}");

            IEnumerable<Employee> list = empService.GetEmployee("Sonam");
            Console.WriteLine($"record of with name Sonam");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }
            list = empService.GetAllEmployee();
            var options = new JsonSerializerOptions
            {  WriteIndented = true,
                Converters = {new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)   }
            };
            foreach (Employee emp in list)
            {                
                Console.WriteLine(JsonSerializer.Serialize(emp,options));
            }

        }
    }
*/
