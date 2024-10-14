using System;

namespace ques7
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public dept Department { get; set; }

        public enum dept
        {
            MKT = 1,
            ADV = 2,
            ADMN = 3
        }

        public Employee(int id, string name, double salary, dept department)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.Department = department;
        }

        public override string ToString()
        {
            return string.Format("id={0}, name={1}, salary={2}, department={3}", id, name, salary, Department);
        }

        public static void showdeptwise(Employee[] emp)
        {
            double dmk = 0, davt = 0, dmn = 0;

            for (int i = 0; i < emp.Length; i++)
            {
                switch (emp[i].Department)
                {
                    case dept.MKT:
                        dmk += emp[i].salary;
                        break;
                    case dept.ADV:
                        davt += emp[i].salary;
                        break;
                    case dept.ADMN:
                        dmn += emp[i].salary;
                        break;
                }
            }

            Console.WriteLine("MKT department spend {0} on salary", dmk);
            Console.WriteLine("ADV department spend {0} on salary", davt);
            Console.WriteLine("ADMN department spend {0} on salary", dmn);
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Employee[] emp = new Employee[4];

        emp[0] = new Employee(1, "Raj", 3000, Employee.dept.ADMN);
        emp[1] = new Employee(2, "Reena", 2000, Employee.dept.ADMN);
        emp[2] = new Employee(3, "Geeta", 1000, Employee.dept.MKT);
        emp[3] = new Employee(4, "Geet", 2500, Employee.dept.ADV);

        foreach (var employee in emp)
        {
            Console.WriteLine(employee);
        }

        Employee.showdeptwise(emp);
    }
}
