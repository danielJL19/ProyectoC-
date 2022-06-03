namespace Proyectoc1.Models
{
    public class Producto
    {
        private int id_producto;
        private string nombre;
        private int precio;
        private int stock;
        private char categoria;

        public Producto()
        {
        }

        public Producto(int id_producto, string nombre, int precio, int stock, char categoria)
        {
            this.Id_producto = id_producto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.Categoria = categoria;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public char Categoria { get => categoria; set => categoria = value; }
    }
}
