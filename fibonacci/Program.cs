using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, limite, i, aux; 
            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            limite = int.Parse(Console.ReadLine()); 
            a = 0;
            b = 1; 
            for (i = 0; i < limite; i++)  
            {
                aux = a;
                a = b; 
                b = aux + a; 
                Console.WriteLine(a); 
            }
        }
    }
}
