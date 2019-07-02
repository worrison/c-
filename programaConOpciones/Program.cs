using System;

namespace programaConOpciones
{
    class Program
    {   enum Option {Suma, Resta, Division, Multiplicacion,Salir};
        static void suma(int n1,int n2)
        {
            int suma=n1+n2;
            Console.WriteLine("La Suma es:"+suma);
        }
        static void resta(int n1,int n2)
        {
            int resta=n1-n2;
            Console.WriteLine("La Resta es:"+resta);
        }

        static void multiplicacion(int n1,int n2)
        {
            int multiplica=n1*n2;
            Console.WriteLine("La multiplicacion es:"+multiplica);
        }
        static void division(int n1,int n2)
        {
            int divide=n1/n2;
            Console.WriteLine("La division es:"+divide);
        }
        static void Main(string[] args)
        {
            /***************************Menu*******************************/
            Console.WriteLine("Seleccione la funcion que desea hacer:");
            Console.WriteLine("Pulse 1 para "+Enum.GetName(typeof(Option), 0)+"\n"+
            "Pulse 2 para "+Enum.GetName(typeof(Option), 1)+"\n"+"Pulse 3 para "
            +Enum.GetName(typeof(Option), 2)+ "\n"+"Pulse 4 para "+
            Enum.GetName(typeof(Option), 3)+"\n");
            /***************************End Menu***************************/

            int option=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca Primer numero");
            int n1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca Segundo numero");
            int n2=Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:suma(n1,n2);break;
                case 2:resta(n1,n2);break;
                case 3:division(n1,n2);break;
                case 4:multiplicacion(n1,n2);break;
                case 0:break;
            }
            

        }
    }
}
