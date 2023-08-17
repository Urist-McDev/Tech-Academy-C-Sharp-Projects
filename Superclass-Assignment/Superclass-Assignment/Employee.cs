using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superclass_Assignment
{
    class Employee : Person
    {
        public int Id { get; set; }

        public static Employee operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return employee1;
            }
            return employee2;
        }

        public static Employee operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return employee2;
            }
            return employee1;
        }
    }
}
