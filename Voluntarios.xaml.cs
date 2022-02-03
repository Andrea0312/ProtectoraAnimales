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
       
        public List<Voluntarios> listadoVoluntarios;
        public Voluntarios()
        {
            InitializeComponent();

            listadoVoluntarios = CargarContenidoXMLVoluntarios();
            DataContext = listadoVoluntarios;

        }
        public List<Voluntarios> CargarContenidoXMLVoluntarios()
        {
            List<Voluntarios> listadoV = new List<Voluntarios>();
            XmlDocument doc = new XmlDocument();
            try { doc.Load("Voluntarios.xml"); }
            catch (System.IO.FileNotFoundException)
            {
                doc.LoadXml("<?xml version=\"1.0\"?> \n" +
                "<Voluntarios> \n" +
                "  <Voluntario Nombre=\"Pedro\" Apellidos=\"Sanchéz Bermejo\" DNI=\"08926552P\" DireccionCorreo=\"pedro@alu.uclm.es\" " +
                "Telefono=\"642945579\" HorasDisponible=\"Lunes - Miércoles: 09:00 - 14:00\" Caratula=\"imagenesVoluntarios/10.png\" /> \n" +
                "</Voluntarios>");
                doc.Save("Voluntarios.xml");
            }

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

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            FormularioVoluntario formularioVoluntario = new FormularioVoluntario(this);
            formularioVoluntario.ShowDialog();
            lstListaVoluntarios.Items.Refresh();

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Voluntarios.xml");

            XmlNode j = GetVoluntario(lblDNI.Content.ToString(), doc);
            XmlElement root = doc.DocumentElement;
            if(MessageBox.Show("¿Desea eliminar el elemento seleccionado?","Protectora Juni", MessageBoxButton.YesNo)==MessageBoxResult.Yes)
            {
                root.RemoveChild(j);
                doc.Save("Voluntarios.xml");

                listadoVoluntarios.RemoveAt(lstListaVoluntarios.SelectedIndex);
                lstListaVoluntarios.Items.Refresh();
            }

        
        }
        public XmlNode GetVoluntario(string DNI, XmlDocument doc)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("Vo", "");
            string xPathString = "//Vo:Voluntarios/Vo:Voluntario[@DNI='" + DNI + "']";
            XmlNode xmlNode = doc.DocumentElement.SelectSingleNode(xPathString, nsmgr);
            return xmlNode;
        }

        private void btn_editar_Click(object sender, RoutedEventArgs e)
        {
            FormularioVoluntario formulario = new FormularioVoluntario(this);

            formulario.txtDNI.Text = lblDNI.Content.ToString();
            formulario.txtDNI.IsEnabled = false;
            formulario.txtNombre.Text = lblNombre.Content.ToString();
            formulario.txtApellidos.Text = lblApellido.Content.ToString();
            formulario.txtTelefono.Text = lblTelefono.Content.ToString();
            formulario.txtCorreo.Text = lblCorreo.Content.ToString();
            formulario.txtHorasDip.Text = lblHorario.Content.ToString();

            formulario.Show();
        }
    }
}
