using System;
// 4º Actividad.
// Realizar un programa que no pida un unidad en kb y nos haga la conversión a MB
namespace conversionKB
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero en Kb a convertir a MB");
            double kb=Double.Parse(Console.ReadLine());
            double mb=kb/1024;
            Console.WriteLine("La conversion en Mb es:"+mb);
        }
    }
}
