namespace ticketCompra
{
    public class producto
    {
        private float precio;
        private string nombre;

        producto(float precio,string nombre)
        {
            setPrecio(precio);
            setNombre(nombre);
        }
        public float getPrecio()
        {
            return this.precio;
        }

        public void setPrecio(float precio)
        {
            this.precio = precio;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

    }
}