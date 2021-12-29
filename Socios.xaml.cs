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
    /// Lógica de interacción para Socios.xaml
    /// </summary>
    public partial class Socios : Page
    {
        private List<Socios> listadoSocios;
        public Socios()
        {
            InitializeComponent();
            listadoSocios = CargarContenidoXMLSocios();
            DataContext = listadoSocios;
        }
    
        private List<Socios> CargarContenidoXMLSocios()
        {
            List<Socios> listadoS = new List<Socios>();
            XmlDocument doc = new XmlDocument();
            var fichero = Application.GetResourceStream(new Uri("Datos/Socios.xml", UriKind.Relative));
            doc.Load(fichero.Stream);

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoSocio = new Socios(" ", " ", " ");
                nuevoSocio.Nombre = node.Attributes["Nombre"].Value;
                nuevoSocio.Apellidos = node.Attributes["Apellidos"].Value;
                nuevoSocio.DNI = node.Attributes["DNI"].Value;

                listadoS.Add(nuevoSocio);
            }
            return listadoS;
        }


        private void miAniadirItemLB_Click(object sender, RoutedEventArgs e)
        {

            }

        private void miEliminarItemLB_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
