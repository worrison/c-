using System;

namespace numerosRoanos
{
    class Program
    {
        static int[] getMillarCentenaDecena(int numero)
        {
            int millares = numero / 1000;
            int restoMillares = numero % 1000;

            int centenas = restoMillares / 100;
            int restoCentenas = restoMillares % 100;

            int decenas = restoCentenas / 10;

            int unidades = restoCentenas % 10;
            int[] retornaNumeros = new int[] { millares, centenas, decenas, unidades };

            return (retornaNumeros);
        }
        static string convertToRomanos(int[] numeros)
        {
            string numeroRomano = "";
            int millar = numeros[0], centenas = numeros[1], decenas = numeros[2], unidades = numeros[3];
            switch (millar)
            {
                case 1: numeroRomano += "M"; break;
                case 2: numeroRomano += "MM"; break;
                case 3: numeroRomano += "MMM"; break;
            }
            switch (centenas)
            {
                case 1: numeroRomano += "C"; break;
                case 2: numeroRomano += "CC"; break;
                case 3: numeroRomano += "CCC"; break;
                case 4: numeroRomano += "CD"; break;
                case 5: numeroRomano += "D"; break;
                case 6: numeroRomano += "DC"; break;
                case 7: numeroRomano += "DCC"; break;
                case 8: numeroRomano += "DCCC"; break;
                case 9: numeroRomano += "CM"; break;
            }
            switch (decenas)
            {
                case 1: numeroRomano += "X"; break;
                case 2: numeroRomano += "XX"; break;
                case 3: numeroRomano += "XXX"; break;
                case 4: numeroRomano += "XL"; break;
                case 5: numeroRomano += "L"; break;
                case 6: numeroRomano += "LX"; break;
                case 7: numeroRomano += "LXX"; break;
                case 8: numeroRomano += "LXXX"; break;
                case 9: numeroRomano += "XC"; break;
            }
            switch (unidades)
            {
                case 1: numeroRomano += "I"; break;
                case 2: numeroRomano += "II"; break;
                case 3: numeroRomano += "III"; break;
                case 4: numeroRomano += "IV"; break;
                case 5: numeroRomano += "V"; break;
                case 6: numeroRomano += "VI"; break;
                case 7: numeroRomano += "VII"; break;
                case 8: numeroRomano += "VIII"; break;
                case 9: numeroRomano += "IX"; break;
            }
            return numeroRomano;

        }
        static void Main(string[] args)
        {
            // int numeroAConvertir = Int32.Parse(args[0]);
            Console.WriteLine("Introduzca un numero por inferior o igual a 3999 \n Para salir pulse 0");
            int numeroAConvertir;
            numeroAConvertir = Int32.Parse(Console.ReadLine());
            while (numeroAConvertir != 0)
            {
                if (numeroAConvertir <= 3999)
                {
                    int[] retornaNumeros = getMillarCentenaDecena(numeroAConvertir);
                    string numeroRomano = convertToRomanos(retornaNumeros);
                    Console.WriteLine("El numero " + " " + numeroAConvertir + " " + "pasado a numero romanos es: \n" + numeroRomano);
                }
                else
                {
                    Console.WriteLine("El número introducido es mayor de 3999 ha de introducir uno inferior o igual a este valor:");
                }
                Console.WriteLine("Introduzca un numero por inferior o igual a 3999 \n Para salir pulse 0");
                numeroAConvertir = Int32.Parse(Console.ReadLine());
            }

        }
    }
}
