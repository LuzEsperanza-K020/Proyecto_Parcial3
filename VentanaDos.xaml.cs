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
    /// Lógica de interacción para VentanaDos.xaml
    /// </summary>
    public partial class VentanaDos : Window
    {
        public VentanaDos()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            Ventana1 ventana1 = new Ventana1();
            ventana1.Show();
            this.Close();
        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 ventana2 = new Ventana2();
            ventana2.Show();
            this.Close();
        }

        private void boton3_Click(object sender, RoutedEventArgs e)
        {
            Ventana3 ventana3 = new Ventana3();
            ventana3.Show();
            this.Close();
        }

        private void boton4_Click(object sender, RoutedEventArgs e)
        {
            Ventana4 ventana4 = new Ventana4();
            ventana4.Show();
            this.Close();
        }

        private void boton5_Click(object sender, RoutedEventArgs e)
        {
            Ventana5 ventana5 = new Ventana5();
            ventana5.Show();
            this.Close();
        }

        private void boton6_Click(object sender, RoutedEventArgs e)
        {
            Ventana6 ventana6 = new Ventana6();
            ventana6.Show();
            this.Close();
        }

        private void regresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
