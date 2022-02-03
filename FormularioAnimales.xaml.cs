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
    /// Lógica de interacción para FormularioAnimales.xaml
    /// </summary>
    public partial class FormularioAnimales : Window
    {
        Animales padre;
        public FormularioAnimales(Animales padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            
            String Nombre = txtNombre.Text;
            String Sexo = txtSexo.Text;
            String Raza = txtRaza.Text;
            String Tamano =txtTamaño.Text;
            String Peso = txtPeso.Text;
            String Edad = txtEdad.Text;
            String Vacunado = "No";
            String Chip = "No";
            String Apadrinado = "No";
            if (rbSi.IsChecked == true)
            {
                Vacunado = "Si";
            }
            if (rbSi1.IsChecked == true)
            {
                Chip = "Si";
            }
            if (rbSi2.IsChecked == true)
            {
                Apadrinado = "Si";
            }

            XmlDocument doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.Load("Animales.xml");

            XmlNode j = GetAnimal(txtNombre.Text, doc);
            XmlElement h = añadirAnimal(Nombre,Sexo,Raza,Tamano,Peso,Edad,Vacunado,Chip,Apadrinado,doc);

           

            XmlElement root = doc.DocumentElement;

            if (j!=null)
            {
                root.RemoveChild(j);

            }   
          
            root.AppendChild(h);
            doc.Save("Animales.xml");
            padre.listadoAnimales = padre.CargarContenidoXML();
            padre.DataContext = padre.listadoAnimales;
            MessageBox.Show("Datos añadidios correctamente.", "Protectora Juni", MessageBoxButton.OK);
            this.Close();


        }

        public XmlNode GetAnimal(string nombre, XmlDocument doc)
        {
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
            nsmgr.AddNamespace("An", "");
            string xPathString = "//An:Animales/An:Animal[@Nombre='" + nombre + "']";
            XmlNode xmlNode = doc.DocumentElement.SelectSingleNode(xPathString, nsmgr);
            return xmlNode;
        }


        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public XmlElement añadirAnimal(string nombre, string sexo, string raza,
    string tamaño, string peso, string edad, string vacunado, string chip, string apadrinado, XmlDocument doc)
        {
            
            XmlElement animal = doc.CreateElement("Animal", "");

            
            XmlAttribute attribute = doc.CreateAttribute("Nombre");
            attribute.Value = nombre;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Sexo");
            attribute.Value = sexo;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Raza");
            attribute.Value = raza;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Tamano");
            attribute.Value = tamaño;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Peso");
            attribute.Value = peso;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Edad");
            attribute.Value = edad;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Vacunado");
            attribute.Value = vacunado;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Chip");
            attribute.Value = chip;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Apadrinado");
            attribute.Value = apadrinado;
            animal.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("Caratula");
            attribute.Value = "imagenes/avatar1.png";
            animal.Attributes.Append(attribute);

            animal.InnerText = "\n";
  
            return animal;
        }

       
    }
}
