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
        MainWindow padre;
        public VentanaInicioSesion(MainWindow padre)
        {
            InitializeComponent();
            this.padre = padre;
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
                componenteEntrada.Background = Brushes.Red;
                // imagen al lado de la entrada de usuario --> cross
                imagenFeedBack.Source = imagCross;
                valido = false;
            }
            return valido;
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                lblEstado.Content = "Se pulsó el enter ";
                if (!String.IsNullOrEmpty(txtUsuario.Text) && ComprobarEntrada(txtUsuario.Text, usuario, txtUsuario, imgCheckUsuario))
                {
                    // habilitar entrada de contraseña y pasarle el foco
                    passContrasena.IsEnabled = true;
                    passContrasena.Focus();
                   
                }
            }
        }

        private BitmapImage imagOriginal = new BitmapImage(new Uri("/imagenes/avatar1.png", UriKind.Relative));
        private BitmapImage imagRollOver = new BitmapImage(new Uri("/imagenes/avatar2.png", UriKind.Relative));



        private void imgAvatar_MouseEnter(object sender, MouseEventArgs e)
        {
            imgAvatar.Source = imagRollOver;
            lblEstado.Content = "Entrando en el avatar y cambiando imagen";
        }

        private void imgAvatar_MouseLeave(object sender, MouseEventArgs e)
        {
            imgAvatar.Source = imagOriginal;
            lblEstado.Content = "Saliendo del avatar y restaurando la imagen";
        }

        private void diseñoPrincipal_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(this);
            lblEstado.Content = "Coordenadas del click: (" + p.X + ", " + p.Y + ")";
        }

        private void passContrasena_KeyUp(object sender, KeyEventArgs e)
        {
            lblEstado.Content = "Has pulsado la tecla <<" + e.Key.ToString() + ">>";
            if (ComprobarEntrada(passContrasena.Password, password, passContrasena, imgCheckContrasena))
                btnLogin.Focus();

        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (ComprobarEntrada(txtUsuario.Text, usuario, txtUsuario, imgCheckUsuario) &&
                   ComprobarEntrada(passContrasena.Password, password, passContrasena, imgCheckContrasena))
            {
               
                this.Close();

                //Application.Current.Shutdown();

            }
        }

    }
}
 
