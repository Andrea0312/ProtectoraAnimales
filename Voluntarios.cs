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
        public Voluntarios(string nombre, string apellidos, string dni)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dni;

        }

        public string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string DNI { set; get; }
    }
}
