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
using System.Windows.Shapes;
using System.Xml;

namespace Eventos
{
    /// <summary>
    /// Lógica de interacción para FormularioSocio.xaml
    /// </summary>
    public partial class FormularioSocio : Window
    {
        Socios padre;
        private List<Socios> listadoSocios = new List<Socios>();

        public FormularioSocio(Socios padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            
     
            String Nombre = txtNombre.Text;
            String Apellidos = txtApellidos.Text;
            String DNI = txtDNI.Text;
            String DireccionCorreo = txtCorreo.Text;
            String Telefono = txtTelefono.Text;
            String DatosBancarios = txtDbancarios.Text;
            String FormaPago = txtFormaPago.Text;

            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Socios.xml");

            XmlElement h = añadirSocio(Nombre, Apellidos, DNI, DireccionCorreo, Telefono, DatosBancarios, FormaPago, doc);
            XmlNode j = GetSocio(txtDNI.Text, doc);
            XmlElement root = doc.DocumentElement;
            if (j != null)
            {
                root.RemoveChild(j);
            }
            
            root.AppendChild(h);
            doc.Save("Socios.xml");
            padre.listadoSocios = padre.CargarContenidoXMLSocios();
            padre.DataContext = padre.listadoSocios;

            MessageBox.Show("Datos añadidios correctamente.", "Protectora Juni", MessageBoxButton.OK);
            this.Close();
            
        }

        public XmlNode GetSocio(string DNI, XmlDocument doc)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("So", "");
            string xPathString = "//So:Socios/So:Socio[@DNI='" + DNI + "']";
            XmlNode xmlNode = doc.DocumentElement.SelectSingleNode(xPathString, nsmgr);
            return xmlNode;
        }
        public XmlElement añadirSocio(string nombre, string apellido, string DNI,
string correo, string telefono, string banco, string pago, XmlDocument doc)
        {

            XmlElement socio = doc.CreateElement("Socio", "");


            XmlAttribute attribute = doc.CreateAttribute("Nombre");
            attribute.Value = nombre;
            socio.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Apellidos");
            attribute.Value = apellido;
            socio.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("DNI");
            attribute.Value = DNI;
            socio.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("DireccionCorreo");
            attribute.Value = correo;
            socio.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Telefono");
            attribute.Value = telefono;
            socio.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("DatosBancarios");
            attribute.Value = banco;
            socio.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("FormaPago");
            attribute.Value = pago;
            socio.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Caratula");
            attribute.Value = "imagenesSocios/1.png";
            socio.Attributes.Append(attribute);

            socio.InnerText = "\n";

            return socio;
        }
    }
}
