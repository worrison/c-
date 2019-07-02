using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres= {"Manolo","Victor","Paz","Veronica","Nacho","Mirian","Steven","David"};
            // foreach (var nombre in nombres)
            // {
            //     Console.WriteLine(nombre);
            // }
            string separador="Nombre:";
            Console.WriteLine(separador+string.Join("\n"+separador, nombres));

            int hasta = 500,indice=0,desde=100,length= hasta-desde+1;

            int[] numeros=new int[length];
            for (int i = desde; i <= hasta; i++)
            {
                numeros[indice]=i;
                indice++;
            }
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
            
        }
        
    }
}
