using System;

namespace ejercicio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numero, i, x = 0;             string resultado;              Console.Write("Introduce un numero mayor que 1: ");             int.TryParse(Console.ReadLine(), out numero);


            for (i = 2; i < numero; i++)
            {

                if (numero % i == 0)
                    x = 0 + 1;
            }

            if (x >= 1)
                resultado = "No es primo";
            else
                resultado = "Es primo";
            Console.WriteLine("{0}", resultado);
            Console.ReadLine(); 
        }
    }
}
