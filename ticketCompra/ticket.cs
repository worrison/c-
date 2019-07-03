namespace ticketCompra
{
    public class ticket
    {
        private string producto;
        private float precio;
        private int cantidad;
        private float totalLinea;
        private float totalTicket;



        ticket(int cantidad)
        {
            producto product = new producto(1,"Tomate");
            setProducto(product.getNombre());
            setPrecio(product.getPrecio());
            setCantidad(cantidad);
            float totalLinea = cantidad * getPrecio();
            setTotalLinea(totalLinea);
            // setTotalTicket(totalTicket);
        }
        public string getProducto()
        {
            return this.producto;
        }

        public void setProducto(string producto)
        {
            this.producto = producto;
        }
        public float getPrecio()
        {
            return this.precio;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public float getTotalLinea()
        {
            return this.totalLinea;
        }

        public void setTotalLinea(float totalLinea)
        {
            this.totalLinea = totalLinea;
        }
        public float getTotalTicket()
        {
            return this.totalTicket;
        }

        public void setTotalTicket(float totalTicket)
        {
            this.totalTicket = totalTicket;
        }


    }
}