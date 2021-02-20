using System;

namespace EJERCICIO5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a,r;
            Console.WriteLine("ingrese el radio ");
            a = Convert.ToDouble(Console.ReadLine());
            r = (a * a) * 3.1416;
            Console.WriteLine("ingrese el area " + r );
        }
    }
}
