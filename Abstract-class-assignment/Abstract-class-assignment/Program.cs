﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            IQuitable quitable = new Employee();
            quitable.Quit();
            employee.SayName();
            Console.ReadLine();
        }
    }
}
