using System;
namespace vehiculos
{
    public class vehiculo
    {
        private byte nRuedas;
        public static byte volante = 1;
        public bool arrancado = false;
        private byte capacidad = 0;
        private string motor;
        private string color;
        public string[] combustile;
        private byte numPuertas = 0;
        private bool isAutomatico = false;
        private byte velocidadMaxima = 0;
        private string nBastidor;

        public vehiculo()
        {
            this.setColor("azul");
        }
        public vehiculo(byte puertas)
        {
            this.setColor("azul");
            this.setNumPuertas(puertas);
        }
        public void arrancar()
        {
            if (this.arrancado == false)
            {
                this.arrancado = true;
                // Console.WriteLine("brrrrrrrrruuunnn Arrancado: " + manolo.arrancado);
            }

        }
        public void parar()
        {

            if (this.arrancado)
            {
                this.arrancado = false;
                // Console.WriteLine("psssssss: Parado" + manolo.arrancado);
            }
        }
       
        private void numBastidor()
        {   
            string nBastidor="#";
            int length=10;
            Random position = new Random();
            for (int i = 0; i < length; i++)
            {
                nBastidor += position.Next(0, 100);
            }
            this.nBastidor=nBastidor;
            System.Console.WriteLine(this.nBastidor);
        }
        public bool comprobarBastidor(string bastidor)
        {
            return this.nBastidor==bastidor;
        }
        public byte getNRuedas()
        {
            return this.nRuedas;
        }

        public void setNRuedas(byte nRuedas)
        {
            this.nRuedas = nRuedas;
        }
        public byte getNumPuertas()
        {
            return this.numPuertas;
        }

        public void setNumPuertas(byte numPuertas)
        {
            this.numPuertas = numPuertas;
        }
        public string getColor()
        {
            return this.color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }
        
        public string getMotor()
        {
            return this.motor;
        }

        public void setMotor(string motor)
        {
            this.motor = motor;
        }
        public byte getCapacidad()
        {
            return this.capacidad;
        }

        public void setCapacidad(byte capacidad)
        {
            this.capacidad = capacidad;
        }
        public bool getIsAutomatico()
        {
            return this.isAutomatico;
        }

        public void isIsAutomatico(bool isAutomatico)
        {
            this.isAutomatico = isAutomatico;
        }
        public byte getVelocidadMaxima()
        {
            return this.velocidadMaxima;
        }

        public void setVelocidadMaxima(byte velocidadMaxima)
        {
            this.velocidadMaxima = velocidadMaxima;
        }


    }
}