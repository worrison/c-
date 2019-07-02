using System;

namespace potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca Base");
            double Base=double.Parse(Console.ReadLine());
            System.Console.WriteLine("introduzca exponencia");
            double exponencia=double.Parse(Console.ReadLine());
            double resultado=Math.Pow(Base,exponencia);
            System.Console.WriteLine("Resultado "+resultado);
        }
    }
}
