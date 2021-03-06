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
    /// Lógica de interacción para AnimalsWindow.xaml
    /// </summary>
    public partial class AnimalsWindow : Window
    {
        MainWindow padre;
        public AnimalsWindow(MainWindow padre)
        {
            InitializeComponent();
            this.padre = padre;
            txtUsuario.Text = padre.txtUsuario.Text;
            padre.Hide();
        }

        private void mnPrincipal_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            padre.ShowDialog();
            
        }
    }
}
