using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for VehiculosEnPlaya.xaml
    /// </summary>
    public partial class VehiculosEnPlaya : Window
    {
        public VehiculosEnPlaya()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btn7.Background = Brushes.Red;
        }

        private void btnSector_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (btn != null)
            {
                if (btn.Background.Equals(Brushes.LawnGreen))
                {
                    MessageBox.Show("Sector Disponible. Desea registrar una entrada?", "Registrar entrada del sector", MessageBoxButton.YesNo, MessageBoxImage.Question);
                }
                if (btn.Background.Equals(Brushes.Red))
                {
                    MessageBox.Show("Sector Ocupado. Desea registrar una salida?", "Registrar salida del sector", MessageBoxButton.YesNo, MessageBoxImage.Question);
                }
                if (btn.Background.Equals(Brushes.DarkGray))
                {
                    MessageBox.Show("Sector deshabilitado!","Información del sector", MessageBoxButton.OK , MessageBoxImage.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
