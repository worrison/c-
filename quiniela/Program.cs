using System;

namespace quiniela
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int apuestas=15;
            int[] quiniela1= new int[apuestas];
            int[] quiniela2= new int[apuestas];
            int[] quiniela3= new int[apuestas];
            int randomNumber;
            for (int i = 0; i < 15; i++)
            {
                randomNumber=rnd.Next(0,100);
                if(randomNumber>50)
                {
                    quiniela1[i]=2;
                    quiniela2[i]=1;
                    quiniela3[i]=1;
                }else if(randomNumber<50)
                {
                    quiniela1[i]=1;
                    quiniela2[i]=2;
                    quiniela3[i]=0;
                }else{
                    quiniela1[i]=0;
                    quiniela2[i]=1;
                    quiniela3[i]=0;
                }
            }
            Console.WriteLine("Primera Quiniela: "+string.Join("", quiniela1));
            Console.WriteLine("Segunda Quiniela: "+string.Join("", quiniela2));
            Console.WriteLine("Tercera Quiniela: "+string.Join("", quiniela3));
        }
    }
}
