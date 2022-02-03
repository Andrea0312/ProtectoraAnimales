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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nombre;
        VentanaInicioSesion padre;
       

        public MainWindow(VentanaInicioSesion padre)
        {
            InitializeComponent();
            this.padre = padre;
            nombre = padre.txtUsuario.Text + " " + DateTime.Now.ToString();
            txtUsuario.Text = nombre;
           

        }

        private void mnPrincipal_Click(object sender, RoutedEventArgs e)
        {

            spDinamico.Content = new Inicio();
        }

        private void mnAnimales_Click(object sender, RoutedEventArgs e)
        {
            spDinamico.Content = new Animales();
        }

        private void mnVoluntarios_Click(object sender, RoutedEventArgs e)
        {
            spDinamico.Content = new Voluntarios();
        }

        private void mnSocios_Click(object sender, RoutedEventArgs e)
        {
            spDinamico.Content = new Socios();
        }

        private void mnContacto_Click(object sender, RoutedEventArgs e)
        {
            spDinamico.Content = new Contacto();
        }
    }
   

    }
    

     

