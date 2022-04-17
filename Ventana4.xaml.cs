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

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para Ventana4.xaml
    /// </summary>
    public partial class Ventana4 : Window
    {
        public Ventana4()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, RoutedEventArgs e)
        {
            VentanaDos ventanaDos = new VentanaDos();
            ventanaDos.Show();
            this.Close();
        }

        private void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
