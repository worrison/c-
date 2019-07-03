using System;

namespace ticketCompra
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Almacen */
            producto almacen = new producto();
            almacen.setNombre("tomates");
            almacen.setPrecio(1);
            // almacen.setNombre("patatas");
            // almacen.setPrecio(2);
            // almacen.setNombre("pan");
            // almacen.Precio(0.7);

            /* Líneas de Ticket*/
            
            int cantidadLineas=10;
            for (int i = 0; i < cantidadLineas; i++)
            {
                ticket[] linea = new ticket();
                System.Console.WriteLine("Introduzca cantidad");
                int cantiad=Int32.Parse(System.Console.ReadLine());
                linea[i].setCantidad=cantiad;
            }
            for (int j = 0; j < cantidadLineas; j++)
            {
               System.Console.WriteLine(linea[j].getCantidad()+linea[j].getProducto());  
            }
    
        }
    }
}
