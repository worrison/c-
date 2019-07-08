using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_de_Cola_de_enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue <int>cola = new Queue<int>();
            cola.Enqueue(8);
            cola.Enqueue(18);
            cola.Enqueue(2);
            cola.Enqueue(3);
            cola.Enqueue(5);
            cola.Enqueue(9);

            int suma = 0;
            while (cola.Count>0)
            {
                suma += cola.Dequeue();
            }
            Console.WriteLine("La suma de la Cola es: " + suma);

        }
    }
}
