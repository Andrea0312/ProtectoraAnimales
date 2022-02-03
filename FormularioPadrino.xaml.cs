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
    /// Lógica de interacción para FormularioPadrino.xaml
    /// </summary>
    public partial class FormularioPadrino : Window
    {
        public FormularioPadrino()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAñadir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Datos añadidios correctamente.", "Protectora Juni", MessageBoxButton.OK);
            this.Close();
        }
    }
}
