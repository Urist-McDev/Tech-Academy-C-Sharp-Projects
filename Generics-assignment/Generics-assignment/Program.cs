using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Names = new Employee<string>();
            Names.Things = new List<string>();
            Employee<int> Ids = new Employee<int>();
            Ids.Things = new List<int>();

            Names.Things.Add("John");
            Names.Things.Add("Max");
            Names.Things.Add("Jane");

            Ids.Things.Add(1);
            Ids.Things.Add(2);
            Ids.Things.Add(3);

            foreach (string name in Names.Things)
            {
                Console.WriteLine("Name: " + name);
            }

            foreach (int id in Ids.Things)
            {
                Console.WriteLine("ID: " + id);
            }
            Console.ReadLine();
        }
    }
}
