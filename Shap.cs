using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shap
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Shap(int _x,int _y)
        {
            X=_x;
            Y=_y;
        }


        public virtual void Display()
        {
            Console.WriteLine($"X = {X}\n Y= {Y}");
        }
    }
}
