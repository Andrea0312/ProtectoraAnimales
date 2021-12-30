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
    /// Lógica de interacción para Voluntarios.xaml
    /// </summary>
    public partial class Voluntarios : Page
    {
       
        private List<Voluntarios> listadoVoluntarios;
        public Voluntarios()
        {
            InitializeComponent();

            listadoVoluntarios = CargarContenidoXMLVoluntarios();
            DataContext = listadoVoluntarios;

        }
        private List<Voluntarios> CargarContenidoXMLVoluntarios()
        {
            List<Voluntarios> listadoV = new List<Voluntarios>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Datos/Voluntarios.xml", UriKind.Relative));
            doc.Load(fichero.Stream);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoVoluntario = new Voluntarios(" ", " ", " "," ", " ", " ");
                nuevoVoluntario.Nombre = node.Attributes["Nombre"].Value;
                nuevoVoluntario.Apellidos = node.Attributes["Apellidos"].Value;
                nuevoVoluntario.DNI = node.Attributes["DNI"].Value;
                nuevoVoluntario.DireccionCorreo = node.Attributes["DireccionCorreo"].Value;
                nuevoVoluntario.Telefono = node.Attributes["Telefono"].Value;
                nuevoVoluntario.HorasDisponible = node.Attributes["HorasDisponible"].Value;
                nuevoVoluntario.Caratula = new Uri(node.Attributes["Caratula"].Value, UriKind.Relative);

                listadoV.Add(nuevoVoluntario);
            }
            return listadoV;
        }
    }
}
