using System;

namespace numerosRoanos
{
    class Program
    {
        static string romanos(int numeros)
        {
            string numeroRomano="";
            while (numeros > 0)
            {
                switch (numeros)
                {
                    case numeros >=1000:
                        {
                            numeros-=1000;
                            numeroRomano+="M";
                            break;
                        };
                    case numeros >= 500:
                        {
                            numeros-=500;
                            numeroRomano+="D";
                            break;
                        }
                }
            }
            return numeroRomano;

        }
        static void Main(string[] args)
        {
            int numeroAConvertir = Int32.Parse(args[0]);
            string nuemroRomano = romanos(numeroAConvertir);
        }
    }
}
