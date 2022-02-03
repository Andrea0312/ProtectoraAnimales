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

namespace Eventos
{
    /// <summary>
    /// Lógica de interacción para VentanaInicioSesion.xaml
    /// </summary>
    public partial class VentanaInicioSesion : Window
    {
        
        public VentanaInicioSesion()
        {
            InitializeComponent();
            

        }
        private String usuario = "Juan";
        private String password = "123abc";
        private BitmapImage imagCheck = new BitmapImage(new Uri("/imagenes/check.png", UriKind.Relative));
        private BitmapImage imagCross = new BitmapImage(new Uri("/imagenes/cross.png", UriKind.Relative));


        private Boolean ComprobarEntrada(string valorIntroducido, string valorValido, Control componenteEntrada, Image imagenFeedBack)
        {
            Boolean valido = false;
            componenteEntrada.BorderThickness = new Thickness(2);
            if (valorIntroducido.Equals(valorValido))
            {
                // borde y background en verde
                componenteEntrada.BorderBrush = Brushes.Green;
                componenteEntrada.Background = Brushes.LightGreen;
                // imagen al lado de la entrada de usuario --> check
                imagenFeedBack.Source = imagCheck;
                valido = true;
            }
            else
            {
                // marcamos borde en rojo
                componenteEntrada.BorderBrush = Brushes.Red;
                componenteEntrada.Background = Brushes.Salmon;
                // imagen al lado de la entrada de usuario --> cross
                imagenFeedBack.Source = imagCross;
                valido = false;
            }
            return valido;
        }
        

        private BitmapImage imagOriginal = new BitmapImage(new Uri("/imagenes/avatar1.png", UriKind.Relative));
        private BitmapImage imagRollOver = new BitmapImage(new Uri("/imagenes/avatar2.png", UriKind.Relative));



        private void imgAvatar_MouseEnter(object sender, MouseEventArgs e)
        {
            imgAvatar.Source = imagRollOver;

        }

        private void imgAvatar_MouseLeave(object sender, MouseEventArgs e)
        {
            imgAvatar.Source = imagOriginal;
        }


        private void passContrasena_KeyUp(object sender, KeyEventArgs e)
        {
            lblEstado.Content = "Has pulsado la tecla <<" + e.Key.ToString() + ">>";


        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (ComprobarEntrada(txtUsuario.Text, usuario, txtUsuario, imgCheckUsuario) && 
                ComprobarEntrada(passContrasena.Password, password, passContrasena, imgCheckContrasena))
            {
                MainWindow principal = new MainWindow(this);
                principal.Show();
                principal.spDinamico.Content = new Inicio();
                this.Close();

            }
        }

        private void Usuario_getFocus(object sender, RoutedEventArgs e)
        {
            txtUsuario.BorderBrush = Brushes.Transparent;
            txtUsuario.Background = Brushes.White;
        }

        private void contraseña_GetFocus(object sender, RoutedEventArgs e)
        {
            passContrasena.BorderBrush = Brushes.Transparent;
            passContrasena.Background = Brushes.White;
        }

     

        private void usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                passContrasena.Focus();
            }
        }

        private void contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                if (ComprobarEntrada(txtUsuario.Text, usuario, txtUsuario, imgCheckUsuario) &&
                ComprobarEntrada(passContrasena.Password, password, passContrasena, imgCheckContrasena))
                {
                    MainWindow principal = new MainWindow(this);
                    principal.Show();
                    principal.spDinamico.Content = new Inicio();
                    this.Close();
                }

            }

        }
    }
}
 
