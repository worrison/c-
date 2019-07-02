using System;

namespace positivosnegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int positivos=0,negativos=0,num=0;
            foreach (string numero in args)
            {
                num=Int32.Parse(numero);
                if(num != 0)
                {
                    num>0 ? positivos++ : negativos++;
                }
            }
           
            System.Console.WriteLine("Positivos: "+positivos+"negativos: "+negativos);
        }
    }
}
