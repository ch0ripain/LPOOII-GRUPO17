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
using System.Collections.ObjectModel;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for ABMClientes.xaml
    /// </summary>
    public partial class ABMClientes : Window
    {
        CollectionView Vista;
        ObservableCollection<Cliente> listaCliente;
        public ABMClientes()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ObjectDataProvider odp = (ObjectDataProvider)this.Resources["LIST_CLIENT"];
            listaCliente = odp.Data as ObservableCollection<Cliente>;

            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_content.DataContext);
        }

        private void btnNuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            AgregarCliente oAgregarCliente = new AgregarCliente();
            oAgregarCliente.ShowDialog();
            if (oAgregarCliente.clienteAgregado == true)
            {
                ActualizarListaClientes();
                Vista.MoveCurrentToLast();
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            ValidarCliente oValidarCliente = new ValidarCliente();
            oValidarCliente.ShowDialog();
            if (oValidarCliente.clienteModificado == true)
            {
                ActualizarListaClientes();
            }
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            ListadoDeClientes oListadoDeClientes = new ListadoDeClientes();
            oListadoDeClientes.Show();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Desea eliminar este cliente?\nDNI: " + txtClienteDNI.Text + "\nNombre: " + txtNombre.Text + "\nApellido: " + txtApellido.Text + "\nTeléfono: " + txtTelefono.Text, "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                TrabajarClientes.EliminarCliente(int.Parse(txtClienteDNI.Text));
                MessageBox.Show("Cliente eliminado con éxito!", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                ActualizarListaClientes();
                Vista.MoveCurrentToLast();
            }
        }

        private void btnPrimero_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToFirst();
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            if (Vista.CurrentPosition == 0)
            {
                Vista.MoveCurrentToLast(); // Ir al último elemento de la colección
            }
            else
            {
                Vista.MoveCurrentToPrevious();
            }
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (Vista.CurrentPosition == Vista.Count - 1)
            {
                Vista.MoveCurrentToFirst(); // Ir al primer elemento de la colección
            }
            else
            {
                Vista.MoveCurrentToNext();
            }
        }

        private void btnUltimo_Click(object sender, RoutedEventArgs e)
        {
            Vista.MoveCurrentToLast();
        }

        private void ActualizarListaClientes()
        {
            // Llama al método para obtener la lista actualizada de usuarios
            ObservableCollection<Cliente> clientesActualizados = TrabajarClientes.TraerClientes();

            // Asigna la nueva lista al DataContext
            canvas_content.DataContext = clientesActualizados;

            // Crea la vista de nuevo con la lista actualizada
            Vista = (CollectionView)CollectionViewSource.GetDefaultView(canvas_content.DataContext);
        }

        


    }
}
