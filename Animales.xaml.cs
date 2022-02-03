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
        public List<Animales> listadoAnimales;
        public Animales()
        {
            InitializeComponent();
            listadoAnimales = CargarContenidoXML();
            DataContext = listadoAnimales;
        }

        public List<Animales> CargarContenidoXML()
        {
            List<Animales> listadoA = new List<Animales>();
            XmlDocument doc = new XmlDocument();

            try { doc.Load("Animales.xml"); }
            catch (System.IO.FileNotFoundException)
            {
                doc.LoadXml("<?xml version=\"1.0\"?> \n" +
                "<Animales> \n" +
                "  <Animal Nombre= \"Lola\" Sexo=\"Hembra\" Raza=\"223\" Tamano=\"Perro mediano\"" +
                " Peso=\"20kg\" Edad=\"10 años\" Vacunado=\"Si\" Chip=\"Si\" Apadrinado=\"Si\" Caratula=\"imagenes/avatar1.png\" /> \n" +
                "  <Animal Nombre= \"Rex\" Sexo=\"Macho\" Raza=\"123\" Tamano=\"Perro grande\"" +
                " Peso=\"40kg\" Edad=\"8 años\" Vacunado=\"Si\" Chip=\"Si\" Apadrinado=\"Si\" Caratula=\"imagenes/avatar1.png\" /> \n" +

                "</Animales>");
                doc.Save("Animales.xml");
            }

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

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            FormularioAnimales formularioAnimales = new FormularioAnimales(this);
            formularioAnimales.Show();

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Animales.xml");
            
            XmlNode j = GetAnimal(lblNombre.Content.ToString(), doc) ;
            XmlElement root = doc.DocumentElement;
            if (MessageBox.Show("¿Desea eliminar el elemento seleccionado?", "Protectora Juni", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                root.RemoveChild(j);
                doc.Save("Animales.xml");

                listadoAnimales.RemoveAt(lstListaAnimales.SelectedIndex);
                lstListaAnimales.Items.Refresh();
            }
        }
        public XmlNode GetAnimal(string nombre, XmlDocument doc)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("An", "");
            string xPathString = "//An:Animales/An:Animal[@Nombre='" + nombre + "']";
            XmlNode xmlNode = doc.DocumentElement.SelectSingleNode(xPathString, nsmgr);
            return xmlNode;
        }

        private void btn_padrino_Click(object sender, RoutedEventArgs e)
        {
            FormularioPadrino formulario1 = new FormularioPadrino();
            formulario1.Show();
        }

        private void btn_editar_Click(object sender, RoutedEventArgs e)
        {
            FormularioAnimales formulario = new FormularioAnimales(this);
            formulario.txtNombre.Text = lblNombre.Content.ToString();
            formulario.txtNombre.IsEnabled = false;
            formulario.txtSexo.Text = lblSexo.Content.ToString();
            formulario.txtEdad.Text = lblEdad.Content.ToString();
            formulario.txtPeso.Text = lblPeso.Content.ToString();
            formulario.txtRaza.Text = lblRaza.Content.ToString();
            formulario.txtTamaño.Text = lblTamaño.Content.ToString();
            if (lblApadrinado.Content.ToString().Equals("Si"))
            {
                formulario.rbSi2.IsChecked = true;
            }
            else
            {
                formulario.rbNo2.IsChecked = true;
            }

            formulario.Show();

        }

        private void lstListaAnimales_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lstListaAnimales.SelectedItem != null)
            {
                if (lblApadrinado.Content.ToString().Equals("Si"))
                {
                    btn_padrino.IsEnabled = true;
                }
                else
                {
                    btn_padrino.IsEnabled = false;
                }
            }
            
        }
    }
}
