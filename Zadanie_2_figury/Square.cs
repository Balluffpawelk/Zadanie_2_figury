using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_figury
{
    class Square : figury
    {
        public int A { get; private set; }

        public override double Area()
        {
            
            
            return A * A;
        }   

        public override double Perimeter()
        {
            
            
            return 4 * A;
        }
        public Square(int a)
        {
            A=a;
        }

        public override double Diagonal()
        {
            return Math.Sqrt(2) * A;

        }
        public override void PRNT()
        {
            Console.WriteLine("I'm a square!");

        }

    }
}
