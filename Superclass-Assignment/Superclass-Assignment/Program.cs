using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superclass_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { FirstName = "John", LastName = "Doe", Id = 4 };
            Employee employee2 = new Employee() { FirstName = "Jane", LastName = "Doe", Id = 76 };

            Console.ReadLine();
        }
    }
}
