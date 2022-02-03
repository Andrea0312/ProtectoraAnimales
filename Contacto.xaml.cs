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

namespace Eventos
{
    /// <summary>
    /// Lógica de interacción para Contacto.xaml
    /// </summary>
    public partial class Contacto : Page
    {
        public Contacto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gracias, recibira un mensaje de confirmación al correo electrónico: " +txt_correo.Text,"Protectora Juni",MessageBoxButton.OK);
            txt_apellido.Text = "";
            txt_correo.Text = "";
            txt_nombre.Text = "";
            txt_telefono.Text = "";
            txt_mensaje.Text = "";
            
        }
    }
}
