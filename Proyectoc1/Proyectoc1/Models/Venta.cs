namespace Proyectoc1.Models
{
    public class Venta
    {
        private int id_venta;
        private string nombre;
        private DateTime fecha;
        private int precio_total;

        public Venta()
        {
        }

        public Venta(int id_venta, string nombre, DateTime fecha, int precio_total)
        {
            this.Id_venta = id_venta;
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Precio_total = precio_total;
        }

        public int Id_venta { get => id_venta; set => id_venta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Precio_total { get => precio_total; set => precio_total = value; }
    }
}
