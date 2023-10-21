using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Polymorphism
{
    internal class Parallellogram : Geometri
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Parallellogram()
        {
            Base = 4.2;
            Height = 9.1;
        }

        public override double Area()
        {
            return Base * Height;
        }
    }


}
