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
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Page
    {
        int i = 1;

        public Inicio()
        {
            InitializeComponent();
        }

        private void Siguiente(object sender, RoutedEventArgs e)
        {
            i++;
            if (i > 5)
            {
                i = 1;
            }
            CarrouselFoto.Source = new BitmapImage(new Uri(@"imagenesCarusel/" + i + ".jpg", UriKind.Relative));
        }

        private void Atras(object sender, RoutedEventArgs e)
        {
            i--;
            if (i < 1)
            {
                i = 5;
            }
            CarrouselFoto.Source = new BitmapImage(new Uri(@"imagenesCarusel/" + i + ".jpg", UriKind.Relative));
        }
    }
}
