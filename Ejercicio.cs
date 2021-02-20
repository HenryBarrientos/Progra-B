using System;

namespace Ejercicio3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double h, t, t1;              Console.Write("Ingrese total de horas trabajadas en la semana  ");             h = Convert.ToDouble(Console.ReadLine());              if (h <= 40)
            {                 t = 40 * 16;                 Console.WriteLine("La paga por las horas trabajadas es :  " + t);             }              if (h > 40)
            {                 t = h - 40;                  t1 = (t * 20) + 640;                  Console.WriteLine("La paga por las horas trabajadas es :  " + t1);

            } 
        }
    }
}
