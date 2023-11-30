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
        private static Usuario usuarioLogueado;
        public Menu(Usuario usuarioLog)
        {
            InitializeComponent();
            this.Closing += Menu_Closing; // Suscribirte al evento Closing

            usuarioLogueado = usuarioLog;

            if (usuarioLogueado.Rol == "Admin")
            {
                menuItemClientes.Visibility = Visibility.Collapsed;
                menuItemEstacionamiento.Visibility = Visibility.Collapsed;
                lblUsuario.Content = usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;
                lblRol.Content = usuarioLogueado.Rol;
                wdwMenu.Title += " ADMIN";
            }
            else
            {
                if (usuarioLogueado.Rol == "Operador")
                {
                    menuItemSectores.Visibility = Visibility.Collapsed;
                    menuItemTipoVehiculo.Visibility = Visibility.Collapsed;
                    menuItemUsuario.Visibility = Visibility.Collapsed;
                    lblUsuario.Content = usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;
                    lblRol.Content = usuarioLogueado.Rol;
                    wdwMenu.Title += " OPERADOR";
                }
            }
        }

        public static Usuario ObtenerUsuarioLogueado()
        {
            return usuarioLogueado;
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
            VehiculosEnPlaya oVehiculosEnPlaya = new VehiculosEnPlaya();
            oVehiculosEnPlaya.Show();
        }

        private void menuItemVerSectores_Click(object sender, RoutedEventArgs e)
        {
            VehiculosEnPlaya oVehiculosEnPlaya = new VehiculosEnPlaya();
            oVehiculosEnPlaya.Show();
        }

        private void menuItemRegistrarSalida_Click(object sender, RoutedEventArgs e)
        {
            VehiculosEnPlaya oVehiculosEnPlaya = new VehiculosEnPlaya();
            oVehiculosEnPlaya.Show();
        }

        private void menuItemTipoVehiculoGestionar_Click(object sender, RoutedEventArgs e)
        {
            ABMTipoVehiculo oABMTV = new ABMTipoVehiculo();
            oABMTV.Show();
        }

        private void menuItemUsuario_Listar_Click(object sender, RoutedEventArgs e)
        {
            ListadoDeUsuarios oListadoDeUsuarios = new ListadoDeUsuarios();
            oListadoDeUsuarios.Show();
        }

        private void menuItemUsuario_Gestionar_Click(object sender, RoutedEventArgs e)
        {
            ABMUsuarios oABMUsuarios = new ABMUsuarios();
            oABMUsuarios.Show();
        }

        private void menuItemEstacionamiento_Click(object sender, RoutedEventArgs e)
        {
            VehiculosEnPlaya oVehiculosEnPlaya = new VehiculosEnPlaya();
            oVehiculosEnPlaya.Show();
        }

        private void menuItemClienteGestionar_Click(object sender, RoutedEventArgs e)
        {
            ABMClientes oABM = new ABMClientes();
            oABM.Show();
        }

        private void VerSectoresOcupados_Click(object sender, RoutedEventArgs e)
        {
            ListadoDeSectoresOcupados oListado = new ListadoDeSectoresOcupados();
            oListado.Show();
        }

        private void menuItemAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            AcercaDe oAcercaDe = new AcercaDe();
            oAcercaDe.Show();
        }

        private void menuItemClientes_Click(object sender, RoutedEventArgs e)
        {
            ABMClientes oABMClientes = new ABMClientes();
            oABMClientes.Show();
        }

        private void menuItemEstacionamiento_Gestionar_Click(object sender, RoutedEventArgs e)
        {
            VehiculosEnPlaya oVehiculosEnPlaya = new VehiculosEnPlaya();
            oVehiculosEnPlaya.Show();
        }

        private void menuItemEstacionamiento_VerSectoresOcupados_Click(object sender, RoutedEventArgs e)
        {
            ListadoDeSectoresOcupados oListado = new ListadoDeSectoresOcupados();
            oListado.Show();
        }
    }
}
