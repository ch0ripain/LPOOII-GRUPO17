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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu(string rol)
        {
            InitializeComponent();
            this.Closing += Menu_Closing; // Suscribirte al evento Closing

            if (rol == "Admin")
            {
                menuItemClientes.Visibility = Visibility.Collapsed;
                menuItemEstacionamiento.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (rol == "Operador")
                {
                    menuItemSectores.Visibility = Visibility.Collapsed;
                    menuItemTipoVehiculo.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Menu_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Aquí, cuando se cierra la ventana, cerramos la aplicación por completo
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void menuItemClienteAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarCliente oAgregarCliente = new AgregarCliente();
            oAgregarCliente.Show();
        }

        private void menuItemTipoVehiculoAgregar_Click(object sender, RoutedEventArgs e)
        {
            AgregarTipoVehiculo oAgregarTipoVehiculo = new AgregarTipoVehiculo();
            oAgregarTipoVehiculo.Show();
        }

        private void menuItemTipoVehiculoListar_Click(object sender, RoutedEventArgs e)
        {
            ListarTipoVehiculo oListarTipoVehiculo = new ListarTipoVehiculo();
            oListarTipoVehiculo.Show();
        }


    }
}
