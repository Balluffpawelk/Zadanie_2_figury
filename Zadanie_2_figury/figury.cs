using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_figury
{
    abstract class figury
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract double Diagonal();
        public abstract void PRNT();
        public virtual void Print()
        {
            PRNT();
            Console.WriteLine($"Area: {Area()} Perimeter: {Perimeter()} Diagonal:{Diagonal()}");
            
        }

    }
}
