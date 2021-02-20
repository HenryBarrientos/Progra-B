using System;

namespace ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num, des, res;              Console.Write("Ingrese el total de su compra ");             num = Convert.ToDouble(Console.ReadLine());             des = num * 20 / 100;             res = num - des;             if (num >= 300)
            {                 Console.WriteLine("su total a pagar con el descuento es:  " + res);             }             else             {                 Console.WriteLine("su total a pagar sin el descuento es:  " + num);             }
        }
    }
}
