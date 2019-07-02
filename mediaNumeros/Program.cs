using System;

namespace mediaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamano=args.Length,suma=0;

            for(int i=0; i< tamano; i++)
            {
                System.Console.WriteLine(args[i]);
                suma+=Int32.Parse(args[i]);
            }
            Console.WriteLine("Media: "+suma/tamano);
        }
    }
}
