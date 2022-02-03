using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Eventos
{
    public partial class Animales : Page
    {
         
        public Animales(string nombre, string sexo, string raza, string tamaño, string peso, string edad, string vacunado, string chip, string apadrinado )
        {
            Nombre = nombre;
            Sexo = sexo;
            Raza = raza;
            Tamano = tamaño;
            Peso = peso;
            Edad = edad;
            Vacunado = vacunado;
            Chip = chip;
            Apadrinado = apadrinado;
        }


        public Uri Caratula { set; get; }
        public string Nombre { set; get; }
        public string Sexo { set; get; }
        public string Raza { set; get; }
        public string Tamano { set; get; }
        public string Peso { set; get; }
        public string Edad { set; get; }
        public string Vacunado { set; get; }
        public string Chip { set; get; }
        public string Apadrinado { set; get; }

    }

}
