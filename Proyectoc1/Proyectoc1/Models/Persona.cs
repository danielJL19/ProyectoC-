using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectoc1.Models
{
    public class Persona
    {
        private string nombre;
        private string correoElectronico;
        private string contrasena;

        public Persona()
        {
        }

        public Persona(string nombre, string correoElectronico, string contrasena)
        {
            this.Nombre = nombre;
            this.CorreoElectronico = correoElectronico;
            this.Contrasena = contrasena;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
    }
}
