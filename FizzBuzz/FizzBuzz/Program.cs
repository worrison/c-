using System;
/*Escribe un programa que imprima los número del 1 al 100, pero aplicando las siguientes normas: 
 * Devuelve Fizz si el número es = 3 o divisible por 3. 
 * Devuelve Buzz si el número es = 5 o divisible por 5. 
 * Devuelve FizzBuzz si el número es divisible por 3 y por 5.
 * */
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int INICIO = 1, FIN = 100;

            for(int i=INICIO;i<=FIN;i++)
            {
                if (i % 3 == 0 && i % 5 == 0 )
                {
                    Console.WriteLine("FizzBuzz");
                }else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
