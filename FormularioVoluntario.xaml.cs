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
    /// Lógica de interacción para FormularioVoluntario.xaml
    /// </summary>
    public partial class FormularioVoluntario : Window
    {
        private List<Voluntarios> listadoVoluntarios= new List<Voluntarios> ();

        Voluntarios padre;
        public FormularioVoluntario(Voluntarios padre)
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
            String HorasDisponible = txtHorasDip.Text;

            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Voluntarios.xml");

            XmlElement h = añadirVoluntario(Nombre, Apellidos, DNI, DireccionCorreo, Telefono, HorasDisponible, doc);
            XmlNode j = GetVoluntario(txtDNI.Text, doc);
            XmlElement root = doc.DocumentElement;
            if (j != null)
            {
                root.RemoveChild(j);
            }
            
           
            root.AppendChild(h);
            doc.Save("Voluntarios.xml");
            padre.listadoVoluntarios = padre.CargarContenidoXMLVoluntarios();
            padre.DataContext = padre.listadoVoluntarios;

            MessageBox.Show("Datos añadidios correctamente.","Protectora Juni",MessageBoxButton.OK);
            this.Close();

        }
        public XmlNode GetVoluntario(string DNI, XmlDocument doc)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("Vo", "");
            string xPathString = "//Vo:Voluntarios/Vo:Voluntario[@DNI='" + DNI + "']";
            XmlNode xmlNode = doc.DocumentElement.SelectSingleNode(xPathString, nsmgr);
            return xmlNode;
        }
        public XmlElement añadirVoluntario(string nombre, string apellido, string DNI,
   string correo, string telefono, string disponibilidad, XmlDocument doc)
        {

            XmlElement voluntario = doc.CreateElement("Voluntario", "");


            XmlAttribute attribute = doc.CreateAttribute("Nombre");
            attribute.Value = nombre;
            voluntario.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Apellidos");
            attribute.Value = apellido;
            voluntario.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("DNI");
            attribute.Value = DNI;
            voluntario.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("DireccionCorreo");
            attribute.Value = correo;
            voluntario.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Telefono");
            attribute.Value = telefono;
            voluntario.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("HorasDisponible");
            attribute.Value = disponibilidad;
            voluntario.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Caratula");
            attribute.Value = "imagenesVoluntarios/10.png";
            voluntario.Attributes.Append(attribute);

            voluntario.InnerText = "\n";

            return voluntario;
        }
    }


    }
