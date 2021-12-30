using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Eventos
{
   public partial class Socios : Page
    {
        public Socios(string nombre,string apellidos, string dni, string direcccionCorreo, string telefono, string datosBancarios, string formaPago)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dni;
            DatosBancarios = datosBancarios;
            DireccionCorreo = direcccionCorreo;
            Telefono = telefono;
            FormaPago = formaPago;

        }

        public Uri Caratula { set; get; }
        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string DNI { set; get; }
        public string Telefono { set; get; }
        public string DatosBancarios { set; get; }
        public string DireccionCorreo { set; get; }
        public string FormaPago { set; get; }

    }
}
