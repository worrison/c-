using System;

namespace _2bisiesto
{
    class Program
    {
        static bool bisiesto(int fecha){
            return fecha % 400 == 0 || fecha %4 == 0 && fecha %4 != 0;
        }
        static void Main(string[] args)
        {
            int fecha = Int32.Parse(args[0]);
            bool resultado=bisiesto(fecha);
            Console.WriteLine(resultado ? "es bisiesto":"no es bisiesto");
        }
    }
}
