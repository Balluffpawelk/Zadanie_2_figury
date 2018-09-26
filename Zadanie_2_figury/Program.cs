using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_figury
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Square kwadrat = new Square(4);
            kwadrat.Print();
            Console.ReadLine();

            Circle kolo = new Circle(4);
            kolo.Print();
            Console.ReadLine();
        
        }
    }
}
