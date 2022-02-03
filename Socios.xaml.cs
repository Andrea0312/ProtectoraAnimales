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
        public List<Socios> listadoSocios;
        public Socios()
        {
            InitializeComponent();
            listadoSocios = CargarContenidoXMLSocios();
            DataContext = listadoSocios;
        }
    
        public List<Socios> CargarContenidoXMLSocios()
        {
            List<Socios> listadoS = new List<Socios>();
            XmlDocument doc = new XmlDocument();
            try { doc.Load("Socios.xml"); }
            catch (System.IO.FileNotFoundException)
            {
                doc.LoadXml("<?xml version=\"1.0\"?> \n" +
                "<Socios> \n" +
                " <Socio Nombre=\"Pedro\" Apellidos=\"Sanchéz\" DNI=\"08926552P\" DireccionCorreo=\"pedro@alu.uclm.es\" " +
                "Telefono=\"642945555\" DatosBancarios=\"ES39 7890 6784 3485 2845\"  FormaPago=\"Tarjeta\" Caratula=\"imagenesSocios/1.png\"/>\n" +
                "</Socios>");
                doc.Save("Socios.xml");
            }

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                var nuevoSocio = new Socios(" ", " ", " "," ", " ", " ","" );
                nuevoSocio.Nombre = node.Attributes["Nombre"].Value;
                nuevoSocio.Apellidos = node.Attributes["Apellidos"].Value;
                nuevoSocio.DNI = node.Attributes["DNI"].Value;
                nuevoSocio.DireccionCorreo = node.Attributes["DireccionCorreo"].Value;
                nuevoSocio.Telefono = node.Attributes["Telefono"].Value;
                nuevoSocio.DatosBancarios = node.Attributes["DatosBancarios"].Value;
                nuevoSocio.FormaPago = node.Attributes["FormaPago"].Value;
                nuevoSocio.Caratula = new Uri(node.Attributes["Caratula"].Value, UriKind.Relative);

                listadoS.Add(nuevoSocio);
            }
            return listadoS;
        }

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            FormularioSocio formularioSocio = new FormularioSocio(this);
            formularioSocio.ShowDialog();
            lstListaSocios.Items.Refresh();

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Socios.xml");

            XmlNode j = GetSocio(lblDNI.Content.ToString(), doc);
            XmlElement root = doc.DocumentElement;
            if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Protectora Juni", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                root.RemoveChild(j);
                doc.Save("Socios.xml");

                listadoSocios.RemoveAt(lstListaSocios.SelectedIndex);
                lstListaSocios.Items.Refresh();
            }
        }

        public XmlNode GetSocio(string DNI, XmlDocument doc)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("So", "");
            string xPathString = "//So:Socios/So:Socio[@DNI='" + DNI + "']";
            XmlNode xmlNode = doc.DocumentElement.SelectSingleNode(xPathString, nsmgr);
            return xmlNode;
        }

        private void btn_editar_Click(object sender, RoutedEventArgs e)
        {
            FormularioSocio formulario = new FormularioSocio(this);

            formulario.txtDNI.Text = lblDNI.Content.ToString();
            formulario.txtDNI.IsEnabled = false;
            formulario.txtNombre.Text = lblNombre.Content.ToString();
            formulario.txtApellidos.Text = lblApellido.Content.ToString();
            formulario.txtTelefono.Text = lblTelefono.Content.ToString();
            formulario.txtCorreo.Text = lblCorreo.Content.ToString();
            formulario.txtDbancarios.Text = lblDatosB.Content.ToString();
            formulario.txtFormaPago.Text = lblPago.Content.ToString();

            formulario.Show();

        }
    }
}
