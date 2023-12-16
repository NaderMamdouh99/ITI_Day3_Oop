using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle:Shap
    {
        public int Radius { get; set; }
        public int Height = 2;


        public Circle(int _radius):base(2,4)
        {
            Radius = _radius;
        }

        #region Function Area
        public virtual double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double Area(int _Number)
        {
            Height = _Number;
            return Math.PI * Math.Pow(Radius, _Number);
        }
        public double Area(double _Number)
        {

            return Math.PI * Math.Pow(Radius, _Number);
        }
        #endregion

        #region Override The Display Function

        public override void Display()
        {
            Console.WriteLine($"X= {X}\nY= {Y}\nRadius= {Radius}");
        }
        #endregion
    }
}
