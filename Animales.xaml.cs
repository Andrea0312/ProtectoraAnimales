using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace Eventos
{
    /// <summary>
    /// Lógica de interacción para Animales.xaml
    /// </summary>
    public partial class Animales : Page
    {
        private List<Animales> listadoAnimales;
        public Animales()
        {
            InitializeComponent();
            listadoAnimales = CargarContenidoXML();
            DataContext = listadoAnimales;
        }

        private List<Animales> CargarContenidoXML()
        {
            List<Animales> listadoA = new List<Animales>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Datos/Animales.xml", UriKind.Relative));
            doc.Load(fichero.Stream);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoAnimal = new Animales(" ", " ", " ", " ", " ", " ", " ", " " ," ");
                nuevoAnimal.Nombre = node.Attributes["Nombre"].Value;
                nuevoAnimal.Sexo = node.Attributes["Sexo"].Value;
                nuevoAnimal.Raza = node.Attributes["Raza"].Value;
                nuevoAnimal.Tamano = node.Attributes["Tamano"].Value;
                nuevoAnimal.Peso = node.Attributes["Peso"].Value;
                nuevoAnimal.Edad = node.Attributes["Edad"].Value;
                nuevoAnimal.Vacunado = node.Attributes["Vacunado"].Value;
                nuevoAnimal.Chip = node.Attributes["Chip"].Value;
                nuevoAnimal.Apadrinado = node.Attributes["Apadrinado"].Value;
                nuevoAnimal.Caratula = new Uri(node.Attributes["Caratula"].Value, UriKind.Relative);

                listadoA.Add(nuevoAnimal);
            }
            return listadoA;
        }
    }
}
