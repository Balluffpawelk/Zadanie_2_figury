using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_figury
{
    class Circle:figury
    {
        public int R { get; private set; }

        public override double Area()
        {
            return Math.Pow(2,R)*Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * R* Math.PI;
        }
        public Circle(int r)
        {
            R = r;
        }

        public override double Diagonal()
        {
            return 2 * R;

        }

        public override void PRNT()
        {
            Console.WriteLine("I'm a circle!");

        }

    }
}
