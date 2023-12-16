using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ellipse:Circle
    {
        public Ellipse():base(4)
        {
            
        }

        public override double Area()
        {
            return -1;
        }

        public new void Display()
        {
            Console.WriteLine("New");
        }

    }
}
