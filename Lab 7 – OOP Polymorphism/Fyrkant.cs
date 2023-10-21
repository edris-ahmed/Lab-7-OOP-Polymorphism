using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double Side { get; set; }

        public Fyrkant() 
        {
            Side = 4.5;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
