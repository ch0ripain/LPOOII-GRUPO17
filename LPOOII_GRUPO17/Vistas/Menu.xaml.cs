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
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private Usuario usuarioLogueado;
        public Menu(Usuario usuarioLog)
        {
            InitializeComponent();
            this.Closing += Menu_Closing; // Suscribirte al evento Closing

            usuarioLogueado = usuarioLog;

            if (usuarioLogueado.Rol == "Admin")
            {
                menuItemClientes.Visibility = Visibility.Collapsed;
                menuItemEstacionamiento.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (usuarioLogueado.Rol == "Operador")
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

        private void menuItemClienteModificar_Click(object sender, RoutedEventArgs e)
        {
            ValidarCliente oValidarCliente = new ValidarCliente();
            oValidarCliente.Show();
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

        private void menuItemRegistrarEntrada_Click(object sender, RoutedEventArgs e)
        {
            RegistrarEntrada oRegistrarEntrada = new RegistrarEntrada(usuarioLogueado);
            oRegistrarEntrada.Show();
        }


    }
}
