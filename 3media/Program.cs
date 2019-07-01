using System;

namespace _3media
{
    class Program
    {
        static float media(string[] numeros,int cantidad)
        {
            int i;
            int suma=0;
            float resultado;
            for(i=0; i<cantidad; i++)
            {
                suma+=Int32.Parse(numeros[i]);
            }
            return resultado=suma/2;
        }
        static void Main(string[] args)
        {
            int cantidad= args.Length;
            float resultado=media(args,cantidad);
            
            Console.WriteLine(resultado);
        }
    }
}
