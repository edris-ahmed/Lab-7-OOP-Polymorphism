using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public double Minor_Axis { get; set; }
        public double Major_Axis { get; set; }

        public Ellips() 
        {
            Minor_Axis = 3.8;
            Major_Axis = 5.9;
        }

        public override double Area()
        {
            return Minor_Axis * Major_Axis * Math.PI;
        }
    }
}
