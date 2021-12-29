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
       

        public MainWindow()
        {
            InitializeComponent();
            spDinamico.Content = new Inicio();
            VentanaInicioSesion loggin = new VentanaInicioSesion(this);
            loggin.ShowDialog();
            nombre = loggin.txtUsuario.Text + " " + DateTime.Now.ToString();
            txtUsuario.Text = nombre;
           

        }
       

        private void mnAnimales_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            AnimalsWindow ventana1 = new AnimalsWindow(this);
            ventana1.ShowDialog();
        }
     
        

        private void btnAñadirVoluntario_Click(object sender, RoutedEventArgs e)
        {
            
        }

        

        private void monstrarSocios(object sender, MouseButtonEventArgs e)
        {
            spDinamico.Content = new Socios();
            
        }

        private void mnPrincipal_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void mostrarVoluntarios(object sender, MouseButtonEventArgs e)
        {
            spDinamico.Content = new Voluntarios();
        }
    }
   

    }
    

     

