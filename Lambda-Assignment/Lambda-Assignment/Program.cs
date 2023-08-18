using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Doe", Id = 1 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Smith", Id = 2 });
            employees.Add(new Employee() { FirstName = "Jane", LastName = "Winters", Id = 3 });
            employees.Add(new Employee() { FirstName = "Doctor", LastName = "Freeman", Id = 4 });
            employees.Add(new Employee() { FirstName = "Silva", LastName = "Ragnar", Id = 5 });
            employees.Add(new Employee() { FirstName = "Big", LastName = "Chungus", Id = 6 });
            employees.Add(new Employee() { FirstName = "Amoung", LastName = "Us", Id = 7 });
            employees.Add(new Employee() { FirstName = "Wot", LastName = "Kilo", Id = 8 });
            employees.Add(new Employee() { FirstName = "Ounce", LastName = "Biggerton", Id = 9 });
            employees.Add(new Employee() { FirstName = "Da", LastName = "Boi", Id = 10 });

            List<Employee> joeEmployees = employees.Where(x => x.FirstName == "Joe").ToList();
            List<Employee> overFive = employees.Where(x => x.Id > 5).ToList();

            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        joeEmployees.Add(employee);
            //    }
            //}
        }
    }
}
