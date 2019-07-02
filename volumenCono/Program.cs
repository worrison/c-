
// 5º Actividad.
// Realizar un programa que nos pida el radio y la altura y nos calcule el volumen de un cono.
using System;

namespace volumenCono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el radio");
            double radio=double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la altura");
            double altura=double.Parse(Console.ReadLine());
            double pi=Math.PI,potencia=Math.Pow(radio,2);
            double volumen=pi*potencia*(altura/3);
            Console.WriteLine("el volumen es: "+volumen);
        }
    }
}
