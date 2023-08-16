using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_assignment
{
    class Employee : Person, IQuitable
    {
        public void Quit()
        {
            Console.WriteLine("Click the X in the top right corner to quit");
        }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            
        }
    }
}
