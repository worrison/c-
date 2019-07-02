using System;

namespace numerosInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamano=5,i;
            string[] inversa=new string[tamano];
            for(i=0; i<tamano;i++)
            {
                inversa[i]=args[tamano-i-1];
            }
            Console.WriteLine(string.Join("\n", inversa));
        }
    }
}
