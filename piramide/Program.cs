using System;

namespace piramide
{
    class Program
    {
        static void piramide (int elementos)
        {
            int i=0;
            string texto="";
            char caracter='*',espacio=' ';
            while(i<=elementos)
            {
                texto=texto.PadRight(i, caracter);
                texto=texto.PadLeft(elementos-i,espacio);
                
                Console.WriteLine(texto);
                i++;
            }
        }
        static void Main(string[] args)
        {
            piramide(Int32.Parse(args[0])); 
        }
    }
}
