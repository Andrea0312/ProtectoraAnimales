using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Eventos
{
    public partial class Voluntarios: Page
    {
        public Voluntarios(string nombre, string apellidos, string dni, string correo, string telefono, string horasDisponibles )
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dni;
            DireccionCorreo = correo;
            Telefono = telefono;
            HorasDisponible = horasDisponibles;

        }

        public Uri Caratula { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string DNI { set; get; }
        public string DireccionCorreo { set; get; }
        public string Telefono { set; get; }
        public string HorasDisponible { set; get; }
    }
}
