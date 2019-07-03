using System;

namespace vehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            vehiculo manolo= new vehiculo();
            vehiculo manolo2= new vehiculo(9);
            manolo.setNRuedas(4);
            manolo.setMotor("Gasolina");
            manolo.setCapacidad(8);
            // manolo.setColor("#000");
            manolo.setNumPuertas(2);
            manolo.setVelocidadMaxima(250);
            manolo.isIsAutomatico(false);
            
            manolo.parar();
            manolo.arrancar();
            manolo.arrancar();
            manolo.parar();
            bool devuelto=manolo2.comprobarBastidor("#1253498765");
            System.Console.WriteLine(manolo.getCapacidad()+manolo.getColor()+manolo2.getNumPuertas()+devuelto);
        }
    }
}
