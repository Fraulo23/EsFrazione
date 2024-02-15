using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsFrazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(5, 3);
            Fraction f2 = new Fraction(7, 9);
            if (f1 == f2)
            {
                Console.WriteLine("Sono uguali");
            }
            else
            {
                Console.WriteLine("Sono diverse");
            }
            if (f1 > f2)
            {
                Console.WriteLine("{0} è maggiore di {1}",f1,f2);
            }
            else
            {
                Console.WriteLine("{0} è minore di {1}", f1, f2);
            }
            Console.ReadLine();
        }
    }
}
