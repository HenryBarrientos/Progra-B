using System;

namespace DECLARACION
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            Char l;
            Console.WriteLine("ingrese letra");
            l = Convert.ToChar(Console.ReadLine());
            if (l>='a'||l<='z')
            {
                Console.WriteLine("Es minuscula");
            }
            else
            {
                Console.WriteLine("Es mayuscula");
            }
        }
    }
}




